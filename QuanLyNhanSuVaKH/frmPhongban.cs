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
    public partial class frmPhongBan : Form
    {
        string ConectionString = Properties.Settings.Default.ConectionString;

        public frmPhongBan()
        {
            InitializeComponent();
          

        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {

            try
            {
                string query = "select * from PhongBan";
                ReadData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMpb.Text.Trim() == "" || textBoxTpb.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                }
                else
                {
                    string query = "insert into PhongBan values ('" + textBoxMpb.Text.Trim() + "',N'" + textBoxTpb.Text.Trim() + "',N'" + textBoxGc.Text.Trim() + "')";
                    UpdateData(query, "Thêm thành công", "Thêm thất bại");
                }
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void listViewPb_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMpb.Enabled = false;
            if (listViewPb.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem lvi = listViewPb.SelectedItems[0];

            textBoxMpb.Text = lvi.SubItems[0].Text;
            textBoxTpb.Text = lvi.SubItems[1].Text;
            textBoxGc.Text = lvi.SubItems[2].Text;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMpb.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu");
                }
                else
                {
                    string query = "update PhongBan set Ma_PhongBan = '" + textBoxMpb.Text.Trim() + "',Ten_PhongBan= N'" + textBoxTpb.Text.Trim() + "',Ghi_Chu = N'" + textBoxGc.Text.Trim() + "' where Ma_PhongBan ='" + textBoxMpb.Text.Trim() + "' ";
                    UpdateData(query, "Chỉnh sửa thành công", "Chỉnh sửa thất bại");
                    Reset();
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

       

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBoxMpb.Text = "";
            textBoxTpb.Text = "";
            textBoxGc.Text = "";
            textBoxTimkiem.Text = "";
            textBoxMpb.Enabled = true;

            HienThiDanhSach();
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            buttonHuy.Enabled = true;
            string line = comboBoxTimkiem.Text;
            
            
            if (line == "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo ", "Thông báo");
            }
            else
            {
                if (textBoxTimkiem.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa ", "Thông báo");
                }
                else
                {
                    if (line == "1. Mã phòng ban")
                    {
                        string query = "select * from PhongBan where Ma_PhongBan like '"+textBoxTimkiem.Text.Trim()+"%'";
                        ReadData(query);

                    }
                    else
                    {
                        string query = "select * from PhongBan where Ten_PhongBan like N'"+textBoxTimkiem.Text.Trim()+"%'";
                        ReadData(query);
                    }
                }
            }
        }

        internal void ReadData(string query)
        {
            SqlConnection conn = new SqlConnection(ConectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            listViewPb.Items.Clear();
            while (reader.Read())
            {

                string MaPhongBan = reader.GetString(0);
                string TenPhongBan = reader.GetString(1);
                string GhiChu = reader.GetString(2);

                ListViewItem lv = new ListViewItem(MaPhongBan);
                lv.SubItems.Add(TenPhongBan);
                lv.SubItems.Add(GhiChu);

                listViewPb.Items.Add(lv);

            }
            reader.Close();
        }

        internal void UpdateData(string query,string nofi,string nofi1)
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMpb.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    XoaPb();
                }
            }
        }

        private void XoaPb()
        {
            try
            {
                string query = "delete from PhongBan where Ma_PhongBan = '"+textBoxMpb.Text.Trim()+"'";
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
