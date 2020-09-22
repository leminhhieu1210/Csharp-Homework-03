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
            double x1, y1, x2, y2;
            try
            {
                if (txtX1.Text == "" || txtY1.Text == "" || txtX2.Text == "" || txtY2.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtY2.Focus();
                }
                else
                {
                    x1 = double.Parse(txtX1.Text);
                    y1 = double.Parse(txtY1.Text);
                    x2 = double.Parse(txtX2.Text);
                    y2 = double.Parse(txtY2.Text);

                    if (x1 == x2) txtGoc.Text = "Không tính được!";
                    else txtGoc.Text = ((y2 - y1) / (x2 - x1)).ToString();
                    txtKC.Text = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu. Hãy nhập lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX1.Text = ""; txtY1.Text = ""; txtX2.Text = ""; txtY2.Text = "";
                txtX1.Focus();
            }
        }
    }
}
