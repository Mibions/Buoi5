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
    public partial class Form_Bai6 : Form
    {
        public Form_Bai6()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit !", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Result_tb.ResetText();
            Input_tb.ResetText();
        }

        private void Perform_btn_Click(object sender, EventArgs e)
        {
            string s, s1, s2, s3, k3, k2, k1;
            int d, c, t;
            s = Input_tb.Text;
            if (s.Length == 1)
            {
                k1 = s.Substring(s.Length - 1, 1);
                d = int.Parse(k1); s1 = don_vi(d);
                Result_tb.Text = s1;
            }

            else if (s.Length == 2)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                d = int.Parse(k1);
                c = int.Parse(k2);
                s1 = don_vi(d);
                s2 = chuc(c);
                Result_tb.Text = s2 + " " + s1 + " ";
            }

            else if (s.Length == 3)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                k3 = s.Substring(s.Length - 3, 1);
                d = int.Parse(k1);
                c = int.Parse(k2);
                t = int.Parse(k3);
                s1 = don_vi(d);
                s2 = chuc(c);
                s3 = tram(t);
                Result_tb.Text = s3 + " " + s2 + " " + s1 + " ";
            }

        }
        private string don_vi(int n)
        {
            switch (n)
            {
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám"; 
                case 9:
                    return "Chín";
                default:
                    return "Không";
            }
        }
        private string chuc(int n)
        {
            switch (n)
            {
                case 1:
                    return "Mười";
                case 2:
                    return "Hai Mươi";
                case 3:
                    return "Ba Mươi";
                case 4:
                    return "Bốn Mươi";
                case 5:
                    return "Năm Mươi";
                case 6:
                    return "Sáu Mươi";
                case 7:
                    return "Bảy Mươi";
                case 8:
                    return "Tám Mươi";
                case 9:
                    return "Chín Mươi";
                default:
                    return "Không Mươi";
            }
        }
        private string tram(int n)
        {
            switch (n)
            {
                case 1:
                    return "Một Trăm";
                case 2:
                    return "Hai Trăm";
                case 3:
                    return "Ba Trăm";
                case 4:
                    return "Bốn Trăm";
                case 5:
                    return "Năm Trăm";
                case 6:
                    return "Sáu Trăm";
                case 7:
                    return "Bảy Trăm";
                case 8:
                    return "Tám Trăm";
                case 9:
                    return "Chín Trăm";
                default:
                    return "Không Trăm";
            }
        }
    }
}
