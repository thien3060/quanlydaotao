using System;
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

        #endregion

        #region Kế hoạch

        private void bt_ChuongTrinhDaoTao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            ChuongTrinhDaoTao ctdt = new ChuongTrinhDaoTao();
            ctdt.Dock = DockStyle.Fill;
            ctdt.MdiParent = this;
            ctdt.Show();
        }

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

        //TODO: Thông tin trường

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

        private void bt_QLDayNha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //TODO: Giáo dục

        private void bt_QLSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

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

        private void bt_QLKHDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmKHDT khdt = new FrmKHDT();
            khdt.Dock = DockStyle.Fill;
            khdt.MdiParent = this;
            khdt.Show();
        }

        private void bt_QLNamHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNamHoc namhoc = new FrmNamHoc();
            namhoc.Dock = DockStyle.Fill;
            namhoc.MdiParent = this;
            namhoc.Show();
        }

        private void bt_QLHocKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmHocKy hocky = new FrmHocKy();
            hocky.Dock = DockStyle.Fill;
            hocky.MdiParent = this;
            hocky.Show();
        }

        private void bt_QLBuoiHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBuoiHoc buoihoc = new FrmBuoiHoc();
            buoihoc.Dock = DockStyle.Fill;
            buoihoc.MdiParent = this;
            buoihoc.Show();
        }

        private void bt_QLGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmGiangDay giangday = new FrmGiangDay();
            giangday.Dock = DockStyle.Fill;
            giangday.MdiParent = this;
            giangday.Show();
        }

        private void bt_QLTKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmThoiKhoaBieu thoikhoabieu = new FrmThoiKhoaBieu();
            thoikhoabieu.Dock = DockStyle.Fill;
            thoikhoabieu.MdiParent = this;
            thoikhoabieu.Show();
        }

        //TODO: Cơ cấu tổ chức

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

        private void bt_QLKhoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmKhoiLop khoilop = new FrmKhoiLop();
            khoilop.Dock = DockStyle.Fill;
            khoilop.MdiParent = this;
            khoilop.Show();
        }

        private void bt_QLNhomLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNhomLop nhomlop = new FrmNhomLop();
            nhomlop.Dock = DockStyle.Fill;
            nhomlop.MdiParent = this;
            nhomlop.Show();
        }

        private void bt_QLNhomHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNhomHP nhomhp = new FrmNhomHP();
            nhomhp.Dock = DockStyle.Fill;
            nhomhp.MdiParent = this;
            nhomhp.Show();
        }

        private void bt_QLHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmHocPhan hocphan = new FrmHocPhan();
            hocphan.Dock = DockStyle.Fill;
            hocphan.MdiParent = this;
            hocphan.Show();
        }

        private void bt_gvcn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmGVCN gvcn = new FrmGVCN();
            gvcn.Dock = DockStyle.Fill;
            gvcn.MdiParent = this;
            gvcn.Show();
        }

        //TODO: Danh mục chung

        private void bt_QLChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmChucVu chucvu = new FrmChucVu();
            chucvu.Dock = DockStyle.Fill;
            chucvu.MdiParent = this;
            chucvu.Show();
        }

        private void bt_QLHocVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmHocVi hocvi = new FrmHocVi();
            hocvi.Dock = DockStyle.Fill;
            hocvi.MdiParent = this;
            hocvi.Show();
        }

        private void bt_QLHeDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmHeDT hedt = new FrmHeDT();
            hedt.Dock = DockStyle.Fill;
            hedt.MdiParent = this;
            hedt.Show();
        }

        private void bt_QLTDDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmTDDT tddt = new FrmTDDT();
            tddt.Dock = DockStyle.Fill;
            tddt.MdiParent = this;
            tddt.Show();
        }

        private void bt_QLDamNhiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmDamNhiem damnhiem = new FrmDamNhiem();
            damnhiem.Dock = DockStyle.Fill;
            damnhiem.MdiParent = this;
            damnhiem.Show();
        }

        //TODO: Admin

        private void bt_QLNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNguoiDung nguoidung = new FrmNguoiDung();
            nguoidung.Dock = DockStyle.Fill;
            nguoidung.MdiParent = this;
            nguoidung.Show();
        }



        #endregion

        #region Hệ thống
        #endregion
    }
}
