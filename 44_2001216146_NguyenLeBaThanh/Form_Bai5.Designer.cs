
namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Input_num_tb = new System.Windows.Forms.TextBox();
            this.Sum_list_tb = new System.Windows.Forms.TextBox();
            this.List_num_tb = new System.Windows.Forms.TextBox();
            this.Sum_even_num_tb = new System.Windows.Forms.TextBox();
            this.Sum_odd_num_tb = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Conti_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số Và Tính Tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dãy vừa nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các phần tử trong dãy số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng chẳn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng lẻ";
            // 
            // Input_num_tb
            // 
            this.Input_num_tb.Location = new System.Drawing.Point(139, 125);
            this.Input_num_tb.Name = "Input_num_tb";
            this.Input_num_tb.Size = new System.Drawing.Size(100, 20);
            this.Input_num_tb.TabIndex = 6;
            this.Input_num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_num_tb_KeyPress);
            // 
            // Sum_list_tb
            // 
            this.Sum_list_tb.Enabled = false;
            this.Sum_list_tb.Location = new System.Drawing.Point(201, 225);
            this.Sum_list_tb.Name = "Sum_list_tb";
            this.Sum_list_tb.Size = new System.Drawing.Size(128, 20);
            this.Sum_list_tb.TabIndex = 7;
            // 
            // List_num_tb
            // 
            this.List_num_tb.Enabled = false;
            this.List_num_tb.Location = new System.Drawing.Point(122, 178);
            this.List_num_tb.Name = "List_num_tb";
            this.List_num_tb.Size = new System.Drawing.Size(210, 20);
            this.List_num_tb.TabIndex = 8;
            // 
            // Sum_even_num_tb
            // 
            this.Sum_even_num_tb.Enabled = false;
            this.Sum_even_num_tb.Location = new System.Drawing.Point(107, 267);
            this.Sum_even_num_tb.Name = "Sum_even_num_tb";
            this.Sum_even_num_tb.Size = new System.Drawing.Size(71, 20);
            this.Sum_even_num_tb.TabIndex = 9;
            // 
            // Sum_odd_num_tb
            // 
            this.Sum_odd_num_tb.Enabled = false;
            this.Sum_odd_num_tb.Location = new System.Drawing.Point(103, 305);
            this.Sum_odd_num_tb.Name = "Sum_odd_num_tb";
            this.Sum_odd_num_tb.Size = new System.Drawing.Size(92, 20);
            this.Sum_odd_num_tb.TabIndex = 10;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(257, 125);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 11;
            this.Add_btn.Text = "Nhập";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Conti_btn
            // 
            this.Conti_btn.Location = new System.Drawing.Point(67, 350);
            this.Conti_btn.Name = "Conti_btn";
            this.Conti_btn.Size = new System.Drawing.Size(85, 36);
            this.Conti_btn.TabIndex = 12;
            this.Conti_btn.Text = "Tiếp tục";
            this.Conti_btn.UseVisualStyleBackColor = true;
            this.Conti_btn.Click += new System.EventHandler(this.Conti_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(187, 350);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(86, 36);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "Thoát";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Form_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Conti_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Sum_odd_num_tb);
            this.Controls.Add(this.Sum_even_num_tb);
            this.Controls.Add(this.List_num_tb);
            this.Controls.Add(this.Sum_list_tb);
            this.Controls.Add(this.Input_num_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Bai5";
            this.Text = "Form_Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Input_num_tb;
        private System.Windows.Forms.TextBox Sum_list_tb;
        private System.Windows.Forms.TextBox List_num_tb;
        private System.Windows.Forms.TextBox Sum_even_num_tb;
        private System.Windows.Forms.TextBox Sum_odd_num_tb;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Conti_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}