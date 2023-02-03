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
using BL;

namespace WindowsFormsApp1
{
    public partial class FormTKNV : DevExpress.XtraEditors.XtraForm
    {
        THONGKE _tk = new THONGKE();
        public FormTKNV()
        {
            InitializeComponent();
        }

        private void FormTKNV_Load(object sender, EventArgs e)
        {
            Series s = new Series("Thống kê nhân viên theo phòng ban", ViewType.Pie);
            var ls = _tk.GetThongkes();
            foreach (var item in ls)
            {
                s.Points.Add(new SeriesPoint(item.Name,item.Count));
            }
            chartControl1.Series.Add(s);
            s.Label.TextPattern = "{A} : {VP : p0}";


            Series s2 = new Series("Thống kê nhân viên theo chức vụ", ViewType.Bar);
            var ls2 = _tk.GetThongkes2();
            foreach (var item in ls2)
            {
                s2.Points.Add(new SeriesPoint(item.Name, item.Count));
            }
            chartControl2.Series.Add(s2);
            s2.Label.TextPattern = "{A} : {VP : p0}";

        }
    }
}