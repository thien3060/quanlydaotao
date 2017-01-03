namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatPhongHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatPhongHoc));
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SucChua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numSucChua = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtChucNang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMSSV = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucNang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(492, 128);
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
            this.btnLuu.Location = new System.Drawing.Point(286, 128);
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
            this.gridControl1.Location = new System.Drawing.Point(13, 177);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(913, 235);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhong,
            this.ChucNang,
            this.SucChua,
            this.DiaChi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaPhong
            // 
            this.MaPhong.Caption = "Mã phòng";
            this.MaPhong.FieldName = "MaPhong";
            this.MaPhong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = true;
            this.MaPhong.VisibleIndex = 0;
            this.MaPhong.Width = 100;
            // 
            // ChucNang
            // 
            this.ChucNang.Caption = "Chức năng";
            this.ChucNang.FieldName = "ChucNang";
            this.ChucNang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Visible = true;
            this.ChucNang.VisibleIndex = 1;
            this.ChucNang.Width = 250;
            // 
            // SucChua
            // 
            this.SucChua.Caption = "Sức chứa";
            this.SucChua.FieldName = "SucChua";
            this.SucChua.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.SucChua.Name = "SucChua";
            this.SucChua.Visible = true;
            this.SucChua.VisibleIndex = 3;
            this.SucChua.Width = 150;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.phong_hoc128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 117);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // numSucChua
            // 
            this.numSucChua.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSucChua.EnterMoveNextControl = true;
            this.numSucChua.Location = new System.Drawing.Point(525, 22);
            this.numSucChua.Name = "numSucChua";
            this.numSucChua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numSucChua.Properties.Appearance.Options.UseFont = true;
            this.numSucChua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numSucChua.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSucChua.Properties.IsFloatValue = false;
            this.numSucChua.Properties.Mask.EditMask = "N00";
            this.numSucChua.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numSucChua.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSucChua.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSucChua.Size = new System.Drawing.Size(126, 24);
            this.numSucChua.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(448, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Sức chứa:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(286, 98);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Mask.BeepOnError = true;
            this.txtDiaChi.Properties.MaxLength = 50;
            this.txtDiaChi.Size = new System.Drawing.Size(515, 24);
            this.txtDiaChi.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(205, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 18);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // txtChucNang
            // 
            this.txtChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucNang.EnterMoveNextControl = true;
            this.txtChucNang.Location = new System.Drawing.Point(286, 60);
            this.txtChucNang.Name = "txtChucNang";
            this.txtChucNang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtChucNang.Properties.Appearance.Options.UseFont = true;
            this.txtChucNang.Properties.MaxLength = 50;
            this.txtChucNang.Size = new System.Drawing.Size(515, 24);
            this.txtChucNang.TabIndex = 35;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.EnterMoveNextControl = true;
            this.txtMaPhong.Location = new System.Drawing.Point(286, 22);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaPhong.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhong.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPhong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaPhong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaPhong.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaPhong.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaPhong.Properties.MaxLength = 6;
            this.txtMaPhong.Size = new System.Drawing.Size(122, 24);
            this.txtMaPhong.TabIndex = 31;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(205, 63);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 18);
            this.lblHoTen.TabIndex = 34;
            this.lblHoTen.Text = "Chức năng:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMSSV.Location = new System.Drawing.Point(205, 25);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(70, 18);
            this.lblMSSV.TabIndex = 30;
            this.lblMSSV.Text = "Mã phòng:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(903, 149);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 23);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(705, 151);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.NullText = "Tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 20);
            this.txtTimKiem.TabIndex = 38;
            // 
            // frmCapNhatPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 415);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.numSucChua);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtChucNang);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmCapNhatPhongHoc";
            this.Text = "Cập nhật phòng học";
            this.Load += new System.EventHandler(this.frmCapNhatPhongHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucNang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn SucChua;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit numSucChua;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChucNang;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblMSSV;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
    }
}