using Microsoft.Data.SqlClient;

namespace VisualPhoneApp
{
    public partial class Form1 : Form
    {
        public static string ParentEmail;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parentEmail = Email.Text;
            string parentPassword = Password.Text;
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();

                    // E-posta adresine sahip ebeveyni bul
                    string findParentQuery = "SELECT FirstName, LastName, Phone FROM Parent WHERE Email = @Email";
                    SqlCommand findParentCmd = new SqlCommand(findParentQuery, conn);
                    findParentCmd.Parameters.AddWithValue("@Email", parentEmail);

                    SqlDataReader reader = findParentCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);
                        string phone = reader.GetString(2);

                        string generatedPassword = GeneratePassword(firstName, lastName, phone.Substring(phone.Length - 2));

                        // Kullan�c�n�n girdi�i �ifre ile olu�turulan �ifreyi kar��la�t�r
                        if (parentPassword == generatedPassword)
                        {
                            MessageBox.Show("Giri� ba�ar�l�!");
                            ParentEmail = parentEmail;
                            // Giri� ba�ar�l�ysa, ana uygulama formunu a�abilirsiniz
                            Choose Choose = new Choose();
                            Choose.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ge�ersiz �ifre.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ge�ersiz e-posta adresi.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata olu�tu: " + ex.Message);
                }
            }
        }
        private string GeneratePassword(string firstName, string lastName, string phoneLastTwoDigits)
        {
            // �lk ismin ilk harfi
            string firstLetter = firstName.Substring(0, 1);
            // Soyad�n ilk harfi
            string lastLetter = lastName.Substring(0, 1);
            // Telefon numaras�n�n son iki hanesi
            string lastTwoDigits = phoneLastTwoDigits;

            // �ifreyi olu�tur
            string password = firstLetter.ToLower() + lastLetter.ToUpper() + lastTwoDigits;

            return password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

