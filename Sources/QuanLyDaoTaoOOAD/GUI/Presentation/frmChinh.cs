using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utils;
using DevExpress.XtraTab;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        #region Xử lý add form vào xtra tab control

        protected void TabCreating(string tabTitle, XtraForm frm)
        {
            int Index = KiemTraTonTai(tabTitle);
            if (Index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[Index];
                xtraTabControl1.SelectedTabPage.Text = tabTitle;
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = tabTitle };
                TabPage.AutoScroll = true;
                xtraTabControl1.TabPages.Add(TabPage);
                xtraTabControl1.SelectedTabPage = TabPage;
                TabPage.AutoScroll = true;
                //TabPage.AutoScrollMargin = new Size(20, 20);
                TabPage.AutoScrollMinSize = new Size(TabPage.Width, TabPage.Height);
                

                frm.TopLevel = false;
                frm.Parent = TabPage;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private int KiemTraTonTai(string tabName)
        {
            int temp = -1;
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == tabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabControl TabControl = (XtraTabControl)sender;
                int i = TabControl.SelectedTabPageIndex;
                TabControl.TabPages[i].Dispose();
                if (i > 0)
                    TabControl.SelectedTabPageIndex = i - 1;
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Các hàm không phải hàm xử lý sự kiện

        private void PhanQuyen()
        {
            DTO.DTO_NguoiDung user = new DTO.DTO_NguoiDung();
            try
            {
                if (StaticClass.DangNhap)
                {
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnThongTin.Enabled = true;
                    //Admin
                    if (StaticClass.User.Quyen.Equals("0"))
                    {
                        rpSinhVien.Visible = true;
                        rpGiangVien.Visible = true;
                        rpGiaoVu.Visible = true;
                        rpAdmin.Visible = true;
                        return;
                    }
                    //GiaoVu
                    if (StaticClass.User.Quyen.Equals("1"))
                    {
                        rpSinhVien.Visible = false;
                        rpGiangVien.Visible = false;
                        rpGiaoVu.Visible = true;
                        rpAdmin.Visible = false;
                        return;
                    }
                    //GiangVien
                    if (StaticClass.User.Quyen.Equals("2"))
                    {
                        rpSinhVien.Visible = false;
                        rpGiangVien.Visible = true;
                        rpGiaoVu.Visible = false;
                        rpAdmin.Visible = false;
                        return;
                    }
                    //SinhVien
                    if (StaticClass.User.Quyen.Equals("3"))
                    {
                        rpSinhVien.Visible = true;
                        rpGiangVien.Visible = false;
                        rpGiaoVu.Visible = false;
                        rpAdmin.Visible = false;
                        return;
                    }
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                else//chua dang nhap
                {
                    btnDangNhap.Enabled = true;
                    btnDangXuat.Enabled = false;
                    btnDoiMatKhau.Enabled = false;
                    btnThongTin.Enabled = false;

                    rpSinhVien.Visible = false;
                    rpGiangVien.Visible = false;
                    rpGiaoVu.Visible = false;
                    rpAdmin.Visible = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NhanForm(XtraForm frm)
        {
            try
            {
                TabCreating(frm.Text, frm);
            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region Trang Chính

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                else
                {
                    lblQuyen.Caption = "Bạn chưa đăng nhập.";
                    lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                }
                PhanQuyen();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinNguoiDung frm = new frmThongTinNguoiDung();
            frm.ShowDialog();
        }

        private void btnReStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception)
            {

            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thoát chương trình?", "Quản lý đạo tạo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StaticClass.DangNhap = false;
                StaticClass.User = null;
                PhanQuyen();
                xtraTabControl1.TabPages.Clear();
                lblQuyen.Caption = "Bạn chưa đăng nhập.";
                lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                MessageBoxUtils.Info("Bạn đã đăng xuất.\nVui lòng đăng nhập để sử dụng hệ thống.");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        #endregion

        #region Sinh Viên
        private void btnXemTKBSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuSinhVien frm = new frmXemThoiKhoaBieuSinhVien();
                TabCreating("Sinh viên xem thời khóa biểu tuần", frm);
            }
            catch (Exception)
            {
                
            }
        }
        #endregion

        #region Giảng Viên

        private void btnThemDeNghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemDeNghi frm = new frmThemDeNghi();
                TabCreating("Đề nghị giảng dạy", frm);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnXemPhieuGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemPhieuGiangDay frm = new frmXemPhieuGiangDay();
                TabCreating("GV xem phiếu giảng dạy", frm);
            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region Giáo Vụ

        private void btnXepTKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXepThoiKhoaBieu frm = new frmXepThoiKhoaBieu();
                TabCreating("Xếp thời khóa biểu", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnXemTKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuSinhVien frm = new frmXemThoiKhoaBieuSinhVien();
                TabCreating("Sinh viên xem thời khóa biểu tuần", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmPhanCongGiangDay frm = new frmPhanCongGiangDay();
                TabCreating("Phân công giảng dạy", frm);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnNhapPhieuGiangDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmNhapPhieuGiangDay frm = new frmNhapPhieuGiangDay();
                TabCreating("Nhập phiếu giảng dạy", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnThemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemSinhVien frm = new frmThemSinhVien();
                TabCreating("Thêm sinh viên", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnCapNhatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatSinhVien frm = new frmCapNhatSinhVien();
                TabCreating("Cập nhật thông tin sinh viên", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemLopHoc frm = new frmThemLopHoc();
                TabCreating("Lớp học mới", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnNganhHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemNganhHoc frm = new frmThemNganhHoc();
                TabCreating("Ngành học mới", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnThemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemMonHoc frm = new frmThemMonHoc();
                TabCreating("Môn học mới", frm);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnGiangVienMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemGiangVien frm = new frmThemGiangVien();
                TabCreating("Giảng viên mới", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemTrinhDo frm = new frmThemTrinhDo();
                TabCreating("Trình độ mới", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnPhongHocMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemPhongHoc frm = new frmThemPhongHoc();
                TabCreating("Phòng học mới", frm);
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Quản Trị Hệ Thống

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDanhMucNguoiDung frm = new frmDanhMucNguoiDung();
                TabCreating("Danh mục người dùng", frm);
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Trợ giúp

        private void btnHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThongTinChuongTrinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinChuongTrinh frm = new frmThongTinChuongTrinh();
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void btnThongTinTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmGioiThieu frm = new frmGioiThieu();
                frm.ShowDialog();
            }
            catch (Exception)
            {
                
            }
        }

        #endregion
    }
}