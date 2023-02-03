
namespace WindowsFormsApp1
{
    partial class frmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.listViewPb = new System.Windows.Forms.ListView();
            this.Ma_Phong_Ban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten_Phong_Ban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ghi_Chu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMpb = new System.Windows.Forms.Label();
            this.labelGc = new System.Windows.Forms.Label();
            this.labelTpb = new System.Windows.Forms.Label();
            this.textBoxMpb = new System.Windows.Forms.TextBox();
            this.textBoxTpb = new System.Windows.Forms.TextBox();
            this.textBoxGc = new System.Windows.Forms.TextBox();
            this.comboBoxTimkiem = new System.Windows.Forms.ComboBox();
            this.textBoxTimkiem = new System.Windows.Forms.TextBox();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPb
            // 
            this.listViewPb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma_Phong_Ban,
            this.Ten_Phong_Ban,
            this.Ghi_Chu});
            this.listViewPb.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPb.GridLines = true;
            this.listViewPb.HideSelection = false;
            this.listViewPb.Location = new System.Drawing.Point(47, 71);
            this.listViewPb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPb.Name = "listViewPb";
            this.listViewPb.Size = new System.Drawing.Size(632, 213);
            this.listViewPb.TabIndex = 0;
            this.listViewPb.UseCompatibleStateImageBehavior = false;
            this.listViewPb.View = System.Windows.Forms.View.Details;
            this.listViewPb.SelectedIndexChanged += new System.EventHandler(this.listViewPb_SelectedIndexChanged);
            // 
            // Ma_Phong_Ban
            // 
            this.Ma_Phong_Ban.Text = "Mã Phòng Ban";
            this.Ma_Phong_Ban.Width = 120;
            // 
            // Ten_Phong_Ban
            // 
            this.Ten_Phong_Ban.Text = "Tên Phòng Ban";
            this.Ten_Phong_Ban.Width = 170;
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.Text = "Ghi chú";
            this.Ghi_Chu.Width = 330;
            // 
            // labelMpb
            // 
            this.labelMpb.AutoSize = true;
            this.labelMpb.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelMpb.Location = new System.Drawing.Point(65, 26);
            this.labelMpb.Name = "labelMpb";
            this.labelMpb.Size = new System.Drawing.Size(136, 25);
            this.labelMpb.TabIndex = 0;
            this.labelMpb.Text = "Mã Phòng Ban";
            // 
            // labelGc
            // 
            this.labelGc.AutoSize = true;
            this.labelGc.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelGc.Location = new System.Drawing.Point(65, 132);
            this.labelGc.Name = "labelGc";
            this.labelGc.Size = new System.Drawing.Size(77, 25);
            this.labelGc.TabIndex = 1;
            this.labelGc.Text = "Ghi chú";
            // 
            // labelTpb
            // 
            this.labelTpb.AutoSize = true;
            this.labelTpb.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelTpb.Location = new System.Drawing.Point(65, 79);
            this.labelTpb.Name = "labelTpb";
            this.labelTpb.Size = new System.Drawing.Size(138, 25);
            this.labelTpb.TabIndex = 2;
            this.labelTpb.Text = "Tên Phòng Ban";
            // 
            // textBoxMpb
            // 
            this.textBoxMpb.Location = new System.Drawing.Point(207, 31);
            this.textBoxMpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMpb.Name = "textBoxMpb";
            this.textBoxMpb.Size = new System.Drawing.Size(217, 22);
            this.textBoxMpb.TabIndex = 3;
            // 
            // textBoxTpb
            // 
            this.textBoxTpb.Location = new System.Drawing.Point(207, 83);
            this.textBoxTpb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTpb.Name = "textBoxTpb";
            this.textBoxTpb.Size = new System.Drawing.Size(217, 22);
            this.textBoxTpb.TabIndex = 4;
            // 
            // textBoxGc
            // 
            this.textBoxGc.Location = new System.Drawing.Point(207, 136);
            this.textBoxGc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGc.Name = "textBoxGc";
            this.textBoxGc.Size = new System.Drawing.Size(217, 22);
            this.textBoxGc.TabIndex = 5;
            // 
            // comboBoxTimkiem
            // 
            this.comboBoxTimkiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTimkiem.FormattingEnabled = true;
            this.comboBoxTimkiem.Items.AddRange(new object[] {
            "1. Mã phòng ban",
            "2. Tên phòng ban"});
            this.comboBoxTimkiem.Location = new System.Drawing.Point(47, 31);
            this.comboBoxTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTimkiem.Name = "comboBoxTimkiem";
            this.comboBoxTimkiem.Size = new System.Drawing.Size(142, 27);
            this.comboBoxTimkiem.TabIndex = 2;
            // 
            // textBoxTimkiem
            // 
            this.textBoxTimkiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimkiem.Location = new System.Drawing.Point(194, 31);
            this.textBoxTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimkiem.Name = "textBoxTimkiem";
            this.textBoxTimkiem.Size = new System.Drawing.Size(150, 27);
            this.textBoxTimkiem.TabIndex = 3;
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimkiem.Location = new System.Drawing.Point(359, 31);
            this.buttonTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(90, 27);
            this.buttonTimkiem.TabIndex = 4;
            this.buttonTimkiem.Text = "Tìm kiếm";
            this.buttonTimkiem.UseVisualStyleBackColor = true;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm theo :";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnLammoi,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(306, 223);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLammoi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Caption = "Làm mới";
            this.btnLammoi.Id = 5;
            this.btnLammoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLammoi.ImageOptions.SvgImage")));
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLammoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1040, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1040, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1040, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTpb);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxMpb);
            this.splitContainer1.Panel1.Controls.Add(this.labelMpb);
            this.splitContainer1.Panel1.Controls.Add(this.labelTpb);
            this.splitContainer1.Panel1.Controls.Add(this.labelGc);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxGc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.listViewPb);
            this.splitContainer1.Panel2.Controls.Add(this.buttonTimkiem);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTimkiem);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTimkiem);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 483);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 10;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Phòng Ban";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewPb;
        private System.Windows.Forms.ColumnHeader Ma_Phong_Ban;
        private System.Windows.Forms.ColumnHeader Ten_Phong_Ban;
        private System.Windows.Forms.ColumnHeader Ghi_Chu;
        private System.Windows.Forms.Label labelMpb;
        private System.Windows.Forms.Label labelGc;
        private System.Windows.Forms.Label labelTpb;
        private System.Windows.Forms.TextBox textBoxMpb;
        private System.Windows.Forms.TextBox textBoxTpb;
        private System.Windows.Forms.TextBox textBoxGc;
        private System.Windows.Forms.ComboBox comboBoxTimkiem;
        private System.Windows.Forms.TextBox textBoxTimkiem;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLammoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}