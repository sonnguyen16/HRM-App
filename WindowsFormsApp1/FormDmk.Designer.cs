
namespace WindowsFormsApp1
{
    partial class FormDmk
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
            this.textBoxTk = new System.Windows.Forms.TextBox();
            this.textBoxMkc = new System.Windows.Forms.TextBox();
            this.textBoxMkm2 = new System.Windows.Forms.TextBox();
            this.textBoxMkm = new System.Windows.Forms.TextBox();
            this.buttonXn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(337, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(337, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(337, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(337, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // textBoxTk
            // 
            this.textBoxTk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTk.Location = new System.Drawing.Point(524, 151);
            this.textBoxTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTk.Name = "textBoxTk";
            this.textBoxTk.Size = new System.Drawing.Size(183, 27);
            this.textBoxTk.TabIndex = 4;
            // 
            // textBoxMkc
            // 
            this.textBoxMkc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMkc.Location = new System.Drawing.Point(524, 193);
            this.textBoxMkc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMkc.Name = "textBoxMkc";
            this.textBoxMkc.Size = new System.Drawing.Size(183, 27);
            this.textBoxMkc.TabIndex = 5;
            this.textBoxMkc.UseSystemPasswordChar = true;
            // 
            // textBoxMkm2
            // 
            this.textBoxMkm2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMkm2.Location = new System.Drawing.Point(524, 273);
            this.textBoxMkm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMkm2.Name = "textBoxMkm2";
            this.textBoxMkm2.Size = new System.Drawing.Size(183, 27);
            this.textBoxMkm2.TabIndex = 6;
            this.textBoxMkm2.UseSystemPasswordChar = true;
            // 
            // textBoxMkm
            // 
            this.textBoxMkm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMkm.Location = new System.Drawing.Point(524, 233);
            this.textBoxMkm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMkm.Name = "textBoxMkm";
            this.textBoxMkm.Size = new System.Drawing.Size(183, 27);
            this.textBoxMkm.TabIndex = 7;
            this.textBoxMkm.UseSystemPasswordChar = true;
            // 
            // buttonXn
            // 
            this.buttonXn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonXn.Location = new System.Drawing.Point(565, 330);
            this.buttonXn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXn.Name = "buttonXn";
            this.buttonXn.Size = new System.Drawing.Size(104, 32);
            this.buttonXn.TabIndex = 8;
            this.buttonXn.Text = "Xác nhận";
            this.buttonXn.UseVisualStyleBackColor = true;
            this.buttonXn.Click += new System.EventHandler(this.buttonXn_Click);
            // 
            // FormDmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 541);
            this.Controls.Add(this.buttonXn);
            this.Controls.Add(this.textBoxMkm);
            this.Controls.Add(this.textBoxMkm2);
            this.Controls.Add(this.textBoxMkc);
            this.Controls.Add(this.textBoxTk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDmk";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTk;
        private System.Windows.Forms.TextBox textBoxMkc;
        private System.Windows.Forms.TextBox textBoxMkm2;
        private System.Windows.Forms.TextBox textBoxMkm;
        private System.Windows.Forms.Button buttonXn;
    }
}