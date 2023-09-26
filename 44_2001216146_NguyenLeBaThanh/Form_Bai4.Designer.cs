
namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai4
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
            this.components = new System.ComponentModel.Container();
            this.Input_a_tb = new System.Windows.Forms.TextBox();
            this.Input_a_lb = new System.Windows.Forms.Label();
            this.Input_b_lb = new System.Windows.Forms.Label();
            this.Input_b_tb = new System.Windows.Forms.TextBox();
            this.UCLN_lb = new System.Windows.Forms.Label();
            this.BCNN_lb = new System.Windows.Forms.Label();
            this.Result_UCLN_tb = new System.Windows.Forms.TextBox();
            this.Result_BCNN_tb = new System.Windows.Forms.TextBox();
            this.Cal_btn = new System.Windows.Forms.Button();
            this.Cont_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Title_lb = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_a_tb
            // 
            this.Input_a_tb.Location = new System.Drawing.Point(181, 82);
            this.Input_a_tb.Name = "Input_a_tb";
            this.Input_a_tb.Size = new System.Drawing.Size(161, 20);
            this.Input_a_tb.TabIndex = 0;
            this.Input_a_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_a_tb_KeyPress);
            // 
            // Input_a_lb
            // 
            this.Input_a_lb.AutoSize = true;
            this.Input_a_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_a_lb.Location = new System.Drawing.Point(73, 83);
            this.Input_a_lb.Name = "Input_a_lb";
            this.Input_a_lb.Size = new System.Drawing.Size(72, 19);
            this.Input_a_lb.TabIndex = 1;
            this.Input_a_lb.Text = "Nhập số a";
            // 
            // Input_b_lb
            // 
            this.Input_b_lb.AutoSize = true;
            this.Input_b_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_b_lb.Location = new System.Drawing.Point(73, 131);
            this.Input_b_lb.Name = "Input_b_lb";
            this.Input_b_lb.Size = new System.Drawing.Size(73, 19);
            this.Input_b_lb.TabIndex = 2;
            this.Input_b_lb.Text = "Nhập số b";
            // 
            // Input_b_tb
            // 
            this.Input_b_tb.Location = new System.Drawing.Point(181, 130);
            this.Input_b_tb.Name = "Input_b_tb";
            this.Input_b_tb.Size = new System.Drawing.Size(161, 20);
            this.Input_b_tb.TabIndex = 3;
            this.Input_b_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_b_tb_KeyPress);
            // 
            // UCLN_lb
            // 
            this.UCLN_lb.AutoSize = true;
            this.UCLN_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCLN_lb.Location = new System.Drawing.Point(73, 188);
            this.UCLN_lb.Name = "UCLN_lb";
            this.UCLN_lb.Size = new System.Drawing.Size(144, 19);
            this.UCLN_lb.TabIndex = 4;
            this.UCLN_lb.Text = "Ước số chung lớn nhất";
            // 
            // BCNN_lb
            // 
            this.BCNN_lb.AutoSize = true;
            this.BCNN_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCNN_lb.Location = new System.Drawing.Point(73, 239);
            this.BCNN_lb.Name = "BCNN_lb";
            this.BCNN_lb.Size = new System.Drawing.Size(142, 19);
            this.BCNN_lb.TabIndex = 5;
            this.BCNN_lb.Text = "Bội số chung nhỏ nhất";
            // 
            // Result_UCLN_tb
            // 
            this.Result_UCLN_tb.Enabled = false;
            this.Result_UCLN_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_UCLN_tb.Location = new System.Drawing.Point(238, 189);
            this.Result_UCLN_tb.Name = "Result_UCLN_tb";
            this.Result_UCLN_tb.ReadOnly = true;
            this.Result_UCLN_tb.Size = new System.Drawing.Size(104, 22);
            this.Result_UCLN_tb.TabIndex = 6;
            this.Result_UCLN_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Result_BCNN_tb
            // 
            this.Result_BCNN_tb.Enabled = false;
            this.Result_BCNN_tb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_BCNN_tb.Location = new System.Drawing.Point(238, 238);
            this.Result_BCNN_tb.Name = "Result_BCNN_tb";
            this.Result_BCNN_tb.ReadOnly = true;
            this.Result_BCNN_tb.Size = new System.Drawing.Size(104, 22);
            this.Result_BCNN_tb.TabIndex = 7;
            this.Result_BCNN_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cal_btn
            // 
            this.Cal_btn.Location = new System.Drawing.Point(77, 282);
            this.Cal_btn.Name = "Cal_btn";
            this.Cal_btn.Size = new System.Drawing.Size(94, 37);
            this.Cal_btn.TabIndex = 8;
            this.Cal_btn.Text = "Thực Hiện";
            this.Cal_btn.UseVisualStyleBackColor = true;
            this.Cal_btn.Click += new System.EventHandler(this.Cal_btn_Click);
            // 
            // Cont_btn
            // 
            this.Cont_btn.Location = new System.Drawing.Point(181, 282);
            this.Cont_btn.Name = "Cont_btn";
            this.Cont_btn.Size = new System.Drawing.Size(93, 37);
            this.Cont_btn.TabIndex = 9;
            this.Cont_btn.Text = "Tiếp Tục";
            this.Cont_btn.UseVisualStyleBackColor = true;
            this.Cont_btn.Click += new System.EventHandler(this.Cont_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(280, 282);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(92, 37);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "Thoát";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Title_lb
            // 
            this.Title_lb.AutoSize = true;
            this.Title_lb.BackColor = System.Drawing.Color.White;
            this.Title_lb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lb.ForeColor = System.Drawing.Color.Red;
            this.Title_lb.Location = new System.Drawing.Point(72, 27);
            this.Title_lb.Name = "Title_lb";
            this.Title_lb.Size = new System.Drawing.Size(300, 26);
            this.Title_lb.TabIndex = 11;
            this.Title_lb.Text = "Ước số chung - Bội số chung";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 338);
            this.Controls.Add(this.Title_lb);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Cont_btn);
            this.Controls.Add(this.Cal_btn);
            this.Controls.Add(this.Result_BCNN_tb);
            this.Controls.Add(this.Result_UCLN_tb);
            this.Controls.Add(this.BCNN_lb);
            this.Controls.Add(this.UCLN_lb);
            this.Controls.Add(this.Input_b_tb);
            this.Controls.Add(this.Input_b_lb);
            this.Controls.Add(this.Input_a_lb);
            this.Controls.Add(this.Input_a_tb);
            this.Name = "Form_Bai4";
            this.Text = "Form_Bai4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_a_tb;
        private System.Windows.Forms.Label Input_a_lb;
        private System.Windows.Forms.Label Input_b_lb;
        private System.Windows.Forms.TextBox Input_b_tb;
        private System.Windows.Forms.Label UCLN_lb;
        private System.Windows.Forms.Label BCNN_lb;
        private System.Windows.Forms.TextBox Result_UCLN_tb;
        private System.Windows.Forms.TextBox Result_BCNN_tb;
        private System.Windows.Forms.Button Cal_btn;
        private System.Windows.Forms.Button Cont_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label Title_lb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}