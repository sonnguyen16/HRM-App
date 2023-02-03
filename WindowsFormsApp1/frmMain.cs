using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApp1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int Loai_Tk = -1;
        string Tk = null;
        public frmMain(int Loai_Tk,string Tk)
        {
            InitializeComponent();
            this.Loai_Tk = Loai_Tk;
            this.Tk = Tk;
            if (Loai_Tk == 1)
            {
                ribbonQLUV.Visible = false;
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                btnCNTTTK.Enabled = false;
            }
            if (Loai_Tk == 2)
            {
                ribbonQLNV.Visible = false;
                ribbonQLUV.Visible = false;
                ribbonPage2.Visible = false;
                btnCNTTTK.Enabled = false;
            }
            if (Loai_Tk == 3)
            {
                ribbonQLNV.Visible = false;
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                btnCNTTTK.Enabled = false;
            }
        }

        void openForm (Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void btnCNTTPB_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnCNTTCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmChucvu));
        }

        private void btnDX_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnDMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeof(FormDmk))
                {
                    frm.Activate();
                    return;
                }
            }

            FormDmk f = new FormDmk(this.Tk);
            f.MdiParent = this;
            f.Show();
        }

        private void btnCNTTNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormNV));
        }

        private void btnCNTTHDLD_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(formHDLD));
        }

        private void btnTKNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormTKNV));
        }

        private void btnCNTTBCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormChamCong));
        }

        private void btnLBL_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(formBangLuong));
        }

        private void btnTKL_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormTKL));
        }
    }
}