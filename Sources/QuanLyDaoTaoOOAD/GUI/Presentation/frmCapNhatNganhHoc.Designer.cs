namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatNganhHoc
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
            this.MaNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNganh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNganh = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(490, 170);
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
            this.btnLuu.Location = new System.Drawing.Point(285, 170);
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
            this.gridControl1.Location = new System.Drawing.Point(13, 219);
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
            this.MaNganh,
            this.TenNganh,
            this.Khoa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaNganh
            // 
            this.MaNganh.Caption = "Mã ngành";
            this.MaNganh.FieldName = "MaNganh";
            this.MaNganh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Visible = true;
            this.MaNganh.VisibleIndex = 0;
            this.MaNganh.Width = 100;
            // 
            // TenNganh
            // 
            this.TenNganh.Caption = "Tên ngành";
            this.TenNganh.FieldName = "TenNganh";
            this.TenNganh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.Visible = true;
            this.TenNganh.VisibleIndex = 1;
            this.TenNganh.Width = 250;
            // 
            // Khoa
            // 
            this.Khoa.Caption = "Khoa";
            this.Khoa.FieldName = "Khoa";
            this.Khoa.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Khoa.Name = "Khoa";
            this.Khoa.Visible = true;
            this.Khoa.VisibleIndex = 2;
            this.Khoa.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.graduation_hat;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(56, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 120);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhoa.EnterMoveNextControl = true;
            this.txtKhoa.Location = new System.Drawing.Point(285, 125);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtKhoa.Properties.Mask.BeepOnError = true;
            this.txtKhoa.Properties.MaxLength = 30;
            this.txtKhoa.Size = new System.Drawing.Size(387, 24);
            this.txtKhoa.TabIndex = 34;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNganh.EnterMoveNextControl = true;
            this.txtTenNganh.Location = new System.Drawing.Point(285, 74);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenNganh.Properties.Appearance.Options.UseFont = true;
            this.txtTenNganh.Properties.Mask.BeepOnError = true;
            this.txtTenNganh.Properties.MaxLength = 30;
            this.txtTenNganh.Size = new System.Drawing.Size(387, 24);
            this.txtTenNganh.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(191, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 18);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Khoa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(191, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 18);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Tên ngành:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Enabled = false;
            this.txtMaNganh.EnterMoveNextControl = true;
            this.txtMaNganh.Location = new System.Drawing.Point(285, 23);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaNganh.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaNganh.Properties.Appearance.Options.UseFont = true;
            this.txtMaNganh.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaNganh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNganh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaNganh.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaNganh.Properties.MaxLength = 5;
            this.txtMaNganh.Size = new System.Drawing.Size(123, 24);
            this.txtMaNganh.TabIndex = 30;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(191, 26);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 18);
            this.lblHoTen.TabIndex = 29;
            this.lblHoTen.Text = "Mã ngành:";
            // 
            // frmCapNhatNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtTenNganh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmCapNhatNganhHoc";
            this.Text = "Cập nhật trình độ";
            this.Load += new System.EventHandler(this.frmCapNhatNganhHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn Khoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtKhoa;
        private DevExpress.XtraEditors.TextEdit txtTenNganh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaNganh;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn MaNganh;
    }
}