namespace QuanLyDaoTao.Presentation
{
    partial class frmInThoiKhoaBieuGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInThoiKhoaBieuGiangVien));
            this.numHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateNamHoc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbGiangVien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTuan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblChuY = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.xemThoiKhoaBieuGiangVien1 = new QuanLyDaoTao.UserControls.XemThoiKhoaBieuGiangVien();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTuan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // numHocKy
            // 
            this.numHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHocKy.EnterMoveNextControl = true;
            this.numHocKy.Location = new System.Drawing.Point(119, 9);
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
            this.numHocKy.TabIndex = 1;
            this.numHocKy.EditValueChanged += new System.EventHandler(this.numHocKy_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(56, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Học kỳ:";
            // 
            // dateNamHoc
            // 
            this.dateNamHoc.EditValue = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateNamHoc.EnterMoveNextControl = true;
            this.dateNamHoc.Location = new System.Drawing.Point(258, 9);
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
            this.dateNamHoc.TabIndex = 3;
            this.dateNamHoc.EditValueChanged += new System.EventHandler(this.dateNamHoc_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(208, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Năm:";
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.EnterMoveNextControl = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(896, 9);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbGiangVien.Properties.Appearance.Options.UseFont = true;
            this.cmbGiangVien.Properties.BestFitRowCount = 7;
            this.cmbGiangVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGiangVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaGV", 50, "Mã Giảng Viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", 100, "Họ Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTrinhDo", 50, "Trình Độ")});
            this.cmbGiangVien.Properties.DisplayMember = "HoTen";
            this.cmbGiangVien.Properties.ValueMember = "MaGV";
            this.cmbGiangVien.Size = new System.Drawing.Size(187, 24);
            this.cmbGiangVien.TabIndex = 7;
            this.cmbGiangVien.EditValueChanged += new System.EventHandler(this.cmbGiangVien_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(353, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tuần:";
            // 
            // cmbTuan
            // 
            this.cmbTuan.EnterMoveNextControl = true;
            this.cmbTuan.Location = new System.Drawing.Point(398, 9);
            this.cmbTuan.Name = "cmbTuan";
            this.cmbTuan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbTuan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbTuan.Properties.Appearance.Options.UseBackColor = true;
            this.cmbTuan.Properties.Appearance.Options.UseFont = true;
            this.cmbTuan.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbTuan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbTuan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTuan.Size = new System.Drawing.Size(399, 24);
            this.cmbTuan.TabIndex = 5;
            this.cmbTuan.SelectedIndexChanged += new System.EventHandler(this.cmbTuan_SelectedIndexChanged);
            // 
            // lblChuY
            // 
            this.lblChuY.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblChuY.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblChuY.Location = new System.Drawing.Point(81, 39);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(544, 14);
            this.lblChuY.TabIndex = 13;
            this.lblChuY.Text = "Lưu ý: Học kỳ 1 bắt đầu từ tháng 8 --> 12. Học kỳ 2 từ tháng 1 --> 5. Học kỳ 3 từ" +
    " tháng 6 --> 7.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(828, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Giảng viên:";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1114, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 43);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // xemThoiKhoaBieuGiangVien1
            // 
            this.xemThoiKhoaBieuGiangVien1.Location = new System.Drawing.Point(56, 61);
            this.xemThoiKhoaBieuGiangVien1.MaGV = "";
            this.xemThoiKhoaBieuGiangVien1.MaximumSize = new System.Drawing.Size(1146, 475);
            this.xemThoiKhoaBieuGiangVien1.MinimumSize = new System.Drawing.Size(1146, 475);
            this.xemThoiKhoaBieuGiangVien1.Name = "xemThoiKhoaBieuGiangVien1";
            this.xemThoiKhoaBieuGiangVien1.NgayDauTuan = new System.DateTime(2016, 12, 19, 21, 7, 6, 125);
            this.xemThoiKhoaBieuGiangVien1.Size = new System.Drawing.Size(1146, 475);
            this.xemThoiKhoaBieuGiangVien1.TabIndex = 14;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmInThoiKhoaBieuGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 543);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblChuY);
            this.Controls.Add(this.cmbTuan);
            this.Controls.Add(this.cmbGiangVien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.numHocKy);
            this.Controls.Add(this.dateNamHoc);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.xemThoiKhoaBieuGiangVien1);
            this.Name = "frmInThoiKhoaBieuGiangVien";
            this.Text = "In thời khóa biểu giảng viên";
            this.Load += new System.EventHandler(this.frmInThoiKhoaBieuGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTuan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit numHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbGiangVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTuan;
        private DevExpress.XtraEditors.LabelControl lblChuY;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private QuanLyDaoTao.UserControls.XemThoiKhoaBieuGiangVien xemThoiKhoaBieuGiangVien1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}