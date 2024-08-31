namespace visualStudent
{
    partial class Buy
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            buttonBuy = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewProducts = new DataGridView();
            Restriction = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonBuy
            // 
            buttonBuy.BorderRadius = 20;
            buttonBuy.CustomizableEdges = customizableEdges1;
            buttonBuy.DisabledState.BorderColor = Color.DarkGray;
            buttonBuy.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonBuy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonBuy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonBuy.FillColor = Color.FromArgb(0, 0, 64);
            buttonBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBuy.ForeColor = Color.White;
            buttonBuy.Location = new Point(280, 600);
            buttonBuy.Margin = new Padding(2, 3, 2, 3);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonBuy.Size = new Size(137, 44);
            buttonBuy.TabIndex = 50;
            buttonBuy.Text = "buy";
            buttonBuy.Click += buttonBuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(280, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 48;
            label1.Text = "Buy a product";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(118, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(370, 25);
            label3.TabIndex = 47;
            label3.Text = "CONSTANCE BILLARD HIGH SCHOOL";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 32);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = SystemColors.Control;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Restriction });
            dataGridViewProducts.Location = new Point(191, 187);
            dataGridViewProducts.Margin = new Padding(2, 3, 2, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(319, 388);
            dataGridViewProducts.TabIndex = 51;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.CellFormatting += dataGridViewProducts_CellFormatting;
            // 
            // Restriction
            // 
            Restriction.HeaderText = "Column1";
            Restriction.MinimumWidth = 6;
            Restriction.Name = "Restriction";
            Restriction.Width = 125;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(614, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 248);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 680);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridViewProducts);
            Controls.Add(buttonBuy);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Buy";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button buttonBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn Restriction;
        private PictureBox pictureBox2;
    }
}