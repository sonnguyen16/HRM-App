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
    public partial class frmChucvu : Form
    {
        string ConectionString = Properties.Settings.Default.ConectionString;
        public frmChucvu()
        {
            InitializeComponent();
        }

        private void frmChucvu_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void ReadData(string query)
        {
            SqlConnection conn = new SqlConnection(ConectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            listViewCv.Items.Clear();
            string[] arr = new string[3];
            while (reader.Read())
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = reader.GetString(i);
                }
               

                ListViewItem lv = new ListViewItem(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    lv.SubItems.Add(arr[i]);
                }

                listViewCv.Items.Add(lv);

            }
            reader.Close();
        }

        private void HienThiDanhSach()
        {
            try
            {
                string query = "select * from ChucVu";
                ReadData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMcv.Text.Trim() == "" || textBoxTcv.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                }
                else
                {
                    string query = "insert into ChucVu values ('" + textBoxMcv.Text.Trim() + "',N'" + textBoxTcv.Text.Trim() + "',N'" + textBoxGc.Text.Trim() + "')";
                    UpdateData(query, "Thêm thành công", "Thêm thất bại");
                }
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void UpdateData(string query, string nofi, string nofi1)
        {
            SqlConnection conn = new SqlConnection(ConectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);

            int kq = cmd.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show(nofi, "Thông báo");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show(nofi1, "Thông báo");
            }
        }
        private void Reset()
        {
            textBoxMcv.Text = "";
            textBoxTcv.Text = "";
            textBoxGc.Text = "";
            textBoxSearch.Text = "";
            textBoxMcv.Enabled = true;

            HienThiDanhSach();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            
            try
            {
                string query = "update ChucVu set Ma_ChucVu = '" + textBoxMcv.Text.Trim() + "',Ten_ChucVu = N'" + textBoxTcv.Text.Trim() + "',Ghi_Chu = N'" + textBoxGc.Text.Trim() + "' where Ma_ChucVu ='" + textBoxMcv.Text.Trim() + "' ";
                UpdateData(query, "Chỉnh sửa thành công", "Chỉnh sửa thất bại");
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void buttonLammoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void listViewCv_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMcv.Enabled = false;
            if (listViewCv.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem lvi = listViewCv.SelectedItems[0];

            textBoxMcv.Text = lvi.SubItems[0].Text;
            textBoxTcv.Text = lvi.SubItems[1].Text;
            textBoxGc.Text = lvi.SubItems[2].Text;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
       
            string line = comboBoxSearch.Text;


            if (line == "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo ", "Thông báo");
            }
            else
            {
                if (textBoxSearch.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa ", "Thông báo");
                }
                else
                {
                    if (line == "1. Mã chức vụ")
                    {
                        string query = "select * from ChucVu where Ma_ChucVu like '" + textBoxSearch.Text.Trim() + "%'";
                        ReadData(query);

                    }
                    else
                    {
                        string query = "select * from ChucVu where Ten_ChucVu like N'" + textBoxSearch.Text.Trim() + "%'";
                        ReadData(query);
                    }
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMcv.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    XoaCv();
                }
            }
        }

        private void XoaCv()
        {
            try
            {
                string query = "delete from ChucVu where Ma_ChucVu = '" + textBoxMcv.Text.Trim() + "'";
                UpdateData(query, "Xóa thành công", "Xóa thất bại");
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
