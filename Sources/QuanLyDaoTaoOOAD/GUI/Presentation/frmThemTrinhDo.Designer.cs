namespace QuanLyDaoTao.Presentation
{
    partial class frmThemTrinhDo
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
            this.txtTenTrinhDo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTrinhDo = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.numLuong = new DevExpress.XtraEditors.SpinEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(402, 180);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(244, 180);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenTrinhDo
            // 
            this.txtTenTrinhDo.EnterMoveNextControl = true;
            this.txtTenTrinhDo.Location = new System.Drawing.Point(244, 83);
            this.txtTenTrinhDo.Name = "txtTenTrinhDo";
            this.txtTenTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.txtTenTrinhDo.Properties.Mask.BeepOnError = true;
            this.txtTenTrinhDo.Properties.MaxLength = 30;
            this.txtTenTrinhDo.Size = new System.Drawing.Size(387, 24);
            this.txtTenTrinhDo.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(150, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Lương / tiết:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(150, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên trình độ:";
            // 
            // txtMaTrinhDo
            // 
            this.txtMaTrinhDo.EnterMoveNextControl = true;
            this.txtMaTrinhDo.Location = new System.Drawing.Point(244, 32);
            this.txtMaTrinhDo.Name = "txtMaTrinhDo";
            this.txtMaTrinhDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaTrinhDo.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseFont = true;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaTrinhDo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaTrinhDo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTrinhDo.Properties.MaxLength = 5;
            this.txtMaTrinhDo.Size = new System.Drawing.Size(123, 24);
            this.txtMaTrinhDo.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(150, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(80, 18);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Mã trình độ:";
            // 
            // numLuong
            // 
            this.numLuong.EditValue = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numLuong.EnterMoveNextControl = true;
            this.numLuong.Location = new System.Drawing.Point(244, 134);
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
            this.numLuong.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.trinhdo128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 120);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmThemTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numLuong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenTrinhDo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaTrinhDo);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmThemTrinhDo";
            this.Text = "Trình độ mới";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTrinhDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtTenTrinhDo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaTrinhDo;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.SpinEdit numLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}