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
    public partial class FormNhanVien : Form
    {
        string ConectionString = Properties.Settings.Default.ConectionString;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            SqlConnection conn = new SqlConnection(ConectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from NhanVien";
            SqlDataAdapter ad = new SqlDataAdapter(query,conn);

            DataSet ds = new DataSet();

            ad.Fill(ds, "NhanVien");

            dataGridView1.DataSource = ds.Tables["NhanVien"];
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
