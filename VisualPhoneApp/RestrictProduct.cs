using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VisualPhoneApp
{
    public partial class RestrictProduct : Form
    {
        private string parentEmail;
        public RestrictProduct(string email)
        {
            InitializeComponent();
            parentEmail = email;
            LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    string productQuery = "SELECT p.ProductID, p.ProductName, p.Price, ISNULL(pr.Restricted, 0) AS IsRestricted " +
                                          "FROM Product p " +
                                          "LEFT JOIN (SELECT ProductID, 1 AS Restricted FROM ProductRestriction WHERE ParentID = @ParentID) pr " +
                                          "ON p.ProductID = pr.ProductID";
                    SqlCommand cmd = new SqlCommand(productQuery, conn);
                    cmd.Parameters.AddWithValue("@ParentID", GetParentIDByEmail(parentEmail));

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Ürün adı ve fiyatı üzerine çizgi çizme
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        bool isRestricted = Convert.ToBoolean(row.Cells["IsRestricted"].Value);
                        if (isRestricted)
                        {
                            row.Cells["ProductName"].Style.Font = new Font(dataGridView1.Font, FontStyle.Strikeout);
                            row.Cells["Price"].Style.Font = new Font(dataGridView1.Font, FontStyle.Strikeout);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private int GetParentIDByEmail(string ParentEmail)
        {
            int parentID = -1;
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ParentID FROM Parent WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", ParentEmail);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        parentID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            return parentID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int parentID = GetParentIDByEmail(parentEmail); // ParentID'yi aldık

            if (parentID != -1) // ParentID geçerliyse devam et
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["colCheckbox"] is DataGridViewCheckBoxCell chk && Convert.ToBoolean(chk.Value)) // CheckBox işaretliyse
                    {
                        string productName = row.Cells["ProductName"].Value.ToString(); // Ürün adı
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value); // Ürün fiyatı
                        bool isRestricted = Convert.ToBoolean(row.Cells["IsRestricted"].Value); // Ürünün kısıtlı olup olmadığını kontrol et

                        if (!isRestricted) // Eğer ürün zaten kısıtlı değilse, kısıtlama ekle
                        {

                            bool success = AddRestriction(parentID, productName, price);
                            if (success)
                            {
                                MessageBox.Show("Kısıtlama başarıyla eklendi!");
                            }
                            else
                            {
                                MessageBox.Show("Bu ürün zaten kısıtlı!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu ürün zaten kısıtlı!");
                        }

                    }
                }
            }
            LoadProducts();

        }

        private bool AddRestriction(int parentID, string productName, decimal price)
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Öncelikle ürün adını ve fiyatını kullanarak ProductID'yi alalım
                    string getProductIDQuery = "SELECT ProductID FROM Product WHERE ProductName = @ProductName AND Price = @Price";
                    SqlCommand getProductIDCmd = new SqlCommand(getProductIDQuery, conn, transaction);
                    getProductIDCmd.Parameters.AddWithValue("@ProductName", productName);
                    getProductIDCmd.Parameters.AddWithValue("@Price", price);

                    object productIDResult = getProductIDCmd.ExecuteScalar();
                    if (productIDResult != null)
                    {
                        int productID = Convert.ToInt32(productIDResult);

                        // Ürün zaten kısıtlı mı kontrol et
                        string checkRestrictionQuery = "SELECT COUNT(*) FROM ProductRestriction WHERE ParentID = @ParentID AND ProductID = @ProductID";
                        SqlCommand checkRestrictionCmd = new SqlCommand(checkRestrictionQuery, conn, transaction);
                        checkRestrictionCmd.Parameters.AddWithValue("@ParentID", parentID);
                        checkRestrictionCmd.Parameters.AddWithValue("@ProductID", productID);

                        int existingRestrictionCount = Convert.ToInt32(checkRestrictionCmd.ExecuteScalar());
                        if (existingRestrictionCount == 0)
                        {
                            // ProductRestriction tablosuna ekleme yapalım
                            string query = "INSERT INTO ProductRestriction (ParentID, ProductID, Restriction) VALUES (@ParentID, @ProductID, 'Not Allowed')";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@ParentID", parentID);
                            cmd.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                return true; // Başarılı ekleme durumu
                            }
                            else
                            {
                                transaction.Rollback();
                                return false; // Başarısız ekleme durumu
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                            return false; // Ürün zaten kısıtlı durumu
                        }
                    }
                    else
                    {
                        transaction.Rollback();
                        return false; // Ürün bulunamadı durumu
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false; // Hata durumu
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int parentID = GetParentIDByEmail(parentEmail); // ParentID'yi aldık

            if (parentID != -1) // ParentID geçerliyse devam et
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["colCheckbox"] is DataGridViewCheckBoxCell chk && Convert.ToBoolean(chk.Value)) // CheckBox işaretliyse
                    {
                        string productName = row.Cells["ProductName"].Value.ToString(); // Ürün adı
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value); // Ürün fiyatı
                        RemoveRestriction(parentID, productName, price); // Kısıtlamayı kaldır
                    }
                }
                MessageBox.Show("Kısıtlamalar başarıyla kaldırıldı!");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı!");
            }
        }

        private void RemoveRestriction(int parentID, string productName, decimal price)
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM ProductRestriction WHERE ParentID = @ParentID AND ProductID = (SELECT ProductID FROM Product WHERE ProductName = @ProductName AND Price = @Price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ParentID", parentID);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void RestrictProduct_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RestrictProduct_Load_1(object sender, EventArgs e)
        {

        }
    }
}
