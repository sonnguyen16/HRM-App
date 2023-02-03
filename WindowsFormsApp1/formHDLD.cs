using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAL;

namespace WindowsFormsApp1
{
    public partial class formHDLD : Form
    {
        HDLD _hdld = new HDLD();
        NHANVIEN _nv = new NHANVIEN();
        int i;
        bool Them = true;
        string MA_HD;
        public formHDLD()
        {
            InitializeComponent();
            Reset();
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (KiemTraNhap())
                {
                    SaveData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi xảy ra " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            private void SaveData()
        {
            if (Them)
            {
                i = gridView1.RowCount;
                HopDongLaoDong hdld = new HopDongLaoDong();
                hdld.MA_HD = "HDLD" + (i + 1).ToString();
                hdld.NGAY_KY = dateTimePicker3.Value;
                if (comboBox1.Text == "Có thời hạn")
                {
                    hdld.NGAY_BD = dateTimePicker1.Value;
                    hdld.NGAY_KT = dateTimePicker2.Value;
                }
                hdld.LAN_KY = int.Parse(spinEdit1.EditValue.ToString());
                hdld.LOAI_HD = comboBox1.Text;
                hdld.MA_NV = searchLookUpEdit1.EditValue.ToString();
                hdld.NOI_DUNG = richEditControl1.HtmlText;


                _hdld.Add(hdld);
                Reset();
            }
            if(!Them)
            {
                var hdld = _hdld.GetHopDongLaoDong(MA_HD);
                
                if (comboBox1.Text == "Có thời hạn")
                {
                    hdld.NGAY_BD = dateTimePicker1.Value;
                    hdld.NGAY_KT = dateTimePicker2.Value;
                }
                else
                {
                    hdld.NGAY_BD = null;
                    hdld.NGAY_KT = null;
                }
                hdld.NGAY_KY = dateTimePicker3.Value;
                hdld.LAN_KY = int.Parse(spinEdit1.EditValue.ToString());
                hdld.LOAI_HD = comboBox1.Text;
                hdld.MA_NV = searchLookUpEdit1.EditValue.ToString();
                hdld.NOI_DUNG = richEditControl1.HtmlText;

                _hdld.Update(hdld);
                Reset();
            }
        }

        private bool KiemTraNhap()
        {
            if (comboBox1.Text == string.Empty)
            {
                label9.Text = "Bạn chưa chọn loại hợp đồng";
                label3.ForeColor = Color.Red;
                return false;
            }

            if (searchLookUpEdit1.EditValue == null)
            {
                label9.Text = "Bạn chưa chọn nhân viên";
                label2.ForeColor = Color.Red;
                return false;
            }
           
            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Them)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    try
                    {
                        _hdld.Delete(MA_HD);
                        Reset();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Có lỗi xảy ra " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Them)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
            }
            else
            {
                try
                {
                    showHide(true);
                    searchLookUpEdit1.Enabled = false;
                    splitContainer1.Panel1Collapsed = false;
                    Them = false;
                    LoadNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn điều kiện tìm kiếm");
            }
            else
            {
                if (textBoxSearch.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa");
                }
                else
                {
                    if (comboBoxSearch.Text.Trim() == "Mã hợp đồng")
                    {
                        gridControl1.DataSource = _hdld.Search("MA_HD", textBoxSearch.Text.Trim());
                    }
                    else
                    {
                        gridControl1.DataSource = _hdld.Search("MA_NV", textBoxSearch.Text.Trim());
                    }
                }
            }
        }
        void Reset()
        {
            textBoxSearch.Text = string.Empty;
            showHide(false);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            spinEdit1.Text = "1";
            comboBox1.SelectedIndex = 0;
            splitContainer1.Panel1Collapsed = true;
            LoadData();
            LoadNhanVien2();
            Them = true;
            label1.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label9.Text = string.Empty;
            searchLookUpEdit1.EditValue = null;
            searchLookUpEdit1.Enabled = true;
            richEditControl1.Text = string.Empty;
        }

        private void LoadData()
        {
            gridControl1.DataSource = _hdld.GetHopDongLaoDongs();
            gridView1.OptionsBehavior.Editable = false;
            comboBoxSearch.SelectedIndex = 0;
        }
       
        private void LoadNhanVien()
        {
            searchLookUpEdit1.Properties.DataSource = _nv.GetNhanViens();
            searchLookUpEdit1.Properties.ValueMember = "MA_NV";
            searchLookUpEdit1.Properties.DisplayMember = "Ho_Ten";
        }

        private void LoadNhanVien2()
        {
            searchLookUpEdit1.Properties.DataSource = _hdld.GetNhanViens();
            searchLookUpEdit1.Properties.ValueMember = "MA_NV";
            searchLookUpEdit1.Properties.DisplayMember = "Ho_Ten";
        }
        void showHide(bool kt)
        {
            btnThem.Enabled = !kt;
            btnSua.Enabled = !kt;
            btnXoa.Enabled = !kt;
            btnLuu.Enabled = kt;
            btnHuy.Enabled = kt;
            splitContainer1.Panel2.Enabled = !kt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            label3.ForeColor = Color.Black;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Them = false;
            if (gridView1.RowCount > 0)
            {
                MA_HD = gridView1.GetFocusedRowCellValue("MA_HD").ToString();
                var hdld = _hdld.GetHopDongLaoDong(MA_HD);
                comboBox1.Text = hdld.LOAI_HD;
                if (hdld.LOAI_HD == "Có thời hạn")
                {
                    dateTimePicker1.Value = hdld.NGAY_BD.Value;
                    dateTimePicker2.Value = hdld.NGAY_KT.Value;
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
                dateTimePicker3.Value = hdld.NGAY_KY;
                spinEdit1.Text = hdld.LAN_KY.ToString();
                searchLookUpEdit1.EditValue = hdld.MA_NV;
                richEditControl1.HtmlText = hdld.NOI_DUNG;
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label9.Text = string.Empty;
        }
    }
}
