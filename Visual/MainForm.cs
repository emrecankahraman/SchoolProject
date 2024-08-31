using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visual;


namespace Visual
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SentEmail.Click += new EventHandler(SentEmail_Click); // Buton olayını bağlama

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            string studentFirstName = FirstName.Text;
            string studentLastName = LastName.Text;
            DateTime studentBirthdate = dateTimePicker1.Value;
            string className = Class.Text;

            string parentFirstName = ParentFirstName.Text;
            string parentLastName = ParentLastName.Text;
            string parentEmail = Email.Text;
            string parentPhone = Phone.Text;

            string connectionString = "Server=EMRECAN;Database=Visual;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Parent kaydı ekle
                    string parentQuery = "INSERT INTO Parent (FirstName, LastName, Email, Phone) VALUES (@ParentFirstName, @ParentLastName, @ParentEmail, @ParentPhone); SELECT SCOPE_IDENTITY();";
                    SqlCommand parentCmd = new SqlCommand(parentQuery, conn);
                    parentCmd.Parameters.AddWithValue("@ParentFirstName", parentFirstName);
                    parentCmd.Parameters.AddWithValue("@ParentLastName", parentLastName);
                    parentCmd.Parameters.AddWithValue("@ParentEmail", parentEmail);
                    parentCmd.Parameters.AddWithValue("@ParentPhone", parentPhone);

                    int parentID = Convert.ToInt32(parentCmd.ExecuteScalar());

                    // Student kaydı ekle
                    string studentQuery = "INSERT INTO Student (FirstName, LastName, DateOfBirth, ParentID) VALUES (@StudentFirstName, @StudentLastName, @DateOfBirth, @ParentID); SELECT SCOPE_IDENTITY();";
                    SqlCommand studentCmd = new SqlCommand(studentQuery, conn);
                    studentCmd.Parameters.AddWithValue("@StudentFirstName", studentFirstName);
                    studentCmd.Parameters.AddWithValue("@StudentLastName", studentLastName);
                    studentCmd.Parameters.AddWithValue("@DateOfBirth", studentBirthdate);
                    studentCmd.Parameters.AddWithValue("@ParentID", parentID);

                    int studentID = Convert.ToInt32(studentCmd.ExecuteScalar());

                    // Class kaydı ekle
                    string classQuery = "INSERT INTO Class (ClassName, StudentID) VALUES (@ClassName, @StudentID)";
                    SqlCommand classCmd = new SqlCommand(classQuery, conn);
                    classCmd.Parameters.AddWithValue("@ClassName", className);
                    classCmd.Parameters.AddWithValue("@StudentID", studentID);

                    int rowsAffected = classCmd.ExecuteNonQuery();
                    // Card kaydı ekle
                    string cardQuery = "INSERT INTO Card (StudentID, Balance) VALUES (@StudentID, @Balance)";
                    SqlCommand cardCmd = new SqlCommand(cardQuery, conn);
                    cardCmd.Parameters.AddWithValue("@StudentID", studentID);
                    cardCmd.Parameters.AddWithValue("@Balance", 0); // Başlangıç bakiyesi 0

                    int cardRowsAffected = cardCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt eklendi.");

                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacherForm = new AddTeacher();
            addTeacherForm.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }



        private void SentEmail_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=EMRECAN;Database=Visual;Trusted_Connection=True;";
            string query = @"
        SELECT P.Email
        FROM Attendance A
        INNER JOIN Student S ON A.StudentID = S.StudentID
        INNER JOIN Parent P ON S.ParentID = P.ParentID
        WHERE A.Status = 'Yok' AND CONVERT(date, A.EntryDate) = CONVERT(date, GETDATE())";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int emailCount = 0; // Gönderilen e-posta sayısını takip etmek için

                    while (reader.Read())
                    {
                        string parentEmail = reader["Email"].ToString();
                        string subject = "Çocuğunuzun Bugünkü Yoklama Durumu";
                        string body = "Sayın Veli, çocuğunuz bugünkü derslere katılmamıştır. Bilginize.";

                        try
                        {
                            // Validate email format before sending
                            var addr = new System.Net.Mail.MailAddress(parentEmail);
                            SendEmail(parentEmail, subject, body);
                            emailCount++;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Geçersiz e-posta adresi: " + parentEmail);
                        }
                    }

                    if (emailCount == 0)
                    {
                        MessageBox.Show("Bugün yoklama durumu 'Yok' olan öğrenci bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("remedyteamhelp@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("remedyteamhelp@gmail.com", "uago zbxq zawq aaor");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderme hatası: " + ex.Message);
            }
        }


    }

}

