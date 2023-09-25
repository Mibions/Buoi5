
namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Input_A_tb = new System.Windows.Forms.TextBox();
            this.Input_B_tb = new System.Windows.Forms.TextBox();
            this.Result_tb = new System.Windows.Forms.TextBox();
            this.Addition_btn = new System.Windows.Forms.Button();
            this.Subtraction_btn = new System.Windows.Forms.Button();
            this.Multiplication_btn = new System.Windows.Forms.Button();
            this.Division_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // Input_A_tb
            // 
            this.Input_A_tb.Location = new System.Drawing.Point(71, 34);
            this.Input_A_tb.Name = "Input_A_tb";
            this.Input_A_tb.Size = new System.Drawing.Size(100, 20);
            this.Input_A_tb.TabIndex = 3;
            this.Input_A_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_A_tb_KeyPress);
            // 
            // Input_B_tb
            // 
            this.Input_B_tb.Location = new System.Drawing.Point(271, 34);
            this.Input_B_tb.Name = "Input_B_tb";
            this.Input_B_tb.Size = new System.Drawing.Size(100, 20);
            this.Input_B_tb.TabIndex = 4;
            this.Input_B_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_B_tb_KeyPress);
            // 
            // Result_tb
            // 
            this.Result_tb.Location = new System.Drawing.Point(125, 87);
            this.Result_tb.Name = "Result_tb";
            this.Result_tb.Size = new System.Drawing.Size(202, 20);
            this.Result_tb.TabIndex = 5;
            // 
            // Addition_btn
            // 
            this.Addition_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition_btn.Location = new System.Drawing.Point(13, 123);
            this.Addition_btn.Name = "Addition_btn";
            this.Addition_btn.Size = new System.Drawing.Size(75, 35);
            this.Addition_btn.TabIndex = 6;
            this.Addition_btn.Text = "+";
            this.Addition_btn.UseVisualStyleBackColor = true;
            this.Addition_btn.Click += new System.EventHandler(this.Addvision_btn_Click);
            // 
            // Subtraction_btn
            // 
            this.Subtraction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction_btn.Location = new System.Drawing.Point(128, 123);
            this.Subtraction_btn.Name = "Subtraction_btn";
            this.Subtraction_btn.Size = new System.Drawing.Size(75, 35);
            this.Subtraction_btn.TabIndex = 7;
            this.Subtraction_btn.Text = "-";
            this.Subtraction_btn.UseVisualStyleBackColor = true;
            this.Subtraction_btn.Click += new System.EventHandler(this.Subtraction_btn_Click);
            // 
            // Multiplication_btn
            // 
            this.Multiplication_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication_btn.Location = new System.Drawing.Point(252, 123);
            this.Multiplication_btn.Name = "Multiplication_btn";
            this.Multiplication_btn.Size = new System.Drawing.Size(75, 35);
            this.Multiplication_btn.TabIndex = 8;
            this.Multiplication_btn.Text = "x";
            this.Multiplication_btn.UseVisualStyleBackColor = true;
            this.Multiplication_btn.Click += new System.EventHandler(this.Multiplication_btn_Click);
            // 
            // Division_btn
            // 
            this.Division_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division_btn.Location = new System.Drawing.Point(377, 123);
            this.Division_btn.Name = "Division_btn";
            this.Division_btn.Size = new System.Drawing.Size(75, 35);
            this.Division_btn.TabIndex = 9;
            this.Division_btn.Text = "/";
            this.Division_btn.UseVisualStyleBackColor = true;
            this.Division_btn.Click += new System.EventHandler(this.Division_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 180);
            this.Controls.Add(this.Division_btn);
            this.Controls.Add(this.Multiplication_btn);
            this.Controls.Add(this.Subtraction_btn);
            this.Controls.Add(this.Addition_btn);
            this.Controls.Add(this.Result_tb);
            this.Controls.Add(this.Input_B_tb);
            this.Controls.Add(this.Input_A_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Bai2";
            this.Text = "Form_Bai2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Input_A_tb;
        private System.Windows.Forms.TextBox Input_B_tb;
        private System.Windows.Forms.TextBox Result_tb;
        private System.Windows.Forms.Button Addition_btn;
        private System.Windows.Forms.Button Subtraction_btn;
        private System.Windows.Forms.Button Multiplication_btn;
        private System.Windows.Forms.Button Division_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}