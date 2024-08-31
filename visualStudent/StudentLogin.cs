using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace visualStudent
{
    public partial class StudentLogin : Form
    {
        public static int StudentID;

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string id = studentid.Text;
            string password = Password.Text;
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    string findStudentQuery = "SELECT FirstName, LastName FROM Student WHERE StudentID = @StudentID";
                    SqlCommand findStudentCmd = new SqlCommand(findStudentQuery, conn);
                    findStudentCmd.Parameters.AddWithValue("@StudentID", id);

                    SqlDataReader reader = findStudentCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);

                        string generatedPassword = GeneratePassword(firstName, lastName);

                        // Kullanıcının girdiği şifre ile oluşturulan şifreyi karşılaştır
                        if (password == generatedPassword)
                        {
                            MessageBox.Show("Giriş başarılı!");
                            StudentID = Convert.ToInt32(id);

                            // Giriş başarılıysa, ana uygulama formunu açabilirsiniz
                            Buy buy = new Buy(StudentLogin.StudentID);
                            buy.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz şifre.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz öğrenci ID.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private string GeneratePassword(string firstName, string lastName)
        {
            // İlk ismin ilk harfi
            string firstLetter = firstName.Substring(0, 1).ToLower();
            // Soyadın son harfi
            string lastLetter = lastName.Substring(lastName.Length - 1, 1).ToLower();

            // Şifreyi oluştur
            string password = firstLetter + lastLetter;

            return password;
        }
    }
}
