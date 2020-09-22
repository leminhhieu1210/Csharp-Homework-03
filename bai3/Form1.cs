using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double a = double.Parse(txtA.Text);
                    double b = double.Parse(txtB.Text);
                    double c = double.Parse(txtC.Text);
                    double x;
                    string endl = Environment.NewLine;

                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c == 0)
                            {
                                txtKQ.Text = "Phương trình có vô số nghiệm!";
                            }
                            else
                            {
                                txtKQ.Text = "Phương trình vô nghiệm!";
                            }
                        }
                        else
                        {
                            x = -c / b;
                            txtKQ.Text = "Phương trình có một nghiệm:" + endl + "x = " + x.ToString();
                        }
                    }
                    else
                    {
                        double delta, x1, x2;
                        delta = b * b - 4 * a * c;
                        if (delta < 0) txtKQ.Text = "Phương trình vô nghiệm!";
                        else if (delta == 0)
                        {
                            x = -b / (2 * a);
                            txtKQ.Text = "Phương trình có nghiệm kép:" + endl + "x = " + x.ToString();
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            txtKQ.Text = "Phương trình có hai nghiệm phân biệt:" + endl + "x1 = " + x1.ToString() + endl + "x2 = " + x2.ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu. Hãy nhập lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtA.Text = ""; txtB.Text = ""; txtC.Text = "";
                txtA.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtC.Text = txtKQ.Text = "";
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
                this.Close();
        }
    }
}
