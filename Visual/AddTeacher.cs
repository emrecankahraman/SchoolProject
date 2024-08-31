using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddTeacherClick_Click(object sender, EventArgs e)
        {
            string teacherFirstName = FirstName.Text;
            string teacherLastName = LastName.Text;
            string teacherEmail = Email.Text;
            string teacherPhone = Phone.Text;
            string courseName = CourseName.Text;
            string className = ClassName.Text;
            string connectionString = "Server=EMRECAN;Database=Visual;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Öğretmen kaydı ekle
                    string teacherQuery = "INSERT INTO Teacher (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone); SELECT SCOPE_IDENTITY();";
                    SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn);
                    teacherCmd.Parameters.AddWithValue("@FirstName", teacherFirstName);
                    teacherCmd.Parameters.AddWithValue("@LastName", teacherLastName);
                    teacherCmd.Parameters.AddWithValue("@Email", teacherEmail);
                    teacherCmd.Parameters.AddWithValue("@Phone", teacherPhone);

                    int teacherID = Convert.ToInt32(teacherCmd.ExecuteScalar());

                    // Sınıfı bul veya oluştur
                    int classID;
                    string findClassQuery = "SELECT ClassID FROM Class WHERE ClassName = @ClassName";
                    SqlCommand findClassCmd = new SqlCommand(findClassQuery, conn);
                    findClassCmd.Parameters.AddWithValue("@ClassName", className);
                    object result = findClassCmd.ExecuteScalar();
                    if (result != null)
                    {
                        classID = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Sınıf yoksa, yeni bir sınıf oluştur
                        string insertClassQuery = "INSERT INTO Class (ClassName) VALUES (@ClassName); SELECT SCOPE_IDENTITY();";
                        SqlCommand insertClassCmd = new SqlCommand(insertClassQuery, conn);
                        insertClassCmd.Parameters.AddWithValue("@ClassName", className);
                        classID = Convert.ToInt32(insertClassCmd.ExecuteScalar());
                    }

                    // Ders kaydı ekle
                    string courseQuery = "INSERT INTO Course (CourseName, ClassID, TeacherID) VALUES (@CourseName, @ClassID, @TeacherID)";
                    SqlCommand courseCmd = new SqlCommand(courseQuery, conn);
                    courseCmd.Parameters.AddWithValue("@CourseName", courseName);
                    courseCmd.Parameters.AddWithValue("@ClassID", classID);
                    courseCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    int rowsAffected = courseCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen ve ders eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }


        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
