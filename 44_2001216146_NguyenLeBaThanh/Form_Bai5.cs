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
    public partial class Form_Bai5 : Form
    {
        public Form_Bai5()
        {
            InitializeComponent();
        }

        int sum = 0, sum_even = 0, sum_odd = 0;

        private void Conti_btn_Click(object sender, EventArgs e)
        {
            sum = 0;
            sum_even = 0;
            sum_odd = 0;
            List_num_tb.Clear();
            Sum_even_num_tb.Clear();
            Sum_list_tb.Clear();
            Sum_odd_num_tb.Clear();
            Input_num_tb.Clear();
            Input_num_tb.Focus();
        }

        private void Input_num_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)) || e.KeyChar == null)
            {
                e.Handled = true; // ngăn chặn xử lý ký tự không hợp lệ
                MessageBox.Show("Gia tri vua nhap khong hop le !", "Thong bao Loi", MessageBoxButtons.OK);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add_list_Number();
        }

        public void Add_list_Number()
        {
            if (!(Input_num_tb.Text == ""))
            {
                int a = Convert.ToInt32(Input_num_tb.Text.ToString());
                if (!int.TryParse(Input_num_tb.Text, out a))
                    MessageBox.Show("So vua nhap khong phai so tu nhien !", "Thong bao");
                else
                {
                    List_num_tb.Text += Input_num_tb.Text + ' ';
                    sum += a;
                    if (a % 2 != 0)
                        sum_odd += a;
                    else
                        sum_even += a;
                }
                Sum_even_num_tb.Text = sum_even.ToString();
                Sum_list_tb.Text = sum.ToString();
                Sum_odd_num_tb.Text = sum_odd.ToString();
                Input_num_tb.Clear();
                Input_num_tb.Focus();
            }
            else
            {
                MessageBox.Show("Vui Long Nhap Gia Tri !", "Thong bao Loi", MessageBoxButtons.OK);
            }

        }
    }
}
