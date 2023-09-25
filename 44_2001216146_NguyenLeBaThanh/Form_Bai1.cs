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
    public partial class Form_Bai1 : Form
    {
        public Form_Bai1()
        {
            InitializeComponent();
        }

        private void Form_Bai1_Load(object sender, EventArgs e)
        {
        }

        private void Your_name_tb_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must entered your name !");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void Year_of_birth_tb_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length>0 && !char.IsDigit(ctr.Text[ctr.Text.Length-1]))
            {
                this.errorProvider1.SetError(ctr, "This is not avalid number !");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is : " + Your_name_tb.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(Year_of_birth_tb.Text);
            s = s + "Age : " + Year_of_birth_tb.Text.ToString();
            MessageBox.Show(s);
            //clear text
            Your_name_tb.Clear();
            Year_of_birth_tb.Clear();
            Your_name_tb.Focus();

        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you want to exit ?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
