﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyDaoTao
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUS_Login busLogin = new BUS_Login();
        DTO_NguoiDung dtoNguoiDung = new DTO_NguoiDung();

        public static string Username;
        public static string MatKhau;
        public static string Quyen;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            dtoNguoiDung.TenDN = tb_TenTaiKhoan.Text;
            dtoNguoiDung.MatKhau = tb_MatKhau.Text;

            DataTable dangnhap_datatable = busLogin.LayDanhSachTheoID(dtoNguoiDung);
            int SoRecord = dangnhap_datatable.Rows.Count;
            if (SoRecord == 1)
            {
                FrmMain.Username = dangnhap_datatable.Rows[0]["TenDN"].ToString();
                FrmMain.Quyen = dangnhap_datatable.Rows[0]["Quyen"].ToString();
                ribbonControl1.HideApplicationButtonContentControl();
                MessageBox.Show("Đăng nhập thành công", "ĐĂNG NHẬP", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu!", "ĐĂNG NHẬP", MessageBoxButtons.OK);
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void backstageViewButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        #region Trang chủ
        private void bt_QLGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmGiaoVien gv = new FrmGiaoVien();
            gv.Dock = DockStyle.Fill;
            gv.MdiParent = this;
            gv.Show();
        }
        #endregion

        #region Kế hoạch
        #endregion

        #region Mở lớp
        #endregion

        #region SV đăng ký
        #endregion

        #region Phân công giảng dạy
        #endregion

        #region Thời khóa biểu
        #endregion

        #region Kết quả học tập
        #endregion

        #region Quản lý danh mục

        private void bt_QLPhongHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmPhongHoc phonghoc = new FrmPhongHoc();
            phonghoc.Dock = DockStyle.Fill;
            phonghoc.MdiParent = this;
            phonghoc.Show();
        }

        private void bt_QLKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmKhoa khoa = new FrmKhoa();
            khoa.Dock = DockStyle.Fill;
            khoa.MdiParent = this;
            khoa.Show();
        }


        private void bt_QLNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNganh nganh = new FrmNganh();
            nganh.Dock = DockStyle.Fill;
            nganh.MdiParent = this;
            nganh.Show();
        }

        #endregion

        #region Hệ thống
        #endregion

    }
}
