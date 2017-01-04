namespace QuanLyDaoTao.Presentation
{
    partial class frmXemPhanCongGiangDay
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
            this.dateNamHoc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.numHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPC = new DevExpress.XtraEditors.TextEdit();
            this.lblMSSV = new DevExpress.XtraEditors.LabelControl();
            this.cmbMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbGiangVien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLop = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNamHoc
            // 
            this.dateNamHoc.EditValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateNamHoc.EnterMoveNextControl = true;
            this.dateNamHoc.Location = new System.Drawing.Point(634, 26);
            this.dateNamHoc.Name = "dateNamHoc";
            this.dateNamHoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateNamHoc.Properties.Appearance.Options.UseFont = true;
            this.dateNamHoc.Properties.Appearance.Options.UseTextOptions = true;
            this.dateNamHoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamHoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNamHoc.Properties.DisplayFormat.FormatString = "yyyy";
            this.dateNamHoc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNamHoc.Properties.EditFormat.FormatString = "yyyy";
            this.dateNamHoc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNamHoc.Properties.Mask.EditMask = "yyyy";
            this.dateNamHoc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNamHoc.Size = new System.Drawing.Size(77, 24);
            this.dateNamHoc.TabIndex = 5;
            this.dateNamHoc.EditValueChanged += new System.EventHandler(this.dateNamHoc_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(584, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Năm:";
            // 
            // numHocKy
            // 
            this.numHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHocKy.EnterMoveNextControl = true;
            this.numHocKy.Location = new System.Drawing.Point(493, 26);
            this.numHocKy.Name = "numHocKy";
            this.numHocKy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numHocKy.Properties.Appearance.Options.UseFont = true;
            this.numHocKy.Properties.Appearance.Options.UseTextOptions = true;
            this.numHocKy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numHocKy.Properties.IsFloatValue = false;
            this.numHocKy.Properties.Mask.EditMask = "N00";
            this.numHocKy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHocKy.Size = new System.Drawing.Size(70, 24);
            this.numHocKy.TabIndex = 3;
            this.numHocKy.EditValueChanged += new System.EventHandler(this.numHocKy_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(430, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Học kỳ:";
            // 
            // txtMaPC
            // 
            this.txtMaPC.EnterMoveNextControl = true;
            this.txtMaPC.Location = new System.Drawing.Point(265, 26);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaPC.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaPC.Properties.Appearance.Options.UseFont = true;
            this.txtMaPC.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPC.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaPC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaPC.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaPC.Properties.MaxLength = 7;
            this.txtMaPC.Properties.ReadOnly = true;
            this.txtMaPC.Size = new System.Drawing.Size(127, 24);
            this.txtMaPC.TabIndex = 1;
            // 
            // lblMSSV
            // 
            this.lblMSSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMSSV.Location = new System.Drawing.Point(154, 29);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(98, 18);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã phân công:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.EnterMoveNextControl = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(265, 116);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbMonHoc.Properties.Appearance.Options.UseFont = true;
            this.cmbMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonHoc.Properties.DisplayMember = "TenMH";
            this.cmbMonHoc.Properties.ValueMember = "MaMH";
            this.cmbMonHoc.Size = new System.Drawing.Size(189, 24);
            this.cmbMonHoc.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(154, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Môn học:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(154, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Giảng viên:";
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.EnterMoveNextControl = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(265, 71);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbGiangVien.Properties.Appearance.Options.UseFont = true;
            this.cmbGiangVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGiangVien.Properties.DisplayMember = "HoTen";
            this.cmbGiangVien.Properties.ValueMember = "MaGV";
            this.cmbGiangVien.Size = new System.Drawing.Size(446, 24);
            this.cmbGiangVien.TabIndex = 7;
            this.cmbGiangVien.EditValueChanged += new System.EventHandler(this.cmbGiangVien_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(493, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Lớp:";
            // 
            // cmbLop
            // 
            this.cmbLop.EnterMoveNextControl = true;
            this.cmbLop.Location = new System.Drawing.Point(543, 116);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbLop.Properties.Appearance.Options.UseFont = true;
            this.cmbLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLop.Properties.DisplayMember = "MaLop";
            this.cmbLop.Properties.ValueMember = "MaLop";
            this.cmbLop.Size = new System.Drawing.Size(168, 24);
            this.cmbLop.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.note;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(924, 291);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPC,
            this.MaGV,
            this.MaMH,
            this.MaLop,
            this.HocKy,
            this.NamHoc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.MaLop, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // MaPC
            // 
            this.MaPC.Caption = "Mã phân công";
            this.MaPC.FieldName = "MaPC";
            this.MaPC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaPC.Name = "MaPC";
            this.MaPC.Visible = true;
            this.MaPC.VisibleIndex = 0;
            this.MaPC.Width = 100;
            // 
            // MaGV
            // 
            this.MaGV.Caption = "Mã giảng viên";
            this.MaGV.FieldName = "MaGV";
            this.MaGV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaGV.Name = "MaGV";
            this.MaGV.Visible = true;
            this.MaGV.VisibleIndex = 1;
            this.MaGV.Width = 170;
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã môn học";
            this.MaMH.FieldName = "MaMH";
            this.MaMH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaMH.Name = "MaMH";
            this.MaMH.Visible = true;
            this.MaMH.VisibleIndex = 2;
            this.MaMH.Width = 95;
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã lớp";
            this.MaLop.FieldName = "MaLop";
            this.MaLop.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 3;
            this.MaLop.Width = 113;
            // 
            // HocKy
            // 
            this.HocKy.Caption = "Học kỳ";
            this.HocKy.FieldName = "HocKy";
            this.HocKy.Name = "HocKy";
            this.HocKy.Visible = true;
            this.HocKy.VisibleIndex = 3;
            this.HocKy.Width = 139;
            // 
            // NamHoc
            // 
            this.NamHoc.Caption = "Năm học";
            this.NamHoc.FieldName = "NamHoc";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Visible = true;
            this.NamHoc.VisibleIndex = 4;
            this.NamHoc.Width = 372;
            // 
            // frmXemPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 472);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbGiangVien);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaPC);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.numHocKy);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateNamHoc);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmXemPhanCongGiangDay";
            this.Text = "Xem phân công giảng dạy";
            this.Load += new System.EventHandler(this.frmXemPhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DevExpress.XtraEditors.DateEdit dateNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit numHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaPC;
        private DevExpress.XtraEditors.LabelControl lblMSSV;
        private DevExpress.XtraEditors.LookUpEdit cmbMonHoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbGiangVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbLop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPC;
        private DevExpress.XtraGrid.Columns.GridColumn MaGV;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn HocKy;
        private DevExpress.XtraGrid.Columns.GridColumn NamHoc;
    }
}