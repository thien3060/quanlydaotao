namespace QuanLyDaoTao
{
    partial class FrmKhoiLop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb_MaTDDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cb_MaHeDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dg_DanhSachKhoiLop = new System.Windows.Forms.DataGridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tb_TenKhoiLop = new DevExpress.XtraEditors.TextEdit();
            this.tb_MaKhoiLop = new DevExpress.XtraEditors.TextEdit();
            this.cb_MaKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaTDDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaHeDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhSachKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(801, 630);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cb_MaKhoa);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tb_TenKhoiLop);
            this.groupControl1.Controls.Add(this.tb_MaKhoiLop);
            this.groupControl1.Controls.Add(this.cb_MaTDDT);
            this.groupControl1.Controls.Add(this.cb_MaHeDT);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.bt_Xoa);
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_Sua);
            this.groupControl1.Controls.Add(this.bt_Them);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 275);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Khối lớp";
            // 
            // cb_MaTDDT
            // 
            this.cb_MaTDDT.Location = new System.Drawing.Point(526, 146);
            this.cb_MaTDDT.Name = "cb_MaTDDT";
            this.cb_MaTDDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_MaTDDT.Size = new System.Drawing.Size(193, 20);
            this.cb_MaTDDT.TabIndex = 1;
            // 
            // cb_MaHeDT
            // 
            this.cb_MaHeDT.Location = new System.Drawing.Point(185, 146);
            this.cb_MaHeDT.Name = "cb_MaHeDT";
            this.cb_MaHeDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_MaHeDT.Size = new System.Drawing.Size(193, 20);
            this.cb_MaHeDT.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(426, 149);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mã trình độ đào tạo";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(448, 210);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_Xoa.TabIndex = 5;
            this.bt_Xoa.Text = "Xoá";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Location = new System.Drawing.Point(327, 210);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 5;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(209, 210);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 23);
            this.bt_Sua.TabIndex = 5;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(97, 210);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 5;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(97, 149);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã hệ đào tạo";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dg_DanhSachKhoiLop);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(795, 246);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách khối lớp";
            // 
            // dg_DanhSachKhoiLop
            // 
            this.dg_DanhSachKhoiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DanhSachKhoiLop.Location = new System.Drawing.Point(5, 23);
            this.dg_DanhSachKhoiLop.Name = "dg_DanhSachKhoiLop";
            this.dg_DanhSachKhoiLop.Size = new System.Drawing.Size(790, 266);
            this.dg_DanhSachKhoiLop.TabIndex = 0;
            this.dg_DanhSachKhoiLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DanhSachGV_CellClick);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(426, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tên khối lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(97, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Mã khối lớp";
            // 
            // tb_TenKhoiLop
            // 
            this.tb_TenKhoiLop.Location = new System.Drawing.Point(526, 47);
            this.tb_TenKhoiLop.Name = "tb_TenKhoiLop";
            this.tb_TenKhoiLop.Properties.AccessibleName = "";
            this.tb_TenKhoiLop.Size = new System.Drawing.Size(193, 20);
            this.tb_TenKhoiLop.TabIndex = 8;
            // 
            // tb_MaKhoiLop
            // 
            this.tb_MaKhoiLop.Location = new System.Drawing.Point(185, 47);
            this.tb_MaKhoiLop.Name = "tb_MaKhoiLop";
            this.tb_MaKhoiLop.Size = new System.Drawing.Size(193, 20);
            this.tb_MaKhoiLop.TabIndex = 9;
            // 
            // cb_MaKhoa
            // 
            this.cb_MaKhoa.Location = new System.Drawing.Point(185, 98);
            this.cb_MaKhoa.Name = "cb_MaKhoa";
            this.cb_MaKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_MaKhoa.Size = new System.Drawing.Size(193, 20);
            this.cb_MaKhoa.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(97, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Mã khoa";
            // 
            // FrmKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 630);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKhoiLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmKhoiLop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaTDDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaHeDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhSachKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaKhoa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dg_DanhSachKhoiLop;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private DevExpress.XtraEditors.SimpleButton bt_Them;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_MaTDDT;
        private DevExpress.XtraEditors.ComboBoxEdit cb_MaHeDT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tb_TenKhoiLop;
        private DevExpress.XtraEditors.TextEdit tb_MaKhoiLop;
        private DevExpress.XtraEditors.ComboBoxEdit cb_MaKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
