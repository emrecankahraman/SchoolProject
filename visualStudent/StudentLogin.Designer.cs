using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace visualStudent
{
    partial class StudentLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            Login = new Guna.UI2.WinForms.Guna2Button();
            şifre = new Label();
            label11 = new Label();
            Password = new Guna.UI2.WinForms.Guna2TextBox();
            studentid = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BorderRadius = 30;
            Login.CustomizableEdges = customizableEdges1;
            Login.DisabledState.BorderColor = Color.DarkGray;
            Login.DisabledState.CustomBorderColor = Color.DarkGray;
            Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Login.FillColor = Color.FromArgb(0, 0, 64);
            Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Login.ForeColor = Color.White;
            Login.Location = new Point(277, 420);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Login.Size = new Size(144, 40);
            Login.TabIndex = 49;
            Login.Text = "LOG IN";
            Login.Click += Login_Click;
            // 
            // şifre
            // 
            şifre.AutoSize = true;
            şifre.BackColor = SystemColors.Window;
            şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            şifre.Location = new Point(227, 300);
            şifre.Margin = new Padding(2, 0, 2, 0);
            şifre.Name = "şifre";
            şifre.Size = new Size(74, 17);
            şifre.TabIndex = 48;
            şifre.Text = "Password*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(227, 199);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 17);
            label11.TabIndex = 47;
            label11.Text = "Student ID card*";
            // 
            // Password
            // 
            Password.BackgroundImageLayout = ImageLayout.None;
            Password.BorderColor = Color.White;
            Password.BorderRadius = 15;
            Password.CustomizableEdges = customizableEdges3;
            Password.DefaultText = "";
            Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Location = new Point(227, 310);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.PasswordChar = '\0';
            Password.PlaceholderText = "";
            Password.SelectedText = "";
            Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Password.ShadowDecoration.Shadow = new Padding(50, 10, 10, 50);
            Password.Size = new Size(237, 36);
            Password.TabIndex = 46;
            // 
            // studentid
            // 
            studentid.BackgroundImageLayout = ImageLayout.None;
            studentid.BorderColor = Color.White;
            studentid.BorderRadius = 15;
            studentid.CustomizableEdges = customizableEdges5;
            studentid.DefaultText = "";
            studentid.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            studentid.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            studentid.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            studentid.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            studentid.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            studentid.Font = new System.Drawing.Font("Segoe UI", 9F);
            studentid.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            studentid.Location = new Point(227, 210);
            studentid.Margin = new Padding(3, 4, 3, 4);
            studentid.Name = "studentid";
            studentid.PasswordChar = '\0';
            studentid.PlaceholderText = "";
            studentid.SelectedText = "";
            studentid.ShadowDecoration.CustomizableEdges = customizableEdges6;
            studentid.ShadowDecoration.Shadow = new Padding(50, 10, 10, 50);
            studentid.Size = new Size(237, 36);
            studentid.TabIndex = 45;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 0, 64);
            guna2HtmlLabel1.Location = new Point(227, 131);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(178, 24);
            guna2HtmlLabel1.TabIndex = 44;
            guna2HtmlLabel1.Text = "Student Login System";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(504, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(117, 49);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 42;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 17);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // StudentLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 562);
            Controls.Add(Login);
            Controls.Add(şifre);
            Controls.Add(label11);
            Controls.Add(Password);
            Controls.Add(studentid);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "StudentLogin";
            Text = "student_login";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Login;
        private Label şifre;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox studentid;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}