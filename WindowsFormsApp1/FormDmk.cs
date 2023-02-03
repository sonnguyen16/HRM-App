using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL;
using DAL;


namespace WindowsFormsApp1
{
    public partial class FormDmk : Form
    {

        string Ten_Tk;
        public FormDmk(string Tai_Khoan)
        {
            InitializeComponent();
            textBoxTk.Text = Tai_Khoan;
            textBoxTk.Enabled = false;
            Ten_Tk = Tai_Khoan;
        }
       

        private void KiemTraNhap()
        {
            string mkc = textBoxMkc.Text.Trim();
            string mkm = textBoxMkm.Text.Trim();
            string mkm2 = textBoxMkm2.Text.Trim();

            if (mkc == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMkc.Focus();
                return;
            }
            if (mkm == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo");
                textBoxMkm.Focus();
                return;
            }
            else
            {
                if (mkm2 == string.Empty)
                {
                    MessageBox.Show("Bạn chưa xác nhận mật khẩu mới", "Thông báo");
                    textBoxMkm2.Focus();
                    return;
                }
                else
                {
                    if (mkm != mkm2)
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo");
                    }
                    else
                    {
                        TAIKHOAN _tk = new TAIKHOAN();
                        TaiKhoan tk = _tk.GetTaiKhoan(Ten_Tk);
                        if (mkc == tk.Mat_Khau)
                        {
                            tk.Mat_Khau = mkm;
                            _tk.Update(tk);
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                            textBoxMkc.Clear();
                            textBoxMkm.Clear();
                            textBoxMkm2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo");
                        }
                    }
                }
            }
        }

        private void buttonXn_Click(object sender, EventArgs e)
        {
            KiemTraNhap();
        }
        private void Reset()
        {
            textBoxMkc.Clear();
            textBoxMkm.Clear();
            textBoxMkm2.Clear();
        }
    }
}
