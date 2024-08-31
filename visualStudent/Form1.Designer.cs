using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

namespace visualStudent
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonExit = new Guna.UI2.WinForms.Guna2Button();
            buttonEntry = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dataGridViewStudents = new DataGridView();
            StudentLogin = new Guna.UI2.WinForms.Guna2Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(113, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 38;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(510, -1);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // buttonExit
            // 
            buttonExit.BorderRadius = 30;
            buttonExit.CustomizableEdges = customizableEdges7;
            buttonExit.DisabledState.BorderColor = Color.DarkGray;
            buttonExit.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonExit.FillColor = Color.FromArgb(0, 0, 64);
            buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(404, 161);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            buttonExit.Size = new Size(134, 62);
            buttonExit.TabIndex = 64;
            buttonExit.Text = "       EXIT";
            buttonExit.TextAlign = HorizontalAlignment.Left;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonEntry
            // 
            buttonEntry.BorderRadius = 30;
            buttonEntry.CustomizableEdges = customizableEdges9;
            buttonEntry.DisabledState.BorderColor = Color.DarkGray;
            buttonEntry.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEntry.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEntry.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEntry.FillColor = Color.FromArgb(0, 0, 64);
            buttonEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonEntry.ForeColor = Color.White;
            buttonEntry.Location = new Point(170, 161);
            buttonEntry.Margin = new Padding(2);
            buttonEntry.Name = "buttonEntry";
            buttonEntry.ShadowDecoration.CustomizableEdges = customizableEdges10;
            buttonEntry.Size = new Size(128, 62);
            buttonEntry.TabIndex = 63;
            buttonEntry.Text = "ENTRY";
            buttonEntry.Click += buttonEntry_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(347, 315);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 62;
            guna2HtmlLabel1.Text = null;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.BackgroundColor = SystemColors.Control;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(153, 241);
            dataGridViewStudents.Margin = new Padding(2);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(399, 236);
            dataGridViewStudents.TabIndex = 65;
            // 
            // StudentLogin
            // 
            StudentLogin.BorderRadius = 30;
            StudentLogin.CustomizableEdges = customizableEdges11;
            StudentLogin.DisabledState.BorderColor = Color.DarkGray;
            StudentLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            StudentLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StudentLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StudentLogin.FillColor = Color.FromArgb(0, 0, 64);
            StudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StudentLogin.ForeColor = Color.White;
            StudentLogin.Location = new Point(277, 497);
            StudentLogin.Margin = new Padding(2);
            StudentLogin.Name = "StudentLogin";
            StudentLogin.ShadowDecoration.CustomizableEdges = customizableEdges12;
            StudentLogin.Size = new Size(144, 46);
            StudentLogin.TabIndex = 66;
            StudentLogin.Text = " Student Login";
            StudentLogin.TextAlign = HorizontalAlignment.Left;
            StudentLogin.Click += StudentLogin_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(404, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 27);
            dateTimePicker1.TabIndex = 67;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 564);
            Controls.Add(dateTimePicker1);
            Controls.Add(StudentLogin);
            Controls.Add(dataGridViewStudents);
            Controls.Add(buttonExit);
            Controls.Add(buttonEntry);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "entryexit";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button buttonExit;
        private Guna.UI2.WinForms.Guna2Button buttonEntry;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView dataGridViewStudents;
        private Guna.UI2.WinForms.Guna2Button StudentLogin;
        private DateTimePicker dateTimePicker1;
    }
}
