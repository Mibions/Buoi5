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
    public partial class Form_Bai4 : Form
    {
        public Form_Bai4()
        {
            InitializeComponent();
        }

        private int GCD(int a, int b) // hàm tính ước chung lớn nhất
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b) // hàm tính bội chung nhỏ nhất
        {
            return (a * b) / GCD(a, b);
        }

        private void Input_a_tb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Input_b_tb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Cal_btn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Input_a_tb.Text.ToString());
            int b = Convert.ToInt32(Input_b_tb.Text.ToString());
            Result_UCLN_tb.Text =  "" + GCD(a, b);
            Result_BCNN_tb.Text = "" + LCM(a, b);
        }

        private void Cont_btn_Click(object sender, EventArgs e)
        {
            Input_a_tb.Clear();
            Input_b_tb.Clear();
            Result_UCLN_tb.Clear();
            Result_BCNN_tb.Clear();
            Input_a_tb.Focus();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form_Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
