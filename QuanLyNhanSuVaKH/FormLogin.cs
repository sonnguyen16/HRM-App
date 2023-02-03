using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QuanLyNhanSuVaKH
{
    public partial class FormLogin : Form
    {
        string ConectionString = Properties.Settings.Default.ConectionString;
        string Loai_Tk = "0";
        public string Tk = null;


        public FormLogin()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

           
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxTk.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxTk.Focus();
                    return;
                }

                if (textBoxMk.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMk.Focus();
                    return;
                }
                SqlConnection conn = new SqlConnection(ConectionString);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TaiKhoan = textBoxTk.Text.Trim();
                string MatKhau = textBoxMk.Text.Trim();
                string query = "select * from TaiKhoan where Ten_TK = '" + TaiKhoan + "' and Mat_Khau= '" + MatKhau + "' ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Loai_Tk = ds.Tables[0].Rows[0]["Loai_Tk"].ToString();
                    Tk = ds.Tables[0].Rows[0]["Ten_TK"].ToString();
                    FormUI fm = new FormUI(Loai_Tk,Tk);
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
