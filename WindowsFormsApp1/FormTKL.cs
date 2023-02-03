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
using DevExpress.XtraCharts;
using DAL;
using BL;

namespace WindowsFormsApp1
{
    public partial class FormTKL : DevExpress.XtraEditors.XtraForm
    {
        THONGKE _tk = new THONGKE();
        BANGCHAMCONG _bcc = new BANGCHAMCONG()
;        public FormTKL()
        {
            InitializeComponent();
            searchLookUpEdit1.Properties.DataSource = _bcc.getBL3();
            searchLookUpEdit1.Properties.DisplayMember = "Nam";
            searchLookUpEdit1.Properties.ValueMember = "Nam";
        }

        private void FormTKL_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn năm");
            }
            else
            {
                chartControl1.Series.Clear();
                Series s = new Series("Thống kê lương", ViewType.Bar);
                int n;
                int.TryParse(searchLookUpEdit1.EditValue.ToString(), out n);

                var ls = _tk.GetThongkesLuong(1, 12, n);
                foreach (var item in ls)
                {
                    s.Points.Add(new SeriesPoint("Tháng " + item.ID + " Năm " + item.Name, item.Count));
                }
                chartControl1.Series.Add(s);
                s.Label.TextPattern = "{A} : {VP : p0}";
            }
           
        }
    }
}