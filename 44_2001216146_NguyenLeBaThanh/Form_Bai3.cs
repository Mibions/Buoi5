using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _44_2001216146_NguyenLeBaThanh
{
    public partial class Form_Bai3 : Form
    {
        public Form_Bai3()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = Username_tb.Text.ToString();
            string password = Password_tb.Text.ToString();
            string email = Email_tb.Text.ToString();
            string retype_password = Retype_Password_tb.Text.ToString();
            string message = "Username : " + username + "\nEmail : " + email + "\nPassword : " + password + "\nRetype password" + retype_password;
            MessageBox.Show(message, "Thông Tin Chi Tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Is_Email_Valid(string input)
        {
            // Biểu thức chính quy để kiểm tra định dạng email hợp lệ
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(input, pattern);
        }

        private void Email_tb_Leave(object sender, EventArgs e)
        {
            string current = Email_tb.Text;
            if (!(Is_Email_Valid(current))) // trả về true or false
            {
                MessageBox.Show("Email không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email_tb.Focus(); // Trả lại focus vào TextBox
            }
        }

        private void Username_tb_Leave(object sender, EventArgs e)
        {
            if (Username_tb.Text == "") // trả về true or false
            {
                MessageBox.Show("Không được đễ trống dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username_tb.Focus();
            }
        }

        private void Retype_Password_tb_Leave(object sender, EventArgs e)
        {
            if (Retype_Password_tb.Text == "") // trả về true or false
            {
                MessageBox.Show("Không được đễ trống dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Retype_Password_tb.Focus();
            }
        }

        private void Password_tb_Leave(object sender, EventArgs e)
        {
            if (Password_tb.Text == "") // trả về true or false
            {
                MessageBox.Show("Không được đễ trống dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_tb.Focus();
            }
        }

        private void Form_Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you want to exit ?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form_Bai3_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form_Bai3_KeyDown;
        }

        private void Form_Bai3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Register_btn_Click(sender, e);
        }

    }
}
