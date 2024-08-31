using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

namespace VisualPhoneApp
{
    partial class RestrictProduct    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestrictProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colCheckbox = new DataGridViewCheckBoxColumn();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            button3 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(117, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 35;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 17);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(117, 153);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 18);
            label1.TabIndex = 36;
            label1.Text = "Enter the product to be restricted";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCheckbox });
            dataGridView1.Location = new Point(117, 189);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(476, 329);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // colCheckbox
            // 
            colCheckbox.HeaderText = "Column1";
            colCheckbox.MinimumWidth = 8;
            colCheckbox.Name = "colCheckbox";
            colCheckbox.Width = 150;
            // 
            // button1
            // 
            button1.BorderRadius = 20;
            button1.CustomizableEdges = customizableEdges1;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(0, 0, 64);
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(476, 139);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button1.Size = new Size(108, 32);
            button1.TabIndex = 43;
            button1.Text = "refresh";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BorderRadius = 20;
            button2.CustomizableEdges = customizableEdges3;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.FillColor = Color.FromArgb(0, 0, 64);
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(414, 539);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button2.Size = new Size(150, 45);
            button2.TabIndex = 44;
            button2.Text = "add restriction";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BorderRadius = 20;
            button3.CustomizableEdges = customizableEdges5;
            button3.DisabledState.BorderColor = Color.DarkGray;
            button3.DisabledState.CustomBorderColor = Color.DarkGray;
            button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button3.FillColor = Color.FromArgb(0, 0, 64);
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(162, 539);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button3.Size = new Size(146, 45);
            button3.TabIndex = 45;
            button3.Text = "remove restrictions";
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(634, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // RestrictProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 612);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "RestrictProduct";
            Text = "Form5";
            Load += RestrictProduct_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button3;
        private DataGridViewCheckBoxColumn colCheckbox;
        private PictureBox pictureBox2;
    }
}
