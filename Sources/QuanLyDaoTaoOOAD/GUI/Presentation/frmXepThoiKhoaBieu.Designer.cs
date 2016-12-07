﻿namespace QuanLyDaoTao.Presentation
{
    partial class frmXepThoiKhoaBieu
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
            this.numHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateNamHoc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTuan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lblChuY = new DevExpress.XtraEditors.LabelControl();
            this.thoiKhoaBieu1 = new QuanLyDaoTao.UserControls.ThoiKhoaBieu();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.numHocKy.Location = new System.Drawing.Point(171, 11);
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
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(108, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Học kỳ:";
            // 
            // dateNamHoc
            // 
            this.dateNamHoc.EditValue = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateNamHoc.EnterMoveNextControl = true;
            this.dateNamHoc.Location = new System.Drawing.Point(310, 11);
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
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(260, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Năm:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.EnterMoveNextControl = true;
            this.cmbPhong.Location = new System.Drawing.Point(931, 11);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbPhong.Properties.Appearance.Options.UseFont = true;
            this.cmbPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhong.Properties.DisplayMember = "MaPhong";
            this.cmbPhong.Properties.ValueMember = "MaPhong";
            this.cmbPhong.Size = new System.Drawing.Size(88, 24);
            this.cmbPhong.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(1049, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Sức chứa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(405, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tuần:";
            // 
            // cmbTuan
            // 
            this.cmbTuan.EnterMoveNextControl = true;
            this.cmbTuan.Location = new System.Drawing.Point(450, 11);
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
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(278, 44);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 34);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(171, 44);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 34);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            // 
            // lblChuY
            // 
            this.lblChuY.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblChuY.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblChuY.Location = new System.Drawing.Point(405, 53);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(544, 14);
            this.lblChuY.TabIndex = 13;
            this.lblChuY.Text = "Lưu ý: Học kỳ 1 bắt đầu từ tháng 8 --> 12. Học kỳ 2 từ tháng 1 --> 5. Học kỳ 3 từ" +
    " tháng 6 --> 7.";
            // 
            // thoiKhoaBieu1
            // 
            this.thoiKhoaBieu1.Location = new System.Drawing.Point(56, 84);
            this.thoiKhoaBieu1.MaximumSize = new System.Drawing.Size(1146, 475);
            this.thoiKhoaBieu1.MinimumSize = new System.Drawing.Size(1146, 475);
            this.thoiKhoaBieu1.Name = "thoiKhoaBieu1";
            this.thoiKhoaBieu1.Size = new System.Drawing.Size(1146, 475);
            this.thoiKhoaBieu1.TabIndex = 14;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(1121, 11);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSucChua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSucChua.Properties.Appearance.Options.UseBackColor = true;
            this.txtSucChua.Properties.Appearance.Options.UseFont = true;
            this.txtSucChua.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSucChua.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSucChua.Properties.ReadOnly = true;
            this.txtSucChua.Size = new System.Drawing.Size(60, 24);
            this.txtSucChua.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(880, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Phòng:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.tkb64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmXepThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.thoiKhoaBieu1);
            this.Controls.Add(this.lblChuY);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cmbTuan);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.numHocKy);
            this.Controls.Add(this.dateNamHoc);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmXepThoiKhoaBieu";
            this.Text = "Xếp thời khóa biểu";
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit numHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTuan;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl lblChuY;
        private QuanLyDaoTao.UserControls.ThoiKhoaBieu thoiKhoaBieu1;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}