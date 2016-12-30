namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatGiangVien
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTrinhDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdgGioiTinh = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTrinhDo = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMSSV = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(495, 186);
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
            this.btnLuu.Location = new System.Drawing.Point(289, 186);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 43);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(13, 235);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(913, 257);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGV,
            this.HoTen,
            this.GioiTinh,
            this.DiaChi,
            this.MaTrinhDo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaGV
            // 
            this.MaGV.Caption = "Mã giảng viên";
            this.MaGV.FieldName = "MaGV";
            this.MaGV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaGV.Name = "MaGV";
            this.MaGV.Visible = true;
            this.MaGV.VisibleIndex = 0;
            this.MaGV.Width = 100;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 198;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính nam";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            this.GioiTinh.Width = 95;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 339;
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.Caption = "Mã trình độ";
            this.MaTrinhDo.FieldName = "MaTrinhDo";
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Visible = true;
            this.MaTrinhDo.VisibleIndex = 4;
            this.MaTrinhDo.Width = 161;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.nguoidung;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 142);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // rdgGioiTinh
            // 
            this.rdgGioiTinh.Location = new System.Drawing.Point(289, 82);
            this.rdgGioiTinh.Name = "rdgGioiTinh";
            this.rdgGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdgGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.rdgGioiTinh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nữ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nam")});
            this.rdgGioiTinh.Size = new System.Drawing.Size(139, 30);
            this.rdgGioiTinh.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(176, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 18);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Giới tính:";
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.EnterMoveNextControl = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(610, 85);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.cmbTrinhDo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTrinhDo.Properties.DisplayMember = "TenTrinhDo";
            this.cmbTrinhDo.Properties.ValueMember = "MaTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(180, 24);
            this.cmbTrinhDo.TabIndex = 36;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(289, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Mask.BeepOnError = true;
            this.txtDiaChi.Properties.MaxLength = 50;
            this.txtDiaChi.Size = new System.Drawing.Size(501, 24);
            this.txtDiaChi.TabIndex = 38;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(176, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 18);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(531, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Trình độ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.EnterMoveNextControl = true;
            this.txtHoTen.Location = new System.Drawing.Point(289, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Size = new System.Drawing.Size(501, 24);
            this.txtHoTen.TabIndex = 32;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.EnterMoveNextControl = true;
            this.txtMaGV.Location = new System.Drawing.Point(289, 9);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaGV.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaGV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaGV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaGV.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaGV.Properties.MaxLength = 8;
            this.txtMaGV.Properties.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(127, 24);
            this.txtMaGV.TabIndex = 30;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(176, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 18);
            this.lblHoTen.TabIndex = 31;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMSSV.Location = new System.Drawing.Point(176, 12);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(95, 18);
            this.lblMSSV.TabIndex = 29;
            this.lblMSSV.Text = "Mã giảng viên:";
            // 
            // frmCapNhatGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdgGioiTinh);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbTrinhDo);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmCapNhatGiangVien";
            this.Text = "Cập nhật giảng viên";
            this.Load += new System.EventHandler(this.frmCapNhatGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaGV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.RadioGroup rdgGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbTrinhDo;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn MaTrinhDo;
    }
}