using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualPhoneApp
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMoney loadMoney = new LoadMoney();
            loadMoney.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestrictProduct restrictProductForm = new RestrictProduct(Form1.ParentEmail);
            restrictProductForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
