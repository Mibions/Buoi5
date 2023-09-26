using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_2001216146_NguyenLeBaThanh
{
    static class Program_Bai_1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Bai1()); // Bai 1
            //Application.Run(new Form_Bai2()); // Bai 2
            Application.Run(new Form_Bai3()); // Bai 3
        }
    }
}
