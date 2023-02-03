using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLyNhanSuVaKH
{
    public partial class FormChamCong : Form
    {
        string ConnectionString = Properties.Settings.Default.ConectionString;
        public FormChamCong()
        {
            InitializeComponent();
           
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                if (comboBoxThang.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa chọn tháng", "Thông báo");
                }
                else
                {
                    if (textBoxNam.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập năm", "Thông báo");
                    }
                    else
                    {
                        KiemTra(comboBoxThang.Text, textBoxNam.Text);
                        dataGridView1.Rows.Clear();
                        HienThiDanhSach();
                        labelThang.Text = comboBoxThang.SelectedItem.ToString();
                        labelNam.Text = textBoxNam.Text;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi xảy ra "+ex.Message,"Thông báo");
            }
           
        }

        private void Reset()
        {
            
            dataGridView1.Columns["Column31"].Visible = true;
            dataGridView1.Columns["Column30"].Visible = true;
            dataGridView1.Columns["Column29"].Visible = true;
            dataGridView1.Columns["Column28"].Visible = true;
        }

        private void KiemTra(string text1, string text2)
        {
            Int32.TryParse(text1, out int num);
            switch (num)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    dataGridView1.Columns["Column31"].Visible = false;
                    break;
                case 2:
                    if (laNamNhuan(text2))
                    {
                        dataGridView1.Columns["Column31"].Visible = false;
                        dataGridView1.Columns["Column30"].Visible = false;
                    }
                    else
                    {
                        dataGridView1.Columns["Column31"].Visible = false;
                        dataGridView1.Columns["Column30"].Visible = false;
                        dataGridView1.Columns["Column29"].Visible = false;
                    }
                    break;
            }

        }

        private bool laNamNhuan(string text2)
        {
            Int32.TryParse(text2, out int nYear);
            if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
            {
                return true;
            }
            return false;
        }

        private void HienThiDanhSach()
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string query = "select Ma_NhanVien, Ho_ten from dbo.NhanVien";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
               
                string Ma = reader.GetString(0);
                string Ten = reader.GetString(1);
                string MaCC = "0"+comboBoxThang.Text+textBoxNam.Text+Ma ;

                dataGridView1.Rows.Add("",MaCC,Ma,Ten);
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
               xlWorkSheet.Cells[1, i + 1] = dataGridView1.Columns[i - 1].HeaderText;
            }
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[2, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        
    }
}
