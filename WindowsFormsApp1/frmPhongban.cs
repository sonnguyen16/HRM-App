using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class frmPhongBan : Form
    {
    
        string state = null;

        public frmPhongBan()
        {
            InitializeComponent();
            Reset();
        }

        private void HienThiDanhSach()
        {
           
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


        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string line = comboBoxTimkiem.Text;


            if (line == "")
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo ", "Thông báo");
            }
            else
            {
                if (textBoxTimkiem.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa ", "Thông báo");
                }
                else
                {
                   
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            splitContainer1.Panel1Collapsed = false;
          
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (listViewPb.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            else
            {
                showHide(true);
                textBoxMpb.Enabled = false;
                splitContainer1.Panel1Collapsed = false;
                state = "Sua";
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (listViewPb.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    
                }
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (state == "Them")
            {
                try
                {
                    if (textBoxMpb.Text.Trim() == "" || textBoxTpb.Text.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                    }
                    else
                    {
                        

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            if (state == "Sua")
            {
               
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        void showHide(bool kt)
        {
            btnThem.Enabled = !kt;
            btnSua.Enabled = !kt;
            btnXoa.Enabled = !kt;
            btnLuu.Enabled = kt;
            btnHuy.Enabled = kt;
        }
       

       
        private void Reset()
        {
            textBoxMpb.Text = "";
            textBoxTpb.Text = "";
            textBoxGc.Text = "";
            textBoxTimkiem.Text = "";
            textBoxMpb.Enabled = true;
            splitContainer1.Panel1Collapsed = true;
            showHide(false);
            HienThiDanhSach();
        }

    }
}
