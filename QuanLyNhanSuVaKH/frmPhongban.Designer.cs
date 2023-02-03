
namespace QuanLyNhanSuVaKH
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
            this.listViewPb = new System.Windows.Forms.ListView();
            this.Ma_Phong_Ban = new System.Windows.Forms.ColumnHeader();
            this.Ten_Phong_Ban = new System.Windows.Forms.ColumnHeader();
            this.Ghi_Chu = new System.Windows.Forms.ColumnHeader();
            this.labelMpb = new System.Windows.Forms.Label();
            this.labelGc = new System.Windows.Forms.Label();
            this.labelTpb = new System.Windows.Forms.Label();
            this.textBoxMpb = new System.Windows.Forms.TextBox();
            this.textBoxTpb = new System.Windows.Forms.TextBox();
            this.textBoxGc = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.comboBoxTimkiem = new System.Windows.Forms.ComboBox();
            this.textBoxTimkiem = new System.Windows.Forms.TextBox();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.listViewPb.GridLines = true;
            this.listViewPb.HideSelection = false;
            this.listViewPb.Location = new System.Drawing.Point(533, 110);
            this.listViewPb.Name = "listViewPb";
            this.listViewPb.Size = new System.Drawing.Size(626, 420);
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
            this.Ghi_Chu.Width = 250;
            // 
            // labelMpb
            // 
            this.labelMpb.AutoSize = true;
            this.labelMpb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMpb.Location = new System.Drawing.Point(22, 63);
            this.labelMpb.Name = "labelMpb";
            this.labelMpb.Size = new System.Drawing.Size(128, 25);
            this.labelMpb.TabIndex = 0;
            this.labelMpb.Text = "Mã Phòng Ban";
            // 
            // labelGc
            // 
            this.labelGc.AutoSize = true;
            this.labelGc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGc.Location = new System.Drawing.Point(22, 213);
            this.labelGc.Name = "labelGc";
            this.labelGc.Size = new System.Drawing.Size(71, 25);
            this.labelGc.TabIndex = 1;
            this.labelGc.Text = "Ghi chú";
            // 
            // labelTpb
            // 
            this.labelTpb.AutoSize = true;
            this.labelTpb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTpb.Location = new System.Drawing.Point(22, 138);
            this.labelTpb.Name = "labelTpb";
            this.labelTpb.Size = new System.Drawing.Size(129, 25);
            this.labelTpb.TabIndex = 2;
            this.labelTpb.Text = "Tên Phòng Ban";
            // 
            // textBoxMpb
            // 
            this.textBoxMpb.Location = new System.Drawing.Point(171, 61);
            this.textBoxMpb.Name = "textBoxMpb";
            this.textBoxMpb.Size = new System.Drawing.Size(247, 30);
            this.textBoxMpb.TabIndex = 3;
            // 
            // textBoxTpb
            // 
            this.textBoxTpb.Location = new System.Drawing.Point(171, 136);
            this.textBoxTpb.Name = "textBoxTpb";
            this.textBoxTpb.Size = new System.Drawing.Size(247, 30);
            this.textBoxTpb.TabIndex = 4;
            // 
            // textBoxGc
            // 
            this.textBoxGc.Location = new System.Drawing.Point(171, 211);
            this.textBoxGc.Name = "textBoxGc";
            this.textBoxGc.Size = new System.Drawing.Size(247, 30);
            this.textBoxGc.TabIndex = 5;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(56, 283);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(94, 29);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(194, 283);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(94, 29);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonHuy);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.textBoxGc);
            this.groupBox1.Controls.Add(this.textBoxTpb);
            this.groupBox1.Controls.Add(this.textBoxMpb);
            this.groupBox1.Controls.Add(this.labelTpb);
            this.groupBox1.Controls.Add(this.labelGc);
            this.groupBox1.Controls.Add(this.labelMpb);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(40, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin phòng ban";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(323, 283);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(94, 29);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(194, 342);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(94, 29);
            this.buttonHuy.TabIndex = 10;
            this.buttonHuy.Text = "Làm mới";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // comboBoxTimkiem
            // 
            this.comboBoxTimkiem.FormattingEnabled = true;
            this.comboBoxTimkiem.Items.AddRange(new object[] {
            "1. Mã phòng ban",
            "2. Tên phòng ban"});
            this.comboBoxTimkiem.Location = new System.Drawing.Point(533, 62);
            this.comboBoxTimkiem.Name = "comboBoxTimkiem";
            this.comboBoxTimkiem.Size = new System.Drawing.Size(162, 28);
            this.comboBoxTimkiem.TabIndex = 2;
            // 
            // textBoxTimkiem
            // 
            this.textBoxTimkiem.Location = new System.Drawing.Point(701, 63);
            this.textBoxTimkiem.Name = "textBoxTimkiem";
            this.textBoxTimkiem.PlaceholderText = "Nhập từ khóa";
            this.textBoxTimkiem.Size = new System.Drawing.Size(171, 27);
            this.textBoxTimkiem.TabIndex = 3;
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.Location = new System.Drawing.Point(878, 63);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(94, 29);
            this.buttonTimkiem.TabIndex = 4;
            this.buttonTimkiem.Text = "Tìm kiếm";
            this.buttonTimkiem.UseVisualStyleBackColor = true;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm theo :";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTimkiem);
            this.Controls.Add(this.textBoxTimkiem);
            this.Controls.Add(this.comboBoxTimkiem);
            this.Controls.Add(this.listViewPb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.ComboBox comboBoxTimkiem;
        private System.Windows.Forms.TextBox textBoxTimkiem;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXoa;
    }
}