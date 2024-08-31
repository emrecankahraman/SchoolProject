using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualPhoneApp
{
    public partial class LoadMoney : Form
    {
        public LoadMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amountToAdd = decimal.Parse(Balance.Text);

            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    // Ebeveynin e-posta adresine bağlı öğrenci kimliğini bul
                    string findStudentQuery = @"
                        SELECT c.CardID 
                        FROM Card c 
                        INNER JOIN Student s ON c.StudentID = s.StudentID 
                        INNER JOIN Parent p ON s.ParentID = p.ParentID 
                        WHERE p.Email = @ParentEmail";

                    SqlCommand findStudentCmd = new SqlCommand(findStudentQuery, conn);
                    findStudentCmd.Parameters.AddWithValue("@ParentEmail", Form1.ParentEmail);

                    int cardId = (int)findStudentCmd.ExecuteScalar();

                    // Kart bakiyesini güncelle
                    string updateBalanceQuery = "UPDATE Card SET Balance = Balance + @Amount WHERE CardID = @CardID";
                    SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, conn);
                    updateBalanceCmd.Parameters.AddWithValue("@Amount", amountToAdd);
                    updateBalanceCmd.Parameters.AddWithValue("@CardID", cardId);

                    int rowsAffected = updateBalanceCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Bakiye başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci kartı bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
