using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace visualStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();
                    string studentQuery = "SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Student";
                    SqlCommand cmd = new SqlCommand(studentQuery, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewStudents.DataSource = dt;
                    dataGridViewStudents.Columns["StudentID"].Visible = false; // StudentID kolonunu gizleme
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            ProcessAttendance("Entry");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ProcessAttendance("Exit");
        }

        private void ProcessAttendance(string action)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudents.SelectedRows[0];
                int studentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);
                DateTime selectedDate = dateTimePicker1.Value;

                if (action == "Entry")
                {
                    SaveEntry(studentID, selectedDate);
                }
                else if (action == "Exit")
                {
                    SaveExit(studentID, selectedDate);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öðrenci seçin.");
            }
        }

        private void SaveEntry(int studentID, DateTime entryDate)
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();
                    // Check if there is already an entry without an exit
                    string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentID = @StudentID AND ExitDate IS NULL";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                    int existingEntries = (int)checkCmd.ExecuteScalar();

                    if (existingEntries > 0)
                    {
                        MessageBox.Show("Bu öðrenci için zaten aktif bir giriþ kaydý var.");
                        return; // Exit the method if there's an active entry
                    }

                    string query = "INSERT INTO Attendance (StudentID, EntryDate) VALUES (@StudentID, @EntryDate)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@EntryDate", entryDate);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Giriþ kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void SaveExit(int studentID, DateTime exitDate)
        {
            using (SqlConnection conn = new SqlConnection("Server=EMRECAN;Database=Visual;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    conn.Open();
                    string selectQuery = "SELECT EntryDate FROM Attendance WHERE StudentID = @StudentID AND ExitDate IS NULL";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@StudentID", studentID);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null)
                    {
                        DateTime entryDate = (DateTime)result;
                        TimeSpan duration = exitDate - entryDate;
                        string status = duration.TotalHours < 8 ? "Yok" : "Var";  // Status deðiþimini burada kontrol ediyoruz

                        string updateQuery = "UPDATE Attendance SET ExitDate = @ExitDate, Status = @Status WHERE StudentID = @StudentID AND EntryDate = @EntryDate";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@ExitDate", exitDate);
                        updateCmd.Parameters.AddWithValue("@Status", status);
                        updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                        updateCmd.Parameters.AddWithValue("@EntryDate", entryDate);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Çýkýþ kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Giriþ kaydý bulunamadý.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {

            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
