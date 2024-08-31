using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace visual
{
    partial class Dashboard
    {
        private IContainer components = null;
        private ComboBox studentComboBox;
        private Chart attendanceChart;
        private DateTimePicker monthPicker;
        private ComboBox studentComboBoxProducts;
        private DateTimePicker monthPickerProducts;
        private Button LoadChartButtonProducts01;
        private Chart productChart;
        private Chart topSellingProductsChart;
        private DateTimePicker monthPickerTopSelling;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            ChartArea chartArea2 = new ChartArea();
            ChartArea chartArea3 = new ChartArea();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            studentComboBox = new ComboBox();
            attendanceChart = new Chart();
            monthPicker = new DateTimePicker();
            studentComboBoxProducts = new ComboBox();
            monthPickerProducts = new DateTimePicker();
            productChart = new Chart();
            topSellingProductsChart = new Chart();
            monthPickerTopSelling = new DateTimePicker();
            label1 = new Label();
            loadChartButton = new Guna.UI2.WinForms.Guna2Button();
            LoadChartButtonProducts = new Guna.UI2.WinForms.Guna2Button();
            LoadTopSellingProductsButton = new Guna.UI2.WinForms.Guna2Button();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label3 = new Label();
            ((ISupportInitialize)attendanceChart).BeginInit();
            ((ISupportInitialize)productChart).BeginInit();
            ((ISupportInitialize)topSellingProductsChart).BeginInit();
            SuspendLayout();
            // 
            // studentComboBox
            // 
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(25, 55);
            studentComboBox.Margin = new Padding(4, 5, 4, 5);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(221, 28);
            studentComboBox.TabIndex = 0;
            // 
            // attendanceChart
            // 
            attendanceChart.BackColor = SystemColors.Control;
            attendanceChart.BorderlineColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            attendanceChart.ChartAreas.Add(chartArea1);
            attendanceChart.Location = new Point(-3, 97);
            attendanceChart.Margin = new Padding(4, 5, 4, 5);
            attendanceChart.Name = "attendanceChart";
            attendanceChart.Size = new Size(812, 221);
            attendanceChart.TabIndex = 2;
            attendanceChart.Text = "attendanceChart";
            // 
            // monthPicker
            // 
            monthPicker.CustomFormat = "MMMM yyyy";
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.Location = new Point(264, 56);
            monthPicker.Margin = new Padding(4, 5, 4, 5);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(200, 27);
            monthPicker.TabIndex = 3;
            monthPicker.ValueChanged += monthPicker_ValueChanged;
            // 
            // studentComboBoxProducts
            // 
            studentComboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            studentComboBoxProducts.FormattingEnabled = true;
            studentComboBoxProducts.Location = new Point(25, 362);
            studentComboBoxProducts.Name = "studentComboBoxProducts";
            studentComboBoxProducts.Size = new Size(221, 28);
            studentComboBoxProducts.TabIndex = 4;
            // 
            // monthPickerProducts
            // 
            monthPickerProducts.CalendarMonthBackground = SystemColors.InactiveCaption;
            monthPickerProducts.CustomFormat = "MMMM yyyy";
            monthPickerProducts.Format = DateTimePickerFormat.Custom;
            monthPickerProducts.Location = new Point(264, 365);
            monthPickerProducts.Name = "monthPickerProducts";
            monthPickerProducts.Size = new Size(200, 27);
            monthPickerProducts.TabIndex = 5;
            // 
            // productChart
            // 
            productChart.BackColor = SystemColors.Control;
            chartArea2.Name = "ChartArea2";
            productChart.ChartAreas.Add(chartArea2);
            productChart.Location = new Point(-3, 398);
            productChart.Name = "productChart";
            productChart.Size = new Size(812, 232);
            productChart.TabIndex = 7;
            productChart.Text = "productChart";
            // 
            // topSellingProductsChart
            // 
            topSellingProductsChart.BackColor = SystemColors.Control;
            chartArea3.Name = "ChartArea3";
            topSellingProductsChart.ChartAreas.Add(chartArea3);
            topSellingProductsChart.Location = new Point(-3, 701);
            topSellingProductsChart.Name = "topSellingProductsChart";
            topSellingProductsChart.Size = new Size(812, 300);
            topSellingProductsChart.TabIndex = 9;
            topSellingProductsChart.Text = "topSellingProductsChart";
            // 
            // monthPickerTopSelling
            // 
            monthPickerTopSelling.CustomFormat = "MMMM yyyy";
            monthPickerTopSelling.Format = DateTimePickerFormat.Custom;
            monthPickerTopSelling.Location = new Point(25, 669);
            monthPickerTopSelling.Name = "monthPickerTopSelling";
            monthPickerTopSelling.Size = new Size(221, 27);
            monthPickerTopSelling.TabIndex = 10;
            monthPickerTopSelling.ValueChanged += monthPickerTopSelling_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(474, 23);
            label1.TabIndex = 12;
            label1.Text = "Student's attendance tracking report between selected dates";
            // 
            // loadChartButton
            // 
            loadChartButton.BorderRadius = 20;
            loadChartButton.CustomizableEdges = customizableEdges1;
            loadChartButton.DisabledState.BorderColor = Color.DarkGray;
            loadChartButton.DisabledState.CustomBorderColor = Color.DarkGray;
            loadChartButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loadChartButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loadChartButton.FillColor = Color.FromArgb(0, 0, 64);
            loadChartButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loadChartButton.ForeColor = Color.White;
            loadChartButton.Location = new Point(504, 43);
            loadChartButton.Margin = new Padding(2);
            loadChartButton.Name = "loadChartButton";
            loadChartButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loadChartButton.Size = new Size(176, 40);
            loadChartButton.TabIndex = 15;
            loadChartButton.Text = "loadChartButton";
            loadChartButton.Click += LoadChartButton_Click;
            // 
            // LoadChartButtonProducts
            // 
            LoadChartButtonProducts.BorderRadius = 20;
            LoadChartButtonProducts.CustomizableEdges = customizableEdges3;
            LoadChartButtonProducts.DisabledState.BorderColor = Color.DarkGray;
            LoadChartButtonProducts.DisabledState.CustomBorderColor = Color.DarkGray;
            LoadChartButtonProducts.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoadChartButtonProducts.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoadChartButtonProducts.FillColor = Color.FromArgb(0, 0, 64);
            LoadChartButtonProducts.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LoadChartButtonProducts.ForeColor = Color.White;
            LoadChartButtonProducts.Location = new Point(504, 349);
            LoadChartButtonProducts.Margin = new Padding(2);
            LoadChartButtonProducts.Name = "LoadChartButtonProducts";
            LoadChartButtonProducts.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LoadChartButtonProducts.Size = new Size(176, 40);
            LoadChartButtonProducts.TabIndex = 16;
            LoadChartButtonProducts.Text = "Load";
            LoadChartButtonProducts.Click += LoadChartButtonProducts_Click;
            // 
            // LoadTopSellingProductsButton
            // 
            LoadTopSellingProductsButton.BorderRadius = 20;
            LoadTopSellingProductsButton.CustomizableEdges = customizableEdges5;
            LoadTopSellingProductsButton.DisabledState.BorderColor = Color.DarkGray;
            LoadTopSellingProductsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoadTopSellingProductsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoadTopSellingProductsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoadTopSellingProductsButton.FillColor = Color.FromArgb(0, 0, 64);
            LoadTopSellingProductsButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LoadTopSellingProductsButton.ForeColor = Color.White;
            LoadTopSellingProductsButton.Location = new Point(264, 656);
            LoadTopSellingProductsButton.Margin = new Padding(2);
            LoadTopSellingProductsButton.Name = "LoadTopSellingProductsButton";
            LoadTopSellingProductsButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LoadTopSellingProductsButton.Size = new Size(176, 40);
            LoadTopSellingProductsButton.TabIndex = 17;
            LoadTopSellingProductsButton.Text = "Load Top Selling Products";
            LoadTopSellingProductsButton.Click += LoadTopSellingProductsButton_Click;
            // 
            // button1
            // 
            button1.BorderRadius = 20;
            button1.CustomizableEdges = customizableEdges7;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(913, 473);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            button1.Size = new Size(167, 78);
            button1.TabIndex = 18;
            button1.Text = "Dasboard";
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 323);
            label2.Name = "label2";
            label2.Size = new Size(291, 23);
            label2.TabIndex = 19;
            label2.Text = "Student's monthly canteen shopping";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(25, 633);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 20;
            label3.Text = "Products sold";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 1055);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(LoadTopSellingProductsButton);
            Controls.Add(LoadChartButtonProducts);
            Controls.Add(loadChartButton);
            Controls.Add(label1);
            Controls.Add(monthPickerTopSelling);
            Controls.Add(monthPicker);
            Controls.Add(attendanceChart);
            Controls.Add(studentComboBox);
            Controls.Add(studentComboBoxProducts);
            Controls.Add(monthPickerProducts);
            Controls.Add(productChart);
            Controls.Add(topSellingProductsChart);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((ISupportInitialize)attendanceChart).EndInit();
            ((ISupportInitialize)productChart).EndInit();
            ((ISupportInitialize)topSellingProductsChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button loadChartButton;
        private Guna.UI2.WinForms.Guna2Button LoadChartButtonProducts;
        private Guna.UI2.WinForms.Guna2Button LoadTopSellingProductsButton;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Label label2;
        private Label label3;
    }
}
