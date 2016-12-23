namespace QuanLyDaoTao.Presentation
{
    partial class frmThongTinGiangVien
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
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblTrinhDo = new DevExpress.XtraEditors.LabelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.labelHoTen = new DevExpress.XtraEditors.LabelControl();
            this.labelGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.labelDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.labelTrinhDo = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThongBao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblDiaChi.Location = new System.Drawing.Point(165, 95);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 18);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTrinhDo.Location = new System.Drawing.Point(355, 50);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(60, 18);
            this.lblTrinhDo.TabIndex = 6;
            this.lblTrinhDo.Text = "Trình độ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(165, 12);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 18);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblGioiTinh.Location = new System.Drawing.Point(165, 50);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 18);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Location = new System.Drawing.Point(355, 123);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(114, 43);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // labelHoTen
            // 
            this.labelHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelHoTen.Location = new System.Drawing.Point(269, 12);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(44, 18);
            this.labelHoTen.TabIndex = 13;
            this.labelHoTen.Text = "HoTen";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelGioiTinh.Location = new System.Drawing.Point(269, 50);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(50, 18);
            this.labelGioiTinh.TabIndex = 14;
            this.labelGioiTinh.Text = "GioiTinh";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDiaChi.Location = new System.Drawing.Point(269, 95);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(39, 18);
            this.labelDiaChi.TabIndex = 15;
            this.labelDiaChi.Text = "DiaChi";
            // 
            // labelTrinhDo
            // 
            this.labelTrinhDo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelTrinhDo.Location = new System.Drawing.Point(436, 50);
            this.labelTrinhDo.Name = "labelTrinhDo";
            this.labelTrinhDo.Size = new System.Drawing.Size(51, 18);
            this.labelTrinhDo.TabIndex = 16;
            this.labelTrinhDo.Text = "TrinhDo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.nguoidung;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 101);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongBao.Location = new System.Drawing.Point(165, 60);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(306, 29);
            this.lblThongBao.TabIndex = 17;
            this.lblThongBao.Text = "Bạn không phải là giảng viên";
            this.lblThongBao.Visible = false;
            // 
            // frmThongTinGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 178);
            this.ControlBox = false;
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.labelTrinhDo);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTrinhDo);
            this.Controls.Add(this.lblHoTen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin của bạn";
            this.Load += new System.EventHandler(this.frmThongTinGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.LabelControl lblTrinhDo;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblGioiTinh;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelHoTen;
        private DevExpress.XtraEditors.LabelControl labelGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelDiaChi;
        private DevExpress.XtraEditors.LabelControl labelTrinhDo;
        private DevExpress.XtraEditors.LabelControl lblThongBao;
    }
}