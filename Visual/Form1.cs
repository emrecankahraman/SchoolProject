using System.Data.SqlClient;

namespace Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Management WHERE UserName=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);


                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                     
                        // Ana uygulama formunu açabilirsiniz
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanýcý adý veya þifre.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Event handler code here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler code here
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Event handler code here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

