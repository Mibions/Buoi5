using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_2001216146_NguyenLeBaThanh
{
    public partial class Form_Bai2 : Form
    {
        public Form_Bai2()
        {
            InitializeComponent();
        }


        private void Addvision_btn_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(Input_A_tb.Text) + Convert.ToInt32(Input_B_tb.Text);
            Result_tb.Text = Result.ToString();
        }

        private void Subtraction_btn_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(Input_A_tb.Text) - Convert.ToInt32(Input_B_tb.Text);
            Result_tb.Text = Result.ToString();
        }

        private void Multiplication_btn_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(Input_A_tb.Text) * Convert.ToInt32(Input_B_tb.Text);
            Result_tb.Text = Result.ToString();
        }

        private void Division_btn_Click(object sender, EventArgs e)
        {
            double Result = Math.Round((Double)Convert.ToInt32(Input_A_tb.Text) / Convert.ToInt32(Input_B_tb.Text),2);
            Result_tb.Text = Result.ToString();
        }

        private void Input_A_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
            {
                e.Handled = true; // ngăn chặn xử lý ký tự không hợp lệ
                this.errorProvider1.SetError(ctr, "Du lieu khong hop le !");

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void Input_B_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
            {
                e.Handled = true; // ngăn chặn xử lý ký tự không hợp lệ
                this.errorProvider1.SetError(ctr, "Du lieu khong hop le !");

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void Form_Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
