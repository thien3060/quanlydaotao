namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatMonHoc
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
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LyThuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThucHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numThucHanh = new DevExpress.XtraEditors.SpinEdit();
            this.numLyThuyet = new DevExpress.XtraEditors.SpinEdit();
            this.numSTC = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLyThuyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
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
            this.MaMH,
            this.TenMH,
            this.STC,
            this.LyThuyet,
            this.ThucHanh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã môn học";
            this.MaMH.FieldName = "MaMH";
            this.MaMH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaMH.Name = "MaMH";
            this.MaMH.Visible = true;
            this.MaMH.VisibleIndex = 0;
            this.MaMH.Width = 100;
            // 
            // TenMH
            // 
            this.TenMH.Caption = "Tên môn học";
            this.TenMH.FieldName = "TenMH";
            this.TenMH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenMH.Name = "TenMH";
            this.TenMH.Visible = true;
            this.TenMH.VisibleIndex = 1;
            this.TenMH.Width = 357;
            // 
            // STC
            // 
            this.STC.Caption = "Số tín chỉ";
            this.STC.FieldName = "STC";
            this.STC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.STC.Name = "STC";
            this.STC.Visible = true;
            this.STC.VisibleIndex = 2;
            this.STC.Width = 148;
            // 
            // LyThuyet
            // 
            this.LyThuyet.Caption = "Lý Thuyết";
            this.LyThuyet.FieldName = "LyThuyet";
            this.LyThuyet.Name = "LyThuyet";
            this.LyThuyet.Visible = true;
            this.LyThuyet.VisibleIndex = 3;
            this.LyThuyet.Width = 136;
            // 
            // ThucHanh
            // 
            this.ThucHanh.Caption = "Thực hành";
            this.ThucHanh.FieldName = "ThucHanh";
            this.ThucHanh.Name = "ThucHanh";
            this.ThucHanh.Visible = true;
            this.ThucHanh.VisibleIndex = 4;
            this.ThucHanh.Width = 152;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.sua;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(48, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 120);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // numThucHanh
            // 
            this.numThucHanh.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThucHanh.EnterMoveNextControl = true;
            this.numThucHanh.Location = new System.Drawing.Point(745, 114);
            this.numThucHanh.Name = "numThucHanh";
            this.numThucHanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numThucHanh.Properties.Appearance.Options.UseFont = true;
            this.numThucHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numThucHanh.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numThucHanh.Properties.IsFloatValue = false;
            this.numThucHanh.Properties.Mask.EditMask = "N00";
            this.numThucHanh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numThucHanh.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numThucHanh.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThucHanh.Size = new System.Drawing.Size(74, 24);
            this.numThucHanh.TabIndex = 38;
            // 
            // numLyThuyet
            // 
            this.numLyThuyet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLyThuyet.EnterMoveNextControl = true;
            this.numLyThuyet.Location = new System.Drawing.Point(508, 114);
            this.numLyThuyet.Name = "numLyThuyet";
            this.numLyThuyet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numLyThuyet.Properties.Appearance.Options.UseFont = true;
            this.numLyThuyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numLyThuyet.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numLyThuyet.Properties.IsFloatValue = false;
            this.numLyThuyet.Properties.Mask.EditMask = "N00";
            this.numLyThuyet.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numLyThuyet.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLyThuyet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLyThuyet.Size = new System.Drawing.Size(74, 24);
            this.numLyThuyet.TabIndex = 36;
            // 
            // numSTC
            // 
            this.numSTC.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSTC.EnterMoveNextControl = true;
            this.numSTC.Location = new System.Drawing.Point(285, 114);
            this.numSTC.Name = "numSTC";
            this.numSTC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numSTC.Properties.Appearance.Options.UseFont = true;
            this.numSTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numSTC.Properties.IsFloatValue = false;
            this.numSTC.Properties.Mask.EditMask = "N00";
            this.numSTC.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numSTC.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSTC.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSTC.Size = new System.Drawing.Size(64, 24);
            this.numSTC.TabIndex = 34;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMH.EnterMoveNextControl = true;
            this.txtTenMH.Location = new System.Drawing.Point(285, 63);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenMH.Properties.Appearance.Options.UseFont = true;
            this.txtTenMH.Properties.Mask.BeepOnError = true;
            this.txtTenMH.Properties.MaxLength = 30;
            this.txtTenMH.Size = new System.Drawing.Size(534, 24);
            this.txtTenMH.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(622, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 18);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Số tiết thực hành:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(394, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 18);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Số tiết lý thuyết:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(186, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 18);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Số tín chỉ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(186, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 18);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Tên môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.EnterMoveNextControl = true;
            this.txtMaMH.Location = new System.Drawing.Point(285, 12);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaMH.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaMH.Properties.Appearance.Options.UseFont = true;
            this.txtMaMH.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaMH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaMH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaMH.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaMH.Properties.MaxLength = 6;
            this.txtMaMH.Size = new System.Drawing.Size(118, 24);
            this.txtMaMH.TabIndex = 30;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(186, 15);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(87, 18);
            this.lblHoTen.TabIndex = 29;
            this.lblHoTen.Text = "Mã môn học:";
            // 
            // frmCapNhatMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numThucHanh);
            this.Controls.Add(this.numLyThuyet);
            this.Controls.Add(this.numSTC);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmCapNhatMonHoc";
            this.Text = "Cập nhật môn học";
            this.Load += new System.EventHandler(this.frmCapNhatMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLyThuyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuXoa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn STC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit numThucHanh;
        private DevExpress.XtraEditors.SpinEdit numLyThuyet;
        private DevExpress.XtraEditors.SpinEdit numSTC;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn LyThuyet;
        private DevExpress.XtraGrid.Columns.GridColumn ThucHanh;
    }
}