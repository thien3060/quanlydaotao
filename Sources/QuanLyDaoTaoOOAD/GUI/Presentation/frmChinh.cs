﻿using System;
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
using System.IO;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            try
            {

                timer1_Tick(null, null);
                //đăng nhập và phân quyền
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                PhanQuyen();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
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
                xtraTabControl1.Visible = true;
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
                xtraTabControl1.Visible = false;
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

        private void btnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSuaThongTinSinhVien frm = new frmSuaThongTinSinhVien();
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void btnThongTinSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinSinhVien frm = new frmThongTinSinhVien();
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

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

        private void btnXemDSLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDanhSachLop frm = new frmDanhSachLop();
                TabCreating("Xem danh sách lớp", frm);
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Giảng Viên

        private void btnCapNhatGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSuaThongTinGiangVien frm = new frmSuaThongTinGiangVien();
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void btnThongTinGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThongTinGiangVien frm = new frmThongTinGiangVien();
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void btnXemPC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemPhanCongGiangDay frm = new frmXemPhanCongGiangDay();
                TabCreating("Phân công giảng dạy", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnInPC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmInPhanCongGiangDay frm = new frmInPhanCongGiangDay();
                TabCreating("In phân công giảng dạy", frm);
            }
            catch (Exception)
            {

            }
        }

        private void btnThemDeNghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemDeNghi frm = new frmThemDeNghi();
                TabCreating("Đề nghị giảng dạy", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnXemDeNghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemDeNghi frm = new frmXemDeNghi();
                TabCreating("Xem các đề nghị", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
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
        private void btnXemTKBGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuGiangVien frm = new frmXemThoiKhoaBieuGiangVien();
                TabCreating("Giảng viên xem thời khóa biểu tuần", frm);
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

        private void btnCapNhatLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatLop frm = new frmCapNhatLop();
                TabCreating("Cập nhật thông tin lớp", frm);
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

        private void btnCapNhatNganhHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatNganhHoc frm = new frmCapNhatNganhHoc();
                TabCreating("Cập nhật ngành học", frm);
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

        private void btnCapNhatMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatMonHoc frm = new frmCapNhatMonHoc();
                TabCreating("Cập nhật môn học", frm);
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

        private void btnCapNhatGV_giaoVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatGiangVien frm = new frmCapNhatGiangVien();
                TabCreating("Cập nhật giảng viên", frm);
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

        private void btnCapNhatTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatTrinhDo frm = new frmCapNhatTrinhDo();
                TabCreating("Cập nhật trình độ", frm);
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

        private void btnCapNhatPhongHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatPhongHoc frm = new frmCapNhatPhongHoc();
                TabCreating("Cập nhật phòng học", frm);
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

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                string fileName = "";
                BUS.BUS_Backup backup = new BUS.BUS_Backup();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup file (*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = save.FileName;
                    fileName = Path.GetFileName(path);
                    path = path.Substring(0, path.Length - (fileName.Length + 1));
                    backup.BackupDatabase(fileName, path);
                    
                    this.Cursor = Cursors.Default;
                    MessageBoxUtils.Success("Sao lưu CSDL thành công!");                    
                }

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                BUS.BUS_Backup backup = new BUS.BUS_Backup();
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup file (*.bak)|*.bak";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = open.FileName;
                    backup.RestoreDatabase(path);
                    this.Cursor = Cursors.Default;
                    MessageBoxUtils.Success("Phục hồi CSDL thành công!");
                }

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                lblNgayGio.Caption = now.ToString("HH:mm") + " ngày " + now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }
    }
}