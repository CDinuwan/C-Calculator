using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float num;
        float ans;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 0;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 0+0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(txtCal.Text != String.Empty)
            {
                num = float.Parse(txtCal.Text);
                txtCal.Text=String.Empty;
                txtCal.Focus();
                count = 3;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int c = txtCal.TextLength;
            int flag = 0;
            string text = txtCal.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtCal.Text = txtCal.Text + ".";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtCal.Text != String.Empty)
            {
                num = float.Parse(txtCal.Text);
                txtCal.Text = String.Empty;
                txtCal.Focus();
                count = 4;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtCal.Text != String.Empty)
            {
                num = float.Parse(txtCal.Text);
                txtCal.Text = String.Empty;
                txtCal.Focus();
                count = 5;
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            if(count==1)
            {
                ans = num * float.Parse(txtCal.Text);
                txtCal.Text = ans.ToString();
            }
            
            else if(count==3)
            {
                ans = num + float.Parse(txtCal.Text);
                txtCal.Text = ans.ToString();
            }
            else if(count==4)
            {
                ans = num - float.Parse(txtCal.Text);
                txtCal.Text = ans.ToString();
            }
            else if(count==5)
            {
                ans = num / float.Parse(txtCal.Text);
                txtCal.Text = ans.ToString();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
                ans = float.Parse(txtCal.Text) / 100;
                txtCal.Text = ans.ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtCal.Text != String.Empty)
            {
                num = float.Parse(txtCal.Text);
                txtCal.Text = String.Empty;
                txtCal.Focus();
                count = 1;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtCal.Text;
                int len;
                len = str.Length;
                txtCal.Text = "";
                txtCal.Text = str.Substring(0, len - 1);
            }catch(Exception er)
            {

            }
            
            
        }
    }
}
