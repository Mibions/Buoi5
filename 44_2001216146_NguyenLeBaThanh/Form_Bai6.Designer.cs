
namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai6
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
            this.Perform_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Input_tb = new System.Windows.Forms.TextBox();
            this.Result_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỌC SỐ THÀNH CHỮ";
            // 
            // Perform_btn
            // 
            this.Perform_btn.Location = new System.Drawing.Point(31, 181);
            this.Perform_btn.Name = "Perform_btn";
            this.Perform_btn.Size = new System.Drawing.Size(75, 23);
            this.Perform_btn.TabIndex = 1;
            this.Perform_btn.Text = "Thực hiện";
            this.Perform_btn.UseVisualStyleBackColor = true;
            this.Perform_btn.Click += new System.EventHandler(this.Perform_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(152, 181);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Xóa";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(273, 181);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Thoát";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Input_tb
            // 
            this.Input_tb.Location = new System.Drawing.Point(235, 134);
            this.Input_tb.Name = "Input_tb";
            this.Input_tb.Size = new System.Drawing.Size(113, 20);
            this.Input_tb.TabIndex = 4;
            // 
            // Result_tb
            // 
            this.Result_tb.Location = new System.Drawing.Point(31, 220);
            this.Result_tb.Name = "Result_tb";
            this.Result_tb.Size = new System.Drawing.Size(317, 20);
            this.Result_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập dãy số ( từ 0 -> 999 )";
            // 
            // Form_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result_tb);
            this.Controls.Add(this.Input_tb);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Perform_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form_Bai6";
            this.Text = "Form_Bai6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Perform_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox Input_tb;
        private System.Windows.Forms.TextBox Result_tb;
        private System.Windows.Forms.Label label2;
    }
}