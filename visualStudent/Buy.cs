
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace visualStudent
{
    public partial class Buy : Form
    {
        private int studentID;

        public Buy(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT p.ProductID, p.ProductName, p.Price
                FROM Product p
                LEFT JOIN ProductRestriction pr 
                    ON p.ProductID = pr.ProductID 
                    AND pr.ParentID = (SELECT ParentID FROM Student WHERE StudentID = @StudentID)
                WHERE pr.Restriction IS NULL OR pr.Restriction != 'Not Allowed'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", this.studentID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewProducts.DataSource = dt;
                    // Hide the ProductID column
                    if (dataGridViewProducts.Columns.Contains("ProductID"))
                    {
                        dataGridViewProducts.Columns["ProductID"].Visible = false;
                    }
                    if (dataGridViewProducts.Columns.Contains("Restriction"))
                    {
                        dataGridViewProducts.Columns["Restriction"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void dataGridViewProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "ProductName")
            {
                var cell = dataGridViewProducts[e.ColumnIndex, e.RowIndex];
                if (cell != null && cell.Value != null && cell.Value != DBNull.Value && cell.Value.ToString() == "Not Allowed")
                {
                    e.CellStyle.Font = new Font(dataGridViewProducts.Font, FontStyle.Strikeout);
                    e.CellStyle.ForeColor = Color.Gray; // Optional: To make the text look grayed out
                }
            }
        }



        private void buttonBuy_Click(object sender, EventArgs e)
        {
            // Seçilen ürünlerin satın alınabilirliğini kontrol et
            foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
            {
                DataGridViewCell restrictionCell = row.Cells["Restriction"];
                if (restrictionCell != null && restrictionCell.Value != null && restrictionCell.Value.ToString() == "Not Allowed")
                {
                    MessageBox.Show("Bu ürünü satın alamazsınız.");
                    return;
                }
            }

            // Satın alma işlemini gerçekleştir
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Kart bakiyesini kontrol et
                    string balanceQuery = "SELECT Balance FROM Card WHERE StudentID = @StudentID";
                    SqlCommand balanceCmd = new SqlCommand(balanceQuery, conn, transaction);
                    balanceCmd.Parameters.AddWithValue("@StudentID", studentID);
                    var balanceResult = balanceCmd.ExecuteScalar();

                    if (balanceResult == null)
                    {
                        MessageBox.Show("Kart bakiyesi bulunamadı!");
                        transaction.Rollback();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kart bakiyesi bulundu: " + balanceResult.ToString());
                    }

                    decimal balance = (decimal)balanceResult;

                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        if (row.Selected)
                        {
                            // ProductID ve Price bilgilerini al
                            int productID = Convert.ToInt32(row.Cells["ProductID"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                            // Seçili ürünün satın alınabilirliğini kontrol et
                            DataGridViewCell restrictionCell = row.Cells["Restriction"];
                            if (restrictionCell != null && restrictionCell.Value != null && restrictionCell.Value.ToString() == "Not Allowed")
                            {
                                MessageBox.Show("Bu ürünü satın alamazsınız.");
                                transaction.Rollback();
                                return;
                            }

                            if (balance >= price)
                            {
                                // Bakiyeyi düş
                                string updateBalanceQuery = "UPDATE Card SET Balance = Balance - @Price WHERE StudentID = @StudentID";
                                SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, conn, transaction);
                                updateBalanceCmd.Parameters.AddWithValue("@Price", price);
                                updateBalanceCmd.Parameters.AddWithValue("@StudentID", studentID);
                                updateBalanceCmd.ExecuteNonQuery();

                                // İşlemi kaydet
                                string insertTransactionQuery = @"
                            INSERT INTO Transection (StudentID, ProductID, Quantity, TransectionDate)
                            VALUES (@StudentID, @ProductID, 1, @TransectionDate)";
                                SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction);
                                insertTransactionCmd.Parameters.AddWithValue("@StudentID", studentID);
                                insertTransactionCmd.Parameters.AddWithValue("@ProductID", productID);
                                insertTransactionCmd.Parameters.AddWithValue("@TransectionDate", DateTime.Now);
                                insertTransactionCmd.ExecuteNonQuery();

                                balance -= price; // Local balance güncelle

                                MessageBox.Show("Satın alma işlemi başarılı!");
                            }
                            else
                            {
                                MessageBox.Show("Yetersiz bakiye!");
                            }
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }



        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}