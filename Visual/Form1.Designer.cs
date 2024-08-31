using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Visual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            UserName = new Guna2TextBox();
            Password = new Guna2TextBox();
            bhj = new Guna2HtmlLabel();
            isim = new Label();
            şifre = new Label();
            button1 = new Guna2Button();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.BackgroundImageLayout = ImageLayout.None;
            UserName.BorderColor = Color.White;
            UserName.BorderRadius = 15;
            UserName.CustomizableEdges = customizableEdges1;
            UserName.DefaultText = "";
            UserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UserName.Font = new Font("Segoe UI", 9F);
            UserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UserName.Location = new Point(247, 182);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.PasswordChar = '\0';
            UserName.PlaceholderText = "";
            UserName.SelectedText = "";
            UserName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UserName.ShadowDecoration.Shadow = new Padding(50, 10, 10, 50);
            UserName.Size = new Size(182, 36);
            UserName.TabIndex = 4;
            UserName.TextChanged += guna2TextBox1_TextChanged;
            // 
            // Password
            // 
            Password.BorderColor = Color.White;
            Password.BorderRadius = 15;
            Password.CustomizableEdges = customizableEdges3;
            Password.DefaultText = "";
            Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Font = new Font("Segoe UI", 9F);
            Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Location = new Point(247, 269);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.PasswordChar = '\0';
            Password.PlaceholderText = "";
            Password.SelectedText = "";
            Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Password.Size = new Size(182, 36);
            Password.TabIndex = 9;
            // 
            // bhj
            // 
            bhj.BackColor = Color.Transparent;
            bhj.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bhj.Location = new Point(170, 269);
            bhj.Margin = new Padding(2);
            bhj.Name = "bhj";
            bhj.Size = new Size(3, 2);
            bhj.TabIndex = 10;
            bhj.Text = null;
            // 
            // isim
            // 
            isim.AutoSize = true;
            isim.BackColor = SystemColors.Window;
            isim.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            isim.Location = new Point(252, 170);
            isim.Margin = new Padding(2, 0, 2, 0);
            isim.Name = "isim";
            isim.Size = new Size(73, 17);
            isim.TabIndex = 11;
            isim.Text = "Username";
            isim.Click += label3_Click;
            // 
            // şifre
            // 
            şifre.AutoSize = true;
            şifre.BackColor = SystemColors.Window;
            şifre.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            şifre.Location = new Point(252, 254);
            şifre.Margin = new Padding(2, 0, 2, 0);
            şifre.Name = "şifre";
            şifre.Size = new Size(74, 17);
            şifre.TabIndex = 12;
            şifre.Text = "Password*";
            // 
            // button1
            // 
            button1.BorderRadius = 30;
            button1.CustomizableEdges = customizableEdges5;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(270, 366);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button1.Size = new Size(144, 40);
            button1.TabIndex = 13;
            button1.Text = "LOG IN";
            button1.Click += button1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 0, 64);
            guna2HtmlLabel1.Location = new Point(222, 116);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(219, 24);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "Management Login System";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(120, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 25);
            label1.TabIndex = 1;
            label1.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(509, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(676, 499);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(button1);
            Controls.Add(şifre);
            Controls.Add(isim);
            Controls.Add(bhj);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Guna.UI2.WinForms.Guna2TextBox UserName;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel bhj;
        private Label isim;
        private Label şifre;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
