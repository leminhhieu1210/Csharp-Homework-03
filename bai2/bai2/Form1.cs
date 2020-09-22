using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double cv = double.Parse(txtBK.Text) * 3.14159 * 2;
            txtCV.Text = cv.ToString();

            double dt = double.Parse(txtBK.Text) * double.Parse(txtBK.Text) * 3.14159;
            txtDT.Text = dt.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBK.Text = txtCV.Text = txtDT.Text = "";
            txtBK.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
