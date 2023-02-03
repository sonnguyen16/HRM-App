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
    public partial class frmChucvu : Form
    {
       
    
         public frmChucvu()
        {
            InitializeComponent();
            Reset();
        }

        private void HienThiDanhSach()
        {

        }

        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            splitContainer1.Panel1Collapsed = false;
           

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (listViewCv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            else
            {
                showHide(true);
                textBoxMcv.Enabled = false;
                splitContainer1.Panel1Collapsed = false;
              
            }

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (listViewCv.SelectedItems.Count == 0)
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

        private void buttonLammoi_Click(object sender, EventArgs e)
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
      

   
        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBoxMcv.Text = "";
            textBoxTcv.Text = "";
            textBoxGc.Text = "";
            textBoxSearch.Text = "";
            textBoxMcv.Enabled = true;
            splitContainer1.Panel1Collapsed = true;
            showHide(false);
            HienThiDanhSach();
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
    }
}
