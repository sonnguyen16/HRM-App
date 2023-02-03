
namespace QuanLyNhanSuVaKH
{
    partial class frmChucvu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLammoi = new System.Windows.Forms.Button();
            this.textBoxGc = new System.Windows.Forms.TextBox();
            this.textBoxTcv = new System.Windows.Forms.TextBox();
            this.textBoxMcv = new System.Windows.Forms.TextBox();
            this.labelGc = new System.Windows.Forms.Label();
            this.labelTcv = new System.Windows.Forms.Label();
            this.labelMcv = new System.Windows.Forms.Label();
            this.listViewCv = new System.Windows.Forms.ListView();
            this.columnMcv = new System.Windows.Forms.ColumnHeader();
            this.columnTcv = new System.Windows.Forms.ColumnHeader();
            this.columnGc = new System.Windows.Forms.ColumnHeader();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonLammoi);
            this.groupBox1.Controls.Add(this.textBoxGc);
            this.groupBox1.Controls.Add(this.textBoxTcv);
            this.groupBox1.Controls.Add(this.textBoxMcv);
            this.groupBox1.Controls.Add(this.labelGc);
            this.groupBox1.Controls.Add(this.labelTcv);
            this.groupBox1.Controls.Add(this.labelMcv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(58, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin chức vụ";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(315, 299);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(94, 29);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(38, 299);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(94, 29);
            this.buttonThem.TabIndex = 9;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(177, 299);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(94, 29);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonLammoi
            // 
            this.buttonLammoi.Location = new System.Drawing.Point(177, 359);
            this.buttonLammoi.Name = "buttonLammoi";
            this.buttonLammoi.Size = new System.Drawing.Size(94, 29);
            this.buttonLammoi.TabIndex = 6;
            this.buttonLammoi.Text = "Làm mới";
            this.buttonLammoi.UseVisualStyleBackColor = true;
            this.buttonLammoi.Click += new System.EventHandler(this.buttonLammoi_Click);
            // 
            // textBoxGc
            // 
            this.textBoxGc.Location = new System.Drawing.Point(168, 230);
            this.textBoxGc.Name = "textBoxGc";
            this.textBoxGc.Size = new System.Drawing.Size(241, 30);
            this.textBoxGc.TabIndex = 5;
            // 
            // textBoxTcv
            // 
            this.textBoxTcv.Location = new System.Drawing.Point(168, 153);
            this.textBoxTcv.Name = "textBoxTcv";
            this.textBoxTcv.Size = new System.Drawing.Size(241, 30);
            this.textBoxTcv.TabIndex = 4;
            // 
            // textBoxMcv
            // 
            this.textBoxMcv.Location = new System.Drawing.Point(168, 76);
            this.textBoxMcv.Name = "textBoxMcv";
            this.textBoxMcv.Size = new System.Drawing.Size(241, 30);
            this.textBoxMcv.TabIndex = 3;
            // 
            // labelGc
            // 
            this.labelGc.AutoSize = true;
            this.labelGc.Location = new System.Drawing.Point(32, 230);
            this.labelGc.Name = "labelGc";
            this.labelGc.Size = new System.Drawing.Size(69, 23);
            this.labelGc.TabIndex = 2;
            this.labelGc.Text = "Ghi chú";
            // 
            // labelTcv
            // 
            this.labelTcv.AutoSize = true;
            this.labelTcv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTcv.Location = new System.Drawing.Point(32, 153);
            this.labelTcv.Name = "labelTcv";
            this.labelTcv.Size = new System.Drawing.Size(100, 23);
            this.labelTcv.TabIndex = 1;
            this.labelTcv.Text = "Tên chức vụ";
            // 
            // labelMcv
            // 
            this.labelMcv.AutoSize = true;
            this.labelMcv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMcv.Location = new System.Drawing.Point(32, 76);
            this.labelMcv.Name = "labelMcv";
            this.labelMcv.Size = new System.Drawing.Size(98, 23);
            this.labelMcv.TabIndex = 0;
            this.labelMcv.Text = "Mã chức vụ";
            // 
            // listViewCv
            // 
            this.listViewCv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMcv,
            this.columnTcv,
            this.columnGc});
            this.listViewCv.GridLines = true;
            this.listViewCv.HideSelection = false;
            this.listViewCv.Location = new System.Drawing.Point(574, 114);
            this.listViewCv.Name = "listViewCv";
            this.listViewCv.Size = new System.Drawing.Size(625, 464);
            this.listViewCv.TabIndex = 1;
            this.listViewCv.UseCompatibleStateImageBehavior = false;
            this.listViewCv.View = System.Windows.Forms.View.Details;
            this.listViewCv.SelectedIndexChanged += new System.EventHandler(this.listViewCv_SelectedIndexChanged);
            // 
            // columnMcv
            // 
            this.columnMcv.Text = "Mã chức vụ";
            this.columnMcv.Width = 120;
            // 
            // columnTcv
            // 
            this.columnTcv.Text = "Tên chức vụ";
            this.columnTcv.Width = 170;
            // 
            // columnGc
            // 
            this.columnGc.Text = "Ghi chú";
            this.columnGc.Width = 220;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "1.Mã chức vụ",
            "2.Tên chức vụ"});
            this.comboBoxSearch.Location = new System.Drawing.Point(574, 69);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(187, 28);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(779, 69);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(175, 27);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(975, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm theo :";
            // 
            // frmChucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.listViewCv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.frmChucvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGc;
        private System.Windows.Forms.Label labelTcv;
        private System.Windows.Forms.Label labelMcv;
        private System.Windows.Forms.TextBox textBoxGc;
        private System.Windows.Forms.TextBox textBoxTcv;
        private System.Windows.Forms.TextBox textBoxMcv;
        private System.Windows.Forms.ListView listViewCv;
        private System.Windows.Forms.ColumnHeader columnMcv;
        private System.Windows.Forms.ColumnHeader columnTcv;
        private System.Windows.Forms.ColumnHeader columnGc;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button buttonThem;
        internal System.Windows.Forms.Button buttonSua;
        internal System.Windows.Forms.Button buttonLammoi;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button buttonXoa;
    }
}