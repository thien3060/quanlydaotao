namespace QuanLyDaoTao.Presentation
{
    partial class frmCapNhatTrinhDo
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
            this.MaTrinhDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTrinhDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenTrinhDo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTrinhDo = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDo.Properties)).BeginInit();
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
            this.MaTrinhDo,
            this.TenTrinhDo,
            this.HeSoLuong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.Caption = "Mã trình độ";
            this.MaTrinhDo.FieldName = "MaTrinhDo";
            this.MaTrinhDo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Visible = true;
            this.MaTrinhDo.VisibleIndex = 0;
            this.MaTrinhDo.Width = 100;
            // 
            // TenTrinhDo
            // 
            this.TenTrinhDo.Caption = "Tên trình độ";
            this.TenTrinhDo.FieldName = "TenTrinhDo";
            this.TenTrinhDo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenTrinhDo.Name = "TenTrinhDo";
            this.TenTrinhDo.Visible = true;
            this.TenTrinhDo.VisibleIndex = 1;
            this.TenTrinhDo.Width = 250;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.Caption = "Hệ số lương";
            this.HeSoLuong.FieldName = "HeSoLuong";
            this.HeSoLuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Visible = true;
            this.HeSoLuong.VisibleIndex = 2;
            this.HeSoLuong.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.trinhdo128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 120);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // numLuong
            // 
            this.numLuong.EditValue = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numLuong.EnterMoveNextControl = true;
            this.numLuong.Location = new System.Drawing.Point(311, 124);
            this.numLuong.Name = "numLuong";
            this.numLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numLuong.Properties.Appearance.Options.UseFont = true;
            this.numLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numLuong.Properties.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numLuong.Properties.IsFloatValue = false;
            this.numLuong.Properties.Mask.EditMask = "N00";
            this.numLuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numLuong.Size = new System.Drawing.Size(100, 24);
            this.numLuong.TabIndex = 44;
            // 
            // txtTenTrinhDo
            // 
            this.txtTenTrinhDo.EnterMoveNextControl = true;
            this.txtTenTrinhDo.Location = new System.Drawing.Point(311, 73);
            this.txtTenTrinhDo.Name = "txtTenTrinhDo";
            this.txtTenTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.txtTenTrinhDo.Properties.Mask.BeepOnError = true;
            this.txtTenTrinhDo.Properties.MaxLength = 30;
            this.txtTenTrinhDo.Size = new System.Drawing.Size(387, 24);
            this.txtTenTrinhDo.TabIndex = 42;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(217, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 18);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Lương / tiết:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(217, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 18);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Tên trình độ:";
            // 
            // txtMaTrinhDo
            // 
            this.txtMaTrinhDo.Enabled = false;
            this.txtMaTrinhDo.EnterMoveNextControl = true;
            this.txtMaTrinhDo.Location = new System.Drawing.Point(311, 22);
            this.txtMaTrinhDo.Name = "txtMaTrinhDo";
            this.txtMaTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaTrinhDo.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaTrinhDo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTrinhDo.Properties.MaxLength = 5;
            this.txtMaTrinhDo.Size = new System.Drawing.Size(123, 24);
            this.txtMaTrinhDo.TabIndex = 40;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(217, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(80, 18);
            this.lblHoTen.TabIndex = 39;
            this.lblHoTen.Text = "Mã trình độ:";
            // 
            // frmCapNhatTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 457);
            this.Controls.Add(this.numLuong);
            this.Controls.Add(this.txtTenTrinhDo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaTrinhDo);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmCapNhatTrinhDo";
            this.Text = "Cập nhật trình độ";
            this.Load += new System.EventHandler(this.frmCapNhatTrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTrinhDo;
        private DevExpress.XtraGrid.Columns.GridColumn TenTrinhDo;
        private DevExpress.XtraGrid.Columns.GridColumn HeSoLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit numLuong;
        private DevExpress.XtraEditors.TextEdit txtTenTrinhDo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaTrinhDo;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
    }
}