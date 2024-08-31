using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace visual
{
    public partial class Dashboard2 : Form
    {
        private string connectionString = "Server=EMRECAN;Database=Visual;Trusted_Connection=True;";

        public Dashboard2()
        {
            InitializeComponent();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadRestrictedProductsData();
        }

        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Student", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                studentComboBoxProducts.DisplayMember = "FullName";
                studentComboBoxProducts.ValueMember = "StudentID";
                studentComboBoxProducts.DataSource = dt;
            }
        }

        private void LoadRestrictedProductsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT P.ProductName, COUNT(PR.ProductID) AS RestrictionCount " +
                    "FROM ProductRestriction PR " +
                    "JOIN Product P ON PR.ProductID = P.ProductID " +
                    "GROUP BY P.ProductName " +
                    "ORDER BY RestrictionCount DESC", connection);

                SqlDataReader reader = command.ExecuteReader();
                DataTable restrictedProductsData = new DataTable();
                restrictedProductsData.Load(reader);

                List<string> productNames = new List<string>();
                List<int> restrictionCounts = new List<int>();

                foreach (DataRow row in restrictedProductsData.Rows)
                {
                    string productName = (string)row["ProductName"];
                    int restrictionCount = (int)row["RestrictionCount"];

                    productNames.Add(productName);
                    restrictionCounts.Add(restrictionCount);
                }

                productChart.Series.Clear();
                Series series = new Series
                {
                    Name = "Products",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = Color.MidnightBlue,
                    BorderWidth = 2
                };
                productChart.Series.Add(series);

                for (int i = 0; i < productNames.Count; i++)
                {
                    series.Points.Add(new DataPoint(i + 1, restrictionCounts[i]) { AxisLabel = productNames[i] });
                }

                series["PointWidth"] = "0.5";
                productChart.ChartAreas[0].AxisX.Interval = 1;
                productChart.ChartAreas[0].AxisX.Minimum = 1;
                productChart.ChartAreas[0].AxisX.Maximum = productNames.Count + 1;
                productChart.Invalidate();
            }
        }

        private void btnLoadSalesChart_Click(object sender, EventArgs e)
        {
            if (studentComboBoxProducts.SelectedValue == null) return;

            int selectedStudentID = (int)studentComboBoxProducts.SelectedValue;
            DateTime selectedMonth = monthPickerProducts.Value;
            LoadStudentProductSalesData(selectedStudentID, selectedMonth);
        }

        private void LoadStudentProductSalesData(int studentID, DateTime month)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT P.ProductName, SUM(T.Quantity) AS TotalQuantity " +
                    "FROM Transection T " +
                    "JOIN Product P ON T.ProductID = P.ProductID " +
                    "WHERE T.StudentID = @StudentID " +
                    "AND YEAR(T.TransectionDate) = @Year AND MONTH(T.TransectionDate) = @Month " +
                    "GROUP BY P.ProductName", connection);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Year", month.Year);
                command.Parameters.AddWithValue("@Month", month.Month);

                SqlDataReader reader = command.ExecuteReader();
                DataTable productSalesData = new DataTable();
                productSalesData.Load(reader);

                List<string> productNames = new List<string>();
                List<int> totalQuantities = new List<int>();

                foreach (DataRow row in productSalesData.Rows)
                {
                    string productName = (string)row["ProductName"];
                    int totalQuantity = (int)row["TotalQuantity"];

                    productNames.Add(productName);
                    totalQuantities.Add(totalQuantity);
                }

                salesChart.Series.Clear();
                Series series = new Series
                {
                    Name = "Sales",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = Color.MidnightBlue,
                    BorderWidth = 2
                };
                salesChart.Series.Add(series);

                for (int i = 0; i < productNames.Count; i++)
                {
                    series.Points.Add(new DataPoint(i + 1, totalQuantities[i]) { AxisLabel = productNames[i] });
                }

                series["PointWidth"] = "0.5";
                salesChart.ChartAreas[0].AxisX.Interval = 1;
                salesChart.ChartAreas[0].AxisX.Minimum = 1;
                salesChart.ChartAreas[0].AxisX.Maximum = productNames.Count + 1;
                salesChart.Invalidate();
            }
        }

        private void LoadChartButtonProducts_Click(object sender, EventArgs e)
        {
            if (studentComboBoxProducts.SelectedValue == null) return;

            int selectedStudentID = (int)studentComboBoxProducts.SelectedValue;
            DateTime selectedMonth = monthPickerProducts.Value;
            LoadStudentProductSalesData(selectedStudentID, selectedMonth);
        }

       
    }
}
