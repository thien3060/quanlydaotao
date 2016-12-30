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
using DTO;
using BUS;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Utils;
using QuanLyDaoTao.Enums;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmInPhanCongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        DTO_PhanCong dto_phancong = new DTO_PhanCong();
        BUS_PhanCong bus_phancong = new BUS_PhanCong();
        BUS_GiangVien bus_giangvien = new BUS_GiangVien();
        BUS_MonHoc bus_monhoc = new BUS_MonHoc();
        BUS_Lop bus_lop = new BUS_Lop();

        public frmInPhanCongGiangDay()
        {
            InitializeComponent();
        }

        private void Set_cmbGiangVien()
        {
            try
            {
                cmbGiangVien.Properties.DataSource = bus_giangvien.TaobangGiangVien("");
                //neu dang nhap bang quyen giang vien
                if (int.Parse(StaticClass.User.Quyen) == (int)QuyenNguoiDung.GiangVien)
                {
                    cmbGiangVien.EditValue = StaticClass.User.TenDangNhap.ToUpper();
                    cmbGiangVien.Properties.ReadOnly = true;
                }
                else//dang nhap bang quyen admin
                {
                    cmbGiangVien.Properties.ReadOnly = false;
                    cmbGiangVien.EditValue = cmbGiangVien.Properties.GetDataSourceValue("MaGV", 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable nguon;

        private void frmInPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                Set_cmbGiangVien();     
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void CapNhatDuLieuBang()
        {
            if (dateNamHoc.EditValue != null)
                nguon = bus_phancong.ThongTinPhanCongTheoGV(cmbGiangVien.EditValue.ToString(), int.Parse(numHocKy.EditValue.ToString()), DateTime.Parse(dateNamHoc.EditValue.ToString()).Year);
            else
                nguon = bus_phancong.ThongTinPhanCongTheoGV(cmbGiangVien.EditValue.ToString(), int.Parse(numHocKy.EditValue.ToString()), DateTime.Now.Year);
            gridControl1.DataSource = nguon;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
                MessageBoxUtils.Success("Đã lọc xong");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnInPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void numHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}