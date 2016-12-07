namespace QuanLyDaoTao.Presentation
{
    partial class frmThongTinNguoiDung
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
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuyen = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.txtQuyen = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Location = new System.Drawing.Point(239, 68);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblQuyen.Location = new System.Drawing.Point(170, 12);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(48, 18);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Quyền:";
            // 
            // lblTen
            // 
            this.lblTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTen.Location = new System.Drawing.Point(116, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 18);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên:";
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(239, 12);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(100, 20);
            this.txtQuyen.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(170, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(169, 20);
            this.txtTen.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyDaoTao.Properties.Resources.info72;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 114);
            this.ControlBox = false;
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.btnDong);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 178);
            this.MinimizeBox = false;
            this.Name = "frmThongTinNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin của bạn";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.LabelControl lblQuyen;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtQuyen;
        private DevExpress.XtraEditors.TextEdit txtTen;
    }
}