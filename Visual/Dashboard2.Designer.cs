namespace visual
{
    partial class Dashboard2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            studentComboBoxProducts = new ComboBox();
            monthPickerProducts = new DateTimePicker();
            productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            salesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            LoadChartButtonProducts = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)productChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesChart).BeginInit();
            SuspendLayout();
            // 
            // studentComboBoxProducts
            // 
            studentComboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            studentComboBoxProducts.FormattingEnabled = true;
            studentComboBoxProducts.Location = new Point(70, 487);
            studentComboBoxProducts.Name = "studentComboBoxProducts";
            studentComboBoxProducts.Size = new Size(172, 28);
            studentComboBoxProducts.TabIndex = 0;
            // 
            // monthPickerProducts
            // 
            monthPickerProducts.CustomFormat = "MMMM yyyy";
            monthPickerProducts.Format = DateTimePickerFormat.Custom;
            monthPickerProducts.Location = new Point(263, 488);
            monthPickerProducts.Name = "monthPickerProducts";
            monthPickerProducts.Size = new Size(172, 27);
            monthPickerProducts.TabIndex = 1;
            // 
            // productChart
            // 
            productChart.BackColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            productChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            productChart.Legends.Add(legend1);
            productChart.Location = new Point(12, 55);
            productChart.Name = "productChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Products";
            productChart.Series.Add(series1);
            productChart.Size = new Size(690, 385);
            productChart.TabIndex = 3;
            productChart.Text = "chart1";
            // 
            // salesChart
            // 
            salesChart.BackColor = SystemColors.Control;
            chartArea2.Name = "ChartArea2";
            salesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            salesChart.Legends.Add(legend2);
            salesChart.Location = new Point(12, 521);
            salesChart.Name = "salesChart";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend2";
            series2.Name = "Sales";
            salesChart.Series.Add(series2);
            salesChart.Size = new Size(690, 385);
            salesChart.TabIndex = 5;
            salesChart.Text = "salesChart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(70, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 6;
            label1.Text = "Banned products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(70, 443);
            label2.Name = "label2";
            label2.Size = new Size(431, 23);
            label2.TabIndex = 7;
            label2.Text = "How many times did the student purchase the product";
            // 
            // LoadChartButtonProducts
            // 
            LoadChartButtonProducts.BorderRadius = 20;
            LoadChartButtonProducts.CustomizableEdges = customizableEdges1;
            LoadChartButtonProducts.DisabledState.BorderColor = Color.DarkGray;
            LoadChartButtonProducts.DisabledState.CustomBorderColor = Color.DarkGray;
            LoadChartButtonProducts.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoadChartButtonProducts.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoadChartButtonProducts.FillColor = Color.FromArgb(0, 0, 64);
            LoadChartButtonProducts.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LoadChartButtonProducts.ForeColor = Color.White;
            LoadChartButtonProducts.Location = new Point(462, 487);
            LoadChartButtonProducts.Margin = new Padding(2);
            LoadChartButtonProducts.Name = "LoadChartButtonProducts";
            LoadChartButtonProducts.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoadChartButtonProducts.Size = new Size(166, 35);
            LoadChartButtonProducts.TabIndex = 16;
            LoadChartButtonProducts.Text = "loadChartButton";
            LoadChartButtonProducts.Click += LoadChartButtonProducts_Click;
            // 
            // Dashboard2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 900);
            Controls.Add(LoadChartButtonProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salesChart);
            Controls.Add(productChart);
            Controls.Add(monthPickerProducts);
            Controls.Add(studentComboBoxProducts);
            Name = "Dashboard2";
            Text = "Dashboard2";
            Load += Dashboard2_Load;
            ((System.ComponentModel.ISupportInitialize)productChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox studentComboBoxProducts;
        private System.Windows.Forms.DateTimePicker monthPickerProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesChart;
        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button LoadChartButtonProducts;
    }
}
