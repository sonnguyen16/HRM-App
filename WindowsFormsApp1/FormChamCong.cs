using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using BL;
using DAL;


namespace WindowsFormsApp1
{
    public partial class FormChamCong : Form
    {
        QuanLyNhanSuEntities2 et = new QuanLyNhanSuEntities2();
        bool Them = false;
        BANGCHAMCONG _bcc = new BANGCHAMCONG();
        CHITIETCC _cccc = new CHITIETCC();
        SqlConnection con;
        SqlCommandBuilder cmd;
        SqlDataAdapter adap;
        DataSet ds;


        public FormChamCong()
        {
            InitializeComponent();
            Reset();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Enabled = false;
        }

       
        private void Reset()
        {
            splitContainer1.Panel1Collapsed = true;
            showHide(false);
            label1.Text = string.Empty;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            LoadBCC();
            d31DataGridViewTextBoxColumn.Visible = true;
            d30DataGridViewTextBoxColumn.Visible = true;
            d29DataGridViewTextBoxColumn.Visible = true;
            textBoxNam.Text = string.Empty;
            comboBoxThang.Text = string.Empty;
            Them = false;
        }

        private void KiemTra(int num, int text2)
        {
            
            switch (num)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    d31DataGridViewTextBoxColumn.Visible = false;
                    break;
                case 2:
                    if (laNamNhuan(text2))
                    {
                        d31DataGridViewTextBoxColumn.Visible = false;
                        d30DataGridViewTextBoxColumn.Visible = false;
                    }
                    else
                    {
                        d31DataGridViewTextBoxColumn.Visible = false;
                        d30DataGridViewTextBoxColumn.Visible = false;
                        d29DataGridViewTextBoxColumn.Visible = false;
                    }
                    break;
            }

        }

        bool KiemTraTonTai()
        {
            List<BangChamCong> ls = _bcc.GetBangChamCongs();
            foreach (BangChamCong bcc in ls)
            {
                if (comboBoxThang.Text == bcc.Thang.ToString() && textBoxNam.Text.Trim() == bcc.Nam.ToString())
                {
                    label1.Text = "Bảng chấm công với tháng và năm này đã tồn tại !";
                    return false;
                }
            }
            return true;
        }
        bool KiemTraNhap()
        {
            if (comboBoxThang.Text.Trim() == string.Empty)
            {
                label1.Text = "Bạn chưa chọn tháng";
                label2.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNam.Text.Trim() == string.Empty)
            {
                label1.Text = "Bạn chưa nhập năm";
                label3.ForeColor = Color.Red;
                return false;
            }
            int i;
            bool kt = int.TryParse(textBoxNam.Text, out i);
            if (!kt)
            {
                label1.Text = "Năm không hợp lệ";
                label3.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        void SaveData()
        {
            if (Them)
            {
                if (KiemTraNhap() && KiemTraTonTai())
                {
                    BangChamCong bcc = new BangChamCong();
                    bcc.MA_CC = "BCC" + comboBoxThang.Text + textBoxNam.Text;
                    bcc.Thang = int.Parse(comboBoxThang.Text);
                    bcc.Nam = int.Parse(textBoxNam.Text);
                    _bcc.Add(bcc);

                    NHANVIEN _nv = new NHANVIEN();
                    List<NhanVien> ls = _nv.GetNhanViens();

                    foreach (NhanVien nv in ls)
                    {
                        ChiTietChamCong cccc = new ChiTietChamCong();
                        cccc.MA_CC = bcc.MA_CC;
                        cccc.MA_NV = nv.MA_NV;
                        _cccc.Add(cccc);
                    }
                    MessageBox.Show("Thêm thành công");
                    Reset();
                    searchLookUpEdit1.Text = bcc.MA_CC;
                    LoadData();
                    checkBox1.Checked = false;
                  
                }
                
            }
            else
            {
                try
                {
                    dataGridView1.EndEdit();
                    cmd = new SqlCommandBuilder(adap);
                    adap.Update(ds, "ChiTietChamCong");
                    MessageBox.Show("Lưu thành công ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Có lỗi xảy ra "+ ex.Message,"Lỗi");
                }
              
                
            }
           
        }

        void LoadData()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.ConnectionString;
            con.Open();

            adap = new SqlDataAdapter("select * from ChiTietChamCong where MA_CC = '" + searchLookUpEdit1.Text + "'", con);
            ds = new DataSet();
            adap.Fill(ds, "ChiTietChamCong");
            dataGridView1.DataSource = ds.Tables[0];

        }
        void LoadBCC()
        {
            searchLookUpEdit1.Properties.DataSource = _bcc.GetBangChamCongs();
            searchLookUpEdit1.Properties.DisplayMember = "MA_CC";
            searchLookUpEdit1.Properties.ValueMember = "MA_CC";

        }
        private bool laNamNhuan(int nYear)
        {
            
            if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
            {
                return true;
            }
            return false;
        }

        void showHide(bool kt)
        {
            buttonThem.Enabled = !kt;
            buttonHuy.Enabled = kt;
            splitContainer1.Panel2.Enabled = !kt;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            splitContainer1.Panel1Collapsed = false;
            Them = true;
        }

        private void buttonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               SaveData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi xảy ra :"+ex,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBoxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.ForeColor = Color.Black;
        }

        private void textBoxNam_TextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label3.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null)
            {
                label1.Text = "Bạn chưa chọn bảng chấm công";
            }
            else
            {
                Reset();
                BangChamCong bcc = _bcc.GetBangChamCong(searchLookUpEdit1.Text);
                if (bcc.Tinh_Trang == true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                KiemTra(bcc.Thang,bcc.Nam);
                LoadData();
            }
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.ChiTietChamCong' table. You can move, or remove it, as needed.
            //this.chiTietChamCongTableAdapter.Fill(this.quanLyNhanSuDataSet.ChiTietChamCong);
            
        }
     
        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                dataGridView1.Enabled = true;
            }
            else
            {
                dataGridView1.Enabled = false;
            }
            
        }

      

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double Tong_Cong = 0;
                int So_NN = 0;
                
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString() == "x")
                    {
                        Tong_Cong++;
                    }
                    if (row.Cells[i].Value.ToString() == "x/2")
                    {
                        Tong_Cong += 0.5;
                    }
                    if (row.Cells[i].Value.ToString() == "p" || row.Cells[i].Value.ToString() == "kp")
                    {
                        So_NN++;
                    }
                }
                row.Cells[dataGridView1.Columns.Count - 2].Value = Tong_Cong;
                row.Cells[dataGridView1.Columns.Count - 1].Value = So_NN;
            }
        }

        private void buttonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            showHide(false);
            label1.Text = string.Empty;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            LoadBCC();
            Them = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null)
            {
                checkBox1.Checked = false;
                MessageBox.Show("Bạn chưa chọn bảng chấm công");
            }
            else
            {
                BangChamCong bcc = _bcc.GetBangChamCong(searchLookUpEdit1.Text);
                if (checkBox1.Checked == true)
                {
                    bcc.Tinh_Trang = true;
                }
                else
                {
                    bcc.Tinh_Trang = false;
                }
                _bcc.Update(bcc);
            }
        }
    }
}
