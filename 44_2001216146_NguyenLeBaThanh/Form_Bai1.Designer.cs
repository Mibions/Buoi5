
using System;

namespace _44_2001216146_NguyenLeBaThanh
{
    partial class Form_Bai1
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
            this.Name_lb = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Your_name_tb = new System.Windows.Forms.TextBox();
            this.Year_Of_Birth_lb = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Year_of_birth_tb = new System.Windows.Forms.TextBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_lb
            // 
            this.Name_lb.AutoSize = true;
            this.Name_lb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lb.Location = new System.Drawing.Point(52, 72);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(102, 22);
            this.Name_lb.TabIndex = 1;
            this.Name_lb.Text = "Your Name";
            // 
            // Show_btn
            // 
            this.Show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Show_btn.Location = new System.Drawing.Point(56, 171);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(82, 36);
            this.Show_btn.TabIndex = 5;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Your_name_tb
            // 
            this.Your_name_tb.Location = new System.Drawing.Point(185, 72);
            this.Your_name_tb.Name = "Your_name_tb";
            this.Your_name_tb.Size = new System.Drawing.Size(208, 20);
            this.Your_name_tb.TabIndex = 2;
            this.Your_name_tb.TextChanged += new System.EventHandler(this.Your_name_tb_TextChanged);
            // 
            // Year_Of_Birth_lb
            // 
            this.Year_Of_Birth_lb.AutoSize = true;
            this.Year_Of_Birth_lb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_Of_Birth_lb.Location = new System.Drawing.Point(52, 125);
            this.Year_Of_Birth_lb.Name = "Year_Of_Birth_lb";
            this.Year_Of_Birth_lb.Size = new System.Drawing.Size(121, 22);
            this.Year_Of_Birth_lb.TabIndex = 3;
            this.Year_Of_Birth_lb.Text = "Year Of Birth";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(44, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 39);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Your Information";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Year_of_birth_tb
            // 
            this.Year_of_birth_tb.Location = new System.Drawing.Point(185, 128);
            this.Year_of_birth_tb.Name = "Year_of_birth_tb";
            this.Year_of_birth_tb.Size = new System.Drawing.Size(208, 20);
            this.Year_of_birth_tb.TabIndex = 4;
            this.Year_of_birth_tb.TextChanged += new System.EventHandler(this.Year_of_birth_tb_TextChanged);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(201, 169);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(92, 38);
            this.Clear_btn.TabIndex = 6;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            // 
            // Exit_btn
            // 
            this.Exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_btn.Location = new System.Drawing.Point(343, 173);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(81, 34);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Bai1
            // 
            this.AcceptButton = this.Show_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_btn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Year_of_birth_tb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Year_Of_Birth_lb);
            this.Controls.Add(this.Your_name_tb);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Name_lb);
            this.Name = "Form_Bai1";
            this.Text = "Form_Bai_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Bai1_FormClosing);
            this.Load += new System.EventHandler(this.Form_Bai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.TextBox Your_name_tb;
        private System.Windows.Forms.Label Year_Of_Birth_lb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Year_of_birth_tb;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

