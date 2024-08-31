using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Visual;

namespace visual
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Server=EMRECAN;Database=Visual;Trusted_Connection=True;";

        public Dashboard()
        {
            InitializeComponent();

        }

        private void MonthPickerProducts_ValueChanged(object sender, EventArgs e)
        {
            LoadTopSellingProductsData();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadStudentsForProducts();
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.CustomFormat = "MMMM yyyy";
            monthPickerProducts.Format = DateTimePickerFormat.Custom;
            monthPickerProducts.CustomFormat = "MMMM yyyy";
        }

        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Student", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable students = new DataTable();
                students.Load(reader);

                studentComboBox.DisplayMember = "FullName";
                studentComboBox.ValueMember = "StudentID";
                studentComboBox.DataSource = students;
            }
        }

        private void LoadStudentsForProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Student", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable students = new DataTable();
                students.Load(reader);

                studentComboBoxProducts.DisplayMember = "FullName";
                studentComboBoxProducts.ValueMember = "StudentID";
                studentComboBoxProducts.DataSource = students;
            }
        }

        private void LoadChartButton_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void LoadAttendanceData()
        {
            if (studentComboBox.SelectedValue == null)
                return;

            int studentId = (int)studentComboBox.SelectedValue;
            DateTime selectedMonth = monthPicker.Value;
            DateTime startDate = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT EntryDate, COUNT(*) AS Absences " +
                    "FROM Attendance " +
                    "WHERE StudentID = @StudentID AND EntryDate BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY EntryDate", connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = command.ExecuteReader();
                DataTable attendanceData = new DataTable();
                attendanceData.Load(reader);

                // Updated array size to 5 to account for potential 5th week
                int[] weeklyAbsences = new int[5];
                foreach (DataRow row in attendanceData.Rows)
                {
                    DateTime entryDate = (DateTime)row["EntryDate"];
                    int week = (entryDate.Day - 1) / 7;
                    if (week >= 5) week = 4; // Ensure the week index is within bounds
                    weeklyAbsences[week]++;
                }

                attendanceChart.Series.Clear();
                Series series = new Series
                {
                    Name = "Absences",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = Color.MidnightBlue,
                    BorderWidth = 2
                };
                attendanceChart.Series.Add(series);

                for (int i = 0; i < 5; i++) // Updated loop to go up to 5 weeks
                {
                    series.Points.Add(new DataPoint(i + 1, weeklyAbsences[i])
                    {
                        AxisLabel = $"Week {i + 1}"
                    });
                }

                series["PointWidth"] = "0.5";
                attendanceChart.ChartAreas[0].AxisX.Interval = 1;
                attendanceChart.ChartAreas[0].AxisX.Minimum = 1;
                attendanceChart.ChartAreas[0].AxisX.Maximum = 5; // Updated maximum to 5 weeks

                attendanceChart.Invalidate();
            }
        }


        private void LoadChartButtonProducts_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void LoadProductData()
        {
            if (studentComboBoxProducts.SelectedValue == null)
                return;

            int studentId = (int)studentComboBoxProducts.SelectedValue;
            DateTime selectedMonth = monthPickerProducts.Value;
            DateTime startDate = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT P.ProductName, COUNT(T.ProductID) AS ProductCount, T.TransectionDate " +
                    "FROM Transection T " +
                    "JOIN Product P ON T.ProductID = P.ProductID " +
                    "WHERE T.StudentID = @StudentID AND T.TransectionDate BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY P.ProductName, T.TransectionDate",
                    connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = command.ExecuteReader();
                DataTable productData = new DataTable();
                productData.Load(reader);

                Dictionary<string, int[]> weeklyProductCounts = new Dictionary<string, int[]>();
                foreach (DataRow row in productData.Rows)
                {
                    string productName = (string)row["ProductName"];
                    int productCount = (int)row["ProductCount"];
                    DateTime transectionDate = (DateTime)row["TransectionDate"];
                    int week = (transectionDate.Day - 1) / 7;

                    if (!weeklyProductCounts.ContainsKey(productName))
                    {
                        weeklyProductCounts[productName] = new int[4];
                    }
                    weeklyProductCounts[productName][week] += productCount;
                }

                productChart.Series.Clear();
                foreach (var product in weeklyProductCounts)
                {
                    Series series = new Series
                    {
                        Name = product.Key,
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Column,
                        Color = Color.MidnightBlue,

                        BorderWidth = 2
                    };
                    productChart.Series.Add(series);

                    for (int i = 0; i < 4; i++)
                    {
                        series.Points.Add(new DataPoint(i + 1, product.Value[i])
                        {
                            AxisLabel = $"Week {i + 1}"
                        });
                    }

                    series["PointWidth"] = "0.5";
                }

                productChart.ChartAreas[0].AxisX.Interval = 1;
                productChart.ChartAreas[0].AxisX.Minimum = 1;
                productChart.ChartAreas[0].AxisX.Maximum = 4;

                productChart.Invalidate();
            }
        }

        private void LoadTopSellingProductsButton_Click(object sender, EventArgs e)
        {
            LoadTopSellingProductsData();
        }

        private void LoadTopSellingProductsData()
        {
            DateTime selectedMonth = monthPickerTopSelling.Value;
            DateTime startDate = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT P.ProductName, SUM(T.Quantity) AS TotalQuantity " +
                    "FROM Transection T " +
                    "JOIN Product P ON T.ProductID = P.ProductID " +
                    "WHERE T.TransectionDate BETWEEN @StartDate AND @EndDate " +
                    "GROUP BY P.ProductName",
                    connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = command.ExecuteReader();
                DataTable topSellingData = new DataTable();
                topSellingData.Load(reader);

                topSellingProductsChart.Series.Clear();
                topSellingProductsChart.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                topSellingProductsChart.ChartAreas.Add(chartArea);

                Series series = new Series
                {
                    Name = "Top Selling Products",
                    IsVisibleInLegend = false,
                    Color = Color.MidnightBlue,

                    ChartType = SeriesChartType.Column,
                    BorderWidth = 2
                };
                topSellingProductsChart.Series.Add(series);

                int index = 0;
                foreach (DataRow row in topSellingData.Rows)
                {
                    string productName = (string)row["ProductName"];
                    int totalQuantity = (int)row["TotalQuantity"];

                    series.Points.Add(new DataPoint(index + 1, totalQuantity)
                    {
                        AxisLabel = productName
                    });

                    index++;
                }

                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.Minimum = 1;
                chartArea.AxisX.Maximum = index;
                chartArea.AxisX.Title = "Ürün Adları";
                chartArea.AxisY.Title = "Ürün Adedi";

                topSellingProductsChart.Invalidate();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            dashboard2.Show();
        }

        private void monthPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthPickerTopSelling_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
