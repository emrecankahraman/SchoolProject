using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

namespace VisualPhoneApp
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            LoadMoney = new Guna.UI2.WinForms.Guna2Button();
            RestrictProduct = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(117, 42);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 8;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            label3.Click += label3_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(365, 354);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 37;
            guna2HtmlLabel1.Text = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // LoadMoney
            // 
            LoadMoney.BorderRadius = 30;
            LoadMoney.CustomizableEdges = customizableEdges1;
            LoadMoney.DisabledState.BorderColor = Color.DarkGray;
            LoadMoney.DisabledState.CustomBorderColor = Color.DarkGray;
            LoadMoney.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoadMoney.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoadMoney.FillColor = Color.FromArgb(0, 0, 64);
            LoadMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LoadMoney.ForeColor = Color.White;
            LoadMoney.Location = new Point(144, 207);
            LoadMoney.Margin = new Padding(2);
            LoadMoney.Name = "LoadMoney";
            LoadMoney.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoadMoney.Size = new Size(151, 90);
            LoadMoney.TabIndex = 60;
            LoadMoney.Text = "Load Money";
            LoadMoney.Click += button1_Click;
            // 
            // RestrictProduct
            // 
            RestrictProduct.BorderRadius = 30;
            RestrictProduct.CustomizableEdges = customizableEdges3;
            RestrictProduct.DisabledState.BorderColor = Color.DarkGray;
            RestrictProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            RestrictProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RestrictProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RestrictProduct.FillColor = Color.FromArgb(0, 0, 64);
            RestrictProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            RestrictProduct.ForeColor = Color.White;
            RestrictProduct.Location = new Point(394, 207);
            RestrictProduct.Margin = new Padding(2);
            RestrictProduct.Name = "RestrictProduct";
            RestrictProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            RestrictProduct.Size = new Size(153, 90);
            RestrictProduct.TabIndex = 61;
            RestrictProduct.Text = "Restrict Product";
            RestrictProduct.Click += button2_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 538);
            Controls.Add(RestrictProduct);
            Controls.Add(LoadMoney);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label3);
            Margin = new Padding(2);
            Name = "Choose";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button LoadMoney;
        private Guna.UI2.WinForms.Guna2Button RestrictProduct;
    }
}