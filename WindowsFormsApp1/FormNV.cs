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
using System.Data.SqlClient;
using BL;
using DAL;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormNV : DevExpress.XtraEditors.XtraForm
    {
        NHANVIEN _nv = new NHANVIEN();
        bool Them = true;
        string MA_NV;
        int i;
       
        public FormNV()
        {
            InitializeComponent();
            Reset();
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
            showHide(true);
            splitContainer1.Panel1Collapsed = false;
            Them = true;
            pictureBox1.ImageLocation = @"C:\Users\USER\Downloads\SourceImage\noim.png";

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
                            _nv.Delete(MA_NV);
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
                    splitContainer1.Panel1Collapsed = false;
                    Them = false;
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
                    if (comboBoxSearch.Text.Trim() == "Mã nhân viên")
                    {
                        gridControl1.DataSource = _nv.Search("MA_NV", textBoxSearch.Text.Trim());
                    }
                    else
                    {
                        gridControl1.DataSource = _nv.Search("Ho_Ten", textBoxSearch.Text.Trim());
                    }
                }
            }
        }

       
        void Reset()
        {
            textBoxHt.Text = string.Empty;
            textBoxDc.Text = string.Empty;
            textBoxDt.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxScccd.Text = string.Empty;
            textBoxSdt.Text = string.Empty;
            textBoxSearch.Text = string.Empty;
            labelHt.ForeColor = Color.Black;
            labelDc.ForeColor = Color.Black;
            labelDt.ForeColor = Color.Black;
            labelScccd.ForeColor = Color.Black;
            labelSdt.ForeColor = Color.Black;
            labelEmail.ForeColor = Color.Black;
            radioButton1.Checked = true;
            splitContainer1.Panel1Collapsed = true;
            dateTimePicker1.Value = DateTime.Now;
            Them = true;
            labelLoi.Text = string.Empty;
            showHide(false);
            LoadData();
            LoadCombo();
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

        void LoadData()
        {
            gridControl1.DataSource = _nv.GetNhanViens();
        }

        void SaveData()
        {
            if (Them)
            {
                i = gridView1.RowCount;
                NhanVien nv = new NhanVien();
                nv.Hinh_Anh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.MA_NV = "NV" + (i+1).ToString();
                nv.Ho_Ten = textBoxHt.Text;
                nv.Ngay_Sinh = dateTimePicker1.Value;
                if (radioButton1.Checked)
                {
                    nv.Gioi_Tinh = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    nv.Gioi_Tinh = radioButton2.Text;
                }
                nv.Dia_Chi = textBoxDc.Text;
                nv.Dan_Toc = textBoxDt.Text;
                nv.So_CCCD = textBoxScccd.Text;
                nv.So_Dt = textBoxSdt.Text;
                nv.Email = textBoxEmail.Text;
                nv.Hon_Nhan = comboBox1.SelectedItem.ToString();
                nv.MA_CV = comboBoxCv.SelectedValue.ToString();
                nv.MA_PB = comboBoxPb.SelectedValue.ToString();

                _nv.Add(nv);
                Reset();
            }
            else
            {
                var nv = _nv.GetNhanVien(MA_NV);
                nv.Hinh_Anh = ImageToBase64(pictureBox1.Image, pictureBox1.Image.RawFormat);
                nv.Ho_Ten = textBoxHt.Text;
                nv.Ngay_Sinh = dateTimePicker1.Value;
                if (radioButton1.Checked)
                {
                    nv.Gioi_Tinh = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    nv.Gioi_Tinh = radioButton2.Text;
                }
                nv.Dia_Chi = textBoxDc.Text;
                nv.Dan_Toc = textBoxDt.Text;
                nv.So_CCCD = textBoxScccd.Text;
                nv.So_Dt = textBoxSdt.Text;
                nv.Email = textBoxEmail.Text;
                nv.Hon_Nhan = comboBox1.SelectedItem.ToString();
                nv.MA_CV = comboBoxCv.SelectedValue.ToString();
                nv.MA_PB = comboBoxPb.SelectedValue.ToString();

                _nv.Update(nv);
                Reset();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Them = false;
            if (gridView1.RowCount > 0)
            {
                MA_NV = gridView1.GetFocusedRowCellValue("MA_NV").ToString();
                var nv = _nv.GetNhanVien(MA_NV);
                pictureBox1.Image = Base64ToImage(nv.Hinh_Anh);
                textBoxHt.Text = nv.Ho_Ten;
                dateTimePicker1.Value = nv.Ngay_Sinh;
                if (nv.Gioi_Tinh == "Nam")
                {
                    radioButton1.Checked = true;
                }
                if (nv.Gioi_Tinh == "Nữ")
                {
                    radioButton2.Checked = true;
                }
                textBoxDc.Text = nv.Dia_Chi;
                textBoxDt.Text = nv.Dan_Toc;
                textBoxScccd.Text = nv.So_CCCD;
                textBoxSdt.Text = nv.So_Dt;
                textBoxEmail.Text = nv.Email;
                comboBox1.SelectedValue = nv.Hon_Nhan;
                comboBoxCv.SelectedValue = nv.MA_CV;
                comboBoxPb.SelectedValue = nv.MA_PB;
            }
        }

        bool KiemTraNhap()
        {
            if (textBoxHt.Text.Trim() == string.Empty)
            {
                labelLoi.Text = "Bạn chưa nhập họ tên";
                labelHt.ForeColor = Color.Red;
                textBoxHt.Focus();
                return false;
            }
            if (textBoxDc.Text.Trim() == string.Empty)
            {

                labelLoi.Text = "Bạn chưa nhập địa chỉ";
                labelDc.ForeColor = Color.Red;
                textBoxDc.Focus();
                return false;
            }
            if (textBoxDt.Text.Trim() == string.Empty)
            {

                labelLoi.Text = "Bạn chưa nhập dân tộc";
                labelDt.ForeColor = Color.Red;
                textBoxDt.Focus();
                return false;
            }
            if (textBoxScccd.Text.Trim() == string.Empty)
            {

                labelLoi.Text = "Bạn chưa nhập số căn cước công dân";
                labelScccd.ForeColor = Color.Red;
                textBoxScccd.Focus();
                return false;
            }
            if (textBoxSdt.Text.Trim() == string.Empty)
            {

                labelLoi.Text = "Bạn chưa nhập số điện thoại";
                labelSdt.ForeColor = Color.Red;
                textBoxSdt.Focus();
                return false;
            }
            if (textBoxEmail.Text.Trim() == string.Empty)
            {

                labelLoi.Text = "Bạn chưa nhập email";
                labelEmail.ForeColor = Color.Red;
                textBoxEmail.Focus();
                return false;
            }
            if (textBoxScccd.TextLength > 12 )
            {
                labelLoi.Text = "Số căn cước không hợp lệ";
                labelScccd.ForeColor = Color.Red;
                textBoxScccd.Focus();
                return false;
            }
            if (textBoxSdt.TextLength != 10)
            {
                labelLoi.Text = "Số điện thoại không hợp lệ";
                labelSdt.ForeColor = Color.Red;
                textBoxSdt.Focus();
                return false;
            }
            int i;
            bool kt = int.TryParse(textBoxSdt.Text.Trim(),out i);
            if (!kt)
            {
                labelLoi.Text = "Số điện thoại không hợp lệ";
                labelSdt.ForeColor = Color.Red;
                textBoxSdt.Focus();
                return false;
            }
            bool kt2 = int.TryParse(textBoxScccd.Text.Trim(), out i);
            if (!kt2)
            {
                labelLoi.Text = "Số căn cước không hợp lệ";
                labelScccd.ForeColor = Color.Red;
                textBoxScccd.Focus();
                return false;
            }
            return true;
        }
        public byte[] ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        void LoadCombo()
        {
            PHONGBAN _pb = new PHONGBAN();
            comboBoxPb.DataSource = _pb.GetPhongBans();
            comboBoxPb.DisplayMember = "TEN_PB";
            comboBoxPb.ValueMember = "MA_PB";

            CHUCVU _cv = new CHUCVU();
            comboBoxCv.DataSource = _cv.GetChucVus();
            comboBoxCv.DisplayMember = "TEN_CV";
            comboBoxCv.ValueMember = "MA_CV";

            comboBoxSearch.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }


        private void textBoxHt_Click(object sender, EventArgs e)
        {
            labelHt.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        private void textBoxDc_Click(object sender, EventArgs e)
        {
            labelDc.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        private void textBoxDt_Click(object sender, EventArgs e)
        {
            labelDt.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        private void textBoxScccd_Click(object sender, EventArgs e)
        {
            labelScccd.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        private void textBoxSdt_Click(object sender, EventArgs e)
        {
            labelSdt.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            labelEmail.ForeColor = Color.Black;
            labelLoi.Text = string.Empty;
        }

        
    }
}