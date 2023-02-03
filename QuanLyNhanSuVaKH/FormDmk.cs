using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSuVaKH
{
    public partial class FormDmk : Form
    {
        string ConectionString = Properties.Settings.Default.ConectionString;
        
      
        public FormDmk(string Tai_Khoan)
        {
            InitializeComponent();
            textBoxTk.Text = Tai_Khoan;
            textBoxTk.Enabled = false;
        }

        private void KiemTraMKCu()
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(ConectionString);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TaiKhoan = textBoxTk.Text.Trim();
                string MatKhau = textBoxMkc.Text.Trim();
                string query = "select * from TaiKhoan where Ten_TK = '" + TaiKhoan + "' and Mat_Khau= '" + MatKhau + "' ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    UpdateMk();
                }
                else
                {
                    MessageBox.Show(" mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMk()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConectionString);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update TaiKhoan set Mat_Khau ='"+textBoxMkm.Text.Trim()+"' where Ten_TK ='"+textBoxTk.Text+"'";
                SqlCommand cmd = new SqlCommand(query, conn);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void KiemTraNhap()
        {
            string mkc = textBoxMkc.Text.Trim();
            string mkm = textBoxMkm.Text.Trim();
            string mkm2 = textBoxMkm2.Text.Trim();

            if (mkc == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMkc.Focus();
                return;
            }
            if (mkm =="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo");
                textBoxMkm.Focus();
                return;
            }
            else
            {
                if (mkm2 =="")
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
                        KiemTraMKCu();
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
