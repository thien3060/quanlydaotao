namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatSinhVien));
            this.cmbLop = new DevExpress.XtraEditors.LookUpEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMSSV = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMSSV = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLop
            // 
            this.cmbLop.EnterMoveNextControl = true;
            this.cmbLop.Location = new System.Drawing.Point(579, 98);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbLop.Properties.Appearance.Options.UseBackColor = true;
            this.cmbLop.Properties.Appearance.Options.UseFont = true;
            this.cmbLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLop.Properties.DisplayMember = "MaLop";
            this.cmbLop.Properties.ReadOnly = true;
            this.cmbLop.Properties.ValueMember = "MaLop";
            this.cmbLop.Size = new System.Drawing.Size(210, 24);
            this.cmbLop.TabIndex = 21;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.EnterMoveNextControl = true;
            this.dateNgaySinh.Location = new System.Drawing.Point(286, 98);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dateNgaySinh.Properties.Appearance.Options.UseTextOptions = true;
            this.dateNgaySinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNgaySinh.Size = new System.Drawing.Size(148, 24);
            this.dateNgaySinh.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(492, 173);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Xóa";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(286, 173);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 43);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(286, 143);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Mask.BeepOnError = true;
            this.txtDiaChi.Properties.MaxLength = 50;
            this.txtDiaChi.Size = new System.Drawing.Size(640, 24);
            this.txtDiaChi.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(175, 146);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 18);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(530, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Lớp:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNgaySinh.Location = new System.Drawing.Point(175, 101);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 18);
            this.lblNgaySinh.TabIndex = 18;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.EnterMoveNextControl = true;
            this.txtHoTen.Location = new System.Drawing.Point(286, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Size = new System.Drawing.Size(640, 24);
            this.txtHoTen.TabIndex = 17;
            // 
            // txtMSSV
            // 
            this.txtMSSV.EnterMoveNextControl = true;
            this.txtMSSV.Location = new System.Drawing.Point(286, 22);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMSSV.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMSSV.Properties.Appearance.Options.UseFont = true;
            this.txtMSSV.Properties.Appearance.Options.UseForeColor = true;
            this.txtMSSV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMSSV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMSSV.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMSSV.Properties.MaxLength = 8;
            this.txtMSSV.Properties.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(127, 24);
            this.txtMSSV.TabIndex = 15;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(175, 63);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 18);
            this.lblHoTen.TabIndex = 16;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMSSV.Location = new System.Drawing.Point(175, 25);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(42, 18);
            this.lblMSSV.TabIndex = 14;
            this.lblMSSV.Text = "MSSV:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.sinhvien;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 139);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(13, 222);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(913, 258);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MSSV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.MaLop});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.MaLop, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // MSSV
            // 
            this.MSSV.Caption = "MSSV";
            this.MSSV.FieldName = "MSSV";
            this.MSSV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MSSV.Name = "MSSV";
            this.MSSV.Visible = true;
            this.MSSV.VisibleIndex = 0;
            this.MSSV.Width = 100;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 250;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 250;
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã lớp";
            this.MaLop.FieldName = "MaLop";
            this.MaLop.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 2;
            this.MaLop.Width = 100;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(705, 186);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.NullText = "Tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 20);
            this.txtTimKiem.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(903, 184);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 23);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmCapNhatSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Name = "frmCapNhatSinhVien";
            this.Text = "Cập nhật sinh viên";
            this.Load += new System.EventHandler(this.frmCapNhatSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbLop;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMSSV;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblMSSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MSSV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
    }
}