using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL;
using DAL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TAIKHOAN _tk = new TAIKHOAN();
        int second;
        public Form1()
        {
            InitializeComponent();
            label3.TextAlign = ContentAlignment.MiddleCenter;
            panel3.Parent = this;
            panel3.BackColor = Color.Transparent;
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
            label2.Parent = this;
            label2.BackColor = Color.Transparent;
            pictureBox1.Parent = this;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Parent = panel3;
            pictureBox2.BackColor = Color.Transparent;
            buttonLogin.Parent = panel3;
            buttonLogin.BackColor = Color.Transparent;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Location.X == 231)
            {
                
                label1.Cursor = Cursors.Arrow;
                label1.Location = new Point(label1.Location.X + 3, label1.Location.Y - 28);
                textboxTk.Focus();
            }
                
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Location.X == 231)
            {
              
                label2.Cursor = Cursors.Arrow;
                label2.Location = new Point(label2.Location.X + 3, label2.Location.Y - 28);
                textboxMk.Focus();
            }

        }
        private void textboxMk_Enter(object sender, EventArgs e)
        {
            
                if (label2.Location.X == 231)
                {
                   
                    label2.Cursor = Cursors.Arrow;
                    label2.Location = new Point(label2.Location.X + 3, label2.Location.Y - 28);
                }
          
            
        }
        private void textboxTk_Enter(object sender, EventArgs e)
        {

            if (label1.Location.X == 231)
            {
                
                label1.Cursor = Cursors.Arrow;
                label1.Location = new Point(label1.Location.X + 3, label1.Location.Y - 28);
            }
          
        }
        private void textboxTk_Leave(object sender, EventArgs e)
        {
                    if (string.IsNullOrEmpty(textboxTk.Text))
                    {
                       
                        label1.Cursor = Cursors.IBeam;
                        label1.Location = new Point(label1.Location.X - 3, label1.Location.Y + 28);
                    }
        }
        private void textboxMk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxMk.Text))
            {
                label2.Cursor = Cursors.IBeam;
                label2.Location = new Point(label2.Location.X - 3, label2.Location.Y + 28);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string tkn = textboxTk.Text.Trim();
            string mkn = textboxMk.Text.Trim();
            try
            {
                if (tkn == "")
                {
                    second = 0;
                    
                    label3.Text = "Bạn chưa nhập tài khoản";
                    label3.Left = (this.Width - label3.Width) / 2;
                    textboxTk.Focus();
                    return;
                }

                if (mkn == "")
                {
                    second = 0;
                    label3.Text = "Bạn chưa nhập mật khẩu";
                    label3.Left = (this.Width - label3.Width) / 2;
                    textboxMk.Focus();
                    return;
                }

                List<TaiKhoan> ls = _tk.GetTaiKhoans();

                bool kt()
                {
                    foreach (TaiKhoan tk in ls)
                    {
                        if (tkn == tk.Ten_TK && mkn == tk.Mat_Khau)
                        {
                            this.Hide();
                            frmMain frm = new frmMain(tk.Loai_Tk, tk.Ten_TK);
                            frm.Show();
                            return true;
                        }
                       
                    }
                    return false;
                }

                if (!kt())
                {
                    second = 0;
                    label3.Text = "Tài khoản hoặc mật khẩu không chính xác";
                    label3.Left = (this.Width - label3.Width) / 2;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 30)
            {
                label3.Text = string.Empty;
            }
        }

        
    }
}
