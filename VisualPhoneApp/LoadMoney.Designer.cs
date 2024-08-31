using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

namespace VisualPhoneApp
{
    partial class LoadMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadMoney));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Balance = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(120, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 6;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Balance
            // 
            Balance.BackgroundImageLayout = ImageLayout.None;
            Balance.BorderColor = Color.White;
            Balance.BorderRadius = 15;
            Balance.CustomizableEdges = customizableEdges1;
            Balance.DefaultText = "";
            Balance.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Balance.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Balance.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Balance.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Balance.FillColor = Color.FromArgb(0, 0, 64);
            Balance.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Balance.Font = new System.Drawing.Font("Segoe UI", 9F);
            Balance.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Balance.Location = new Point(120, 224);
            Balance.Margin = new Padding(3, 4, 3, 4);
            Balance.Name = "Balance";
            Balance.PasswordChar = '\0';
            Balance.PlaceholderText = "";
            Balance.SelectedText = "";
            Balance.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Balance.ShadowDecoration.Shadow = new Padding(50, 10, 10, 50);
            Balance.Size = new Size(415, 61);
            Balance.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(129, 188);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 33;
            label1.Text = "Enter the amount to be loaded";
            // 
            // button1
            // 
            button1.BorderRadius = 30;
            button1.CustomizableEdges = customizableEdges3;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(0, 0, 64);
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(243, 348);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button1.Size = new Size(142, 47);
            button1.TabIndex = 40;
            button1.Text = "send";
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(590, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // LoadMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 519);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Balance);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "LoadMoney";
            Text = "Form3";
            Load += LoadMoney_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Balance;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private PictureBox pictureBox2;
    }
}