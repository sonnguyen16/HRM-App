using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace QuanLyNhanSuVaKH
{
    public partial class FormUI : Form
    {
        string ConnectionString = Properties.Settings.Default.ConectionString;
        string a = null;
        string b = null;
        frmChucvu frm = null;
        public FormUI(string Loai_Tk,string Tk)
        {
            InitializeComponent();
            LoadForm();
            if (Loai_Tk == "1")
            {
                buttonuv.Enabled = false;
                buttontl.Enabled = false;
                buttoncc.Enabled = false;
                buttondstk.Enabled = false;
            }
            if (Loai_Tk == "2")
            {
                buttonnv.Enabled = false;
                buttontl.Enabled = false;
                buttoncc.Enabled = false;
                buttondstk.Enabled = false;
            }
            if (Loai_Tk == "3")
            {
                buttonnv.Enabled = false;
                buttonuv.Enabled = false;
                buttoncc.Enabled = false;
                buttondstk.Enabled = false;
            }
            if (Loai_Tk == "4")
            {
                buttondstk.Enabled = false;
            }
           
            a = Tk;
            b = Loai_Tk;
        }

        private void LoadForm()
        {
            panelnv.Visible = false;
            panelht.Visible = false;
            panelcc.Visible = false;
            paneltl.Visible = false;
            paneluv.Visible = false;

            panelnv.BringToFront();
            panelcc.BringToFront();
            paneluv.BringToFront();
            paneltl.BringToFront();
            panelht.BringToFront();
        }

        private void movepanel(Control btn)
        {
            panel2.Width = btn.Width;
            panel2.Left = btn.Left;
        }
        private void showPanel(Panel pn)
        {
            if (pn.Visible == false)
            {
                hidePanel();
                pn.Visible = true;
            }
            else pn.Visible = false;
        }
        private void hidePanel()
        {
            if (panelnv.Visible == true)
            {
                panelnv.Visible = false;
            }
            if (paneltl.Visible)
            {
                paneltl.Visible = false;
            }
            if (panelht.Visible == true)
            {
                panelht.Visible = false;
            }
            if (paneluv.Visible == true)
            {
                paneluv.Visible = false;
            }
            if (panelcc.Visible == true)
            {
                panelcc.Visible = false;
            }
        }
        private void buttonnv_Click(object sender, EventArgs e)
        {
            movepanel(panelnv);
            showPanel(panelnv);
        }

        private void buttonuv_Click(object sender, EventArgs e)
        {
            movepanel(paneluv);
            showPanel(paneluv);
        }

        private void buttontl_Click(object sender, EventArgs e)
        {
            movepanel(paneltl);
            showPanel(paneltl);
        }

        private void buttoncc_Click(object sender, EventArgs e)
        {
            movepanel(panelcc);
            showPanel(panelcc);
        }

        private void buttonht_Click(object sender, EventArgs e)
        {
            movepanel(panelht);
            showPanel(panelht);
        }

        private void buttondspb_Click(object sender, EventArgs e)
        {
           
            openChildForm(new frmPhongBan());
            hidePanel();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            panel4.Controls.Add(childForm);
            childForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChucvu());
            hidePanel();
        }

        private void buttondsnv_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNhanVien());
            hidePanel();
        }

        private void buttonbcc_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChamCong());
            hidePanel();
        }

        private void buttondx_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.Show();

        }

        private void buttondmk_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDmk(a));
            hidePanel();
        }
    }
}
