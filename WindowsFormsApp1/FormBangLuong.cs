using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.WebUtils;
using DAL;
using BL;

namespace WindowsFormsApp1
{
    public partial class formBangLuong : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();
        BANGCHAMCONG _bcc = new BANGCHAMCONG();
        THONGTINLUONG _ttl = new THONGTINLUONG();
        BANGLUONG _bl = new BANGLUONG();
        public formBangLuong()
        {
            InitializeComponent();
            Reset();
        }

        void showHide(bool kt)
        {
            btnThem.Enabled = !kt;
            btnLuu.Enabled = kt;
            btnHuy.Enabled = kt;
            splitContainer1.Panel2.Enabled = !kt;
        }

        void Reset()
        {
            showHide(false);
            LoadCombo();
            searchLookUpEdit1.EditValue = null;
            searchLookUpEdit2.EditValue = null;
            label1.Text = string.Empty;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
            showHide(true);
            splitContainer1.Panel1Collapsed = false;
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        void LoadCombo()
        {
            searchLookUpEdit1.Properties.DataSource = _bcc.getBL();
            searchLookUpEdit1.Properties.DisplayMember = "MA_CC";
            searchLookUpEdit1.Properties.ValueMember = "MA_CC";
            searchLookUpEdit2.Properties.DataSource = _bcc.getBL2();
            searchLookUpEdit2.Properties.DisplayMember = "MA_CC";
            searchLookUpEdit2.Properties.ValueMember = "MA_CC";
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null)
            {
                label1.Text = "Bạn chưa chọn bảng chấm công";
            }
            else
            {
                var bcc = _bcc.GetBangChamCong(searchLookUpEdit1.Text);
                

                List<ThongTinLuong> ls = _ttl.GetThongTinLuongs();
                List<BangLuong> ls2 = _bl.GetBangLuongs();
                
                foreach (var item in ls)
                {
                    BangLuong bl = new BangLuong();
                    bl.MA_CC = bcc.MA_CC;
                    bl.MA_LUONG = item.MA_LUONG;
                    bl.MA_NV = item.MA_NV;

                    _bl.Add(bl);
                    ls2.Add(bl);
                }

                gridControl1.DataSource = et.LapBangLuong3(bcc.Thang, bcc.Nam).ToList();
                MessageBox.Show("Tạo thành công");

                foreach (var item in ls2)
                {
                    for (int i = 0; i < cardView1.DataRowCount; i++)
                    {
                        float j;
                        if (cardView1.GetRowCellValue(i, "MA_NV").ToString() == item.MA_NV && item.MA_CC == searchLookUpEdit1.Text)
                        {
                            float.TryParse(cardView1.GetRowCellValue(i, "Thuc_Lanh").ToString(), out j);
                            item.Thuc_Lanh = j;
                            j = 0;
                        }
                    }
                    _bl.Update(item);
                }

                Reset();
            }
        }

        private void simpleButtonXem_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit2.EditValue == null)
            {
                label1.Text = "Bạn chưa chọn bảng chấm công";
            }
            else
            {
                var bcc = _bcc.GetBangChamCong(searchLookUpEdit2.Text);
                gridControl1.DataSource = et.LapBangLuong3(bcc.Thang, bcc.Nam).ToList();
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }
    }
}