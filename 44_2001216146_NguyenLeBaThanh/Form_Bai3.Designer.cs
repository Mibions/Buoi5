
namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai3
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
            this.Usernam_lb = new System.Windows.Forms.Label();
            this.Email_lb = new System.Windows.Forms.Label();
            this.Password_lb = new System.Windows.Forms.Label();
            this.Retype_Password_lb = new System.Windows.Forms.Label();
            this.Username_tb = new System.Windows.Forms.TextBox();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Retype_Password_tb = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Title_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Usernam_lb
            // 
            this.Usernam_lb.AutoSize = true;
            this.Usernam_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernam_lb.Location = new System.Drawing.Point(64, 88);
            this.Usernam_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usernam_lb.Name = "Usernam_lb";
            this.Usernam_lb.Size = new System.Drawing.Size(107, 19);
            this.Usernam_lb.TabIndex = 5;
            this.Usernam_lb.Text = "Tên đăng nhập";
            // 
            // Email_lb
            // 
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.Location = new System.Drawing.Point(64, 151);
            this.Email_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(96, 19);
            this.Email_lb.TabIndex = 6;
            this.Email_lb.Text = "Địa chỉ email";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lb.Location = new System.Drawing.Point(64, 215);
            this.Password_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(75, 19);
            this.Password_lb.TabIndex = 7;
            this.Password_lb.Text = "Mật khẩu";
            // 
            // Retype_Password_lb
            // 
            this.Retype_Password_lb.AutoSize = true;
            this.Retype_Password_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retype_Password_lb.Location = new System.Drawing.Point(64, 286);
            this.Retype_Password_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Retype_Password_lb.Name = "Retype_Password_lb";
            this.Retype_Password_lb.Size = new System.Drawing.Size(137, 19);
            this.Retype_Password_lb.TabIndex = 8;
            this.Retype_Password_lb.Text = "Xác nhận mật khẩu";
            // 
            // Username_tb
            // 
            this.Username_tb.Location = new System.Drawing.Point(228, 81);
            this.Username_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(176, 26);
            this.Username_tb.TabIndex = 0;
            this.Username_tb.Leave += new System.EventHandler(this.Username_tb_Leave);
            // 
            // Email_tb
            // 
            this.Email_tb.Location = new System.Drawing.Point(228, 144);
            this.Email_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(176, 26);
            this.Email_tb.TabIndex = 1;
            this.Email_tb.Leave += new System.EventHandler(this.Email_tb_Leave);
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(228, 208);
            this.Password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(176, 26);
            this.Password_tb.TabIndex = 2;
            this.Password_tb.Leave += new System.EventHandler(this.Password_tb_Leave);
            // 
            // Retype_Password_tb
            // 
            this.Retype_Password_tb.Location = new System.Drawing.Point(228, 279);
            this.Retype_Password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Retype_Password_tb.Name = "Retype_Password_tb";
            this.Retype_Password_tb.PasswordChar = '*';
            this.Retype_Password_tb.Size = new System.Drawing.Size(176, 26);
            this.Retype_Password_tb.TabIndex = 3;
            this.Retype_Password_tb.Leave += new System.EventHandler(this.Retype_Password_tb_Leave);
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Location = new System.Drawing.Point(228, 331);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(176, 70);
            this.Register_btn.TabIndex = 4;
            this.Register_btn.Text = "Đăng Kí";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Title_lb
            // 
            this.Title_lb.AutoSize = true;
            this.Title_lb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title_lb.Location = new System.Drawing.Point(224, 23);
            this.Title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_lb.Name = "Title_lb";
            this.Title_lb.Size = new System.Drawing.Size(190, 24);
            this.Title_lb.TabIndex = 9;
            this.Title_lb.Text = "Đăng Ký Tài Khoản";
            // 
            // Form_Bai3
            // 
            this.AcceptButton = this.Register_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 432);
            this.Controls.Add(this.Title_lb);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Retype_Password_tb);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Email_tb);
            this.Controls.Add(this.Username_tb);
            this.Controls.Add(this.Retype_Password_lb);
            this.Controls.Add(this.Password_lb);
            this.Controls.Add(this.Email_lb);
            this.Controls.Add(this.Usernam_lb);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Bai3";
            this.Text = "Form_Bai3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Bai3_FormClosing);
            this.Load += new System.EventHandler(this.Form_Bai3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernam_lb;
        private System.Windows.Forms.Label Email_lb;
        private System.Windows.Forms.Label Password_lb;
        private System.Windows.Forms.Label Retype_Password_lb;
        private System.Windows.Forms.TextBox Username_tb;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.TextBox Retype_Password_tb;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label Title_lb;
    }
}