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
    public partial class frmXemPhanCongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhanCong bus_phancong = new BUS_PhanCong();
        BUS_GiangVien bus_giangvien = new BUS_GiangVien();
        BUS_MonHoc bus_monhoc = new BUS_MonHoc();
        BUS_Lop bus_lop = new BUS_Lop();

        public frmXemPhanCongGiangDay()
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

        private void Set_numHocKy()
        {
            try
            {
                int thang = DateTime.Today.Month;
                if (thang >= 8)//hoc ky 1
                    numHocKy.Value = 1;
                else if (thang >= 1 && thang <= 5)//hoc ky 2
                    numHocKy.Value = 2;
                else
                    numHocKy.Value = 3;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable nguon;

        private void frmXemPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                Set_cmbGiangVien();
                Set_numHocKy();
                cmbMonHoc.Properties.DataSource = bus_monhoc.TaobangMonHoc("");
                cmbMonHoc.ReadOnly = true;
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
                cmbLop.ReadOnly = true;
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_PhanCong dto_phancong = new DTO_PhanCong();
                dto_phancong.MaPC = bus_phancong.TuTinhMa();
                dto_phancong.HocKy = (int) numHocKy.Value;
                dto_phancong.NamHoc = dateNamHoc.DateTime.Year;

                dto_phancong.MaGV = cmbGiangVien.EditValue.ToString();
                dto_phancong.MaLop = cmbLop.EditValue.ToString();
                dto_phancong.MaMH = cmbMonHoc.EditValue.ToString();

                bus_phancong.ThemdulieuPhanCong(dto_phancong);
                CapNhatDuLieuBang();
                ClearText();
                MessageBoxUtils.Success("Đã cập nhật thay đổi vào CSDL");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            try
            {
                txtMaPC.ResetText();
                numHocKy.Value = 1;
                dateNamHoc.EditValue = new DateTime(2017, 1, 1, 0, 0, 0, 0);
                cmbGiangVien.ResetText();
                cmbLop.ResetText();
                cmbMonHoc.ResetText();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CapNhatDuLieuBang()
        {
            if (dateNamHoc.EditValue != null)
                nguon = bus_phancong.ThongTinPhanCongTheoGV(cmbGiangVien.EditValue.ToString(), int.Parse(numHocKy.EditValue.ToString()), DateTime.Parse(dateNamHoc.EditValue.ToString()).Year);
            else
              nguon = bus_phancong.ThongTinPhanCongTheoGV(cmbGiangVien.EditValue.ToString(), int.Parse(numHocKy.EditValue.ToString()), DateTime.Now.Year);
            gridControl1.DataSource = nguon;

            txtMaPC.DataBindings.Clear();
            txtMaPC.DataBindings.Add("Text", nguon, "MaPC");
            numHocKy.DataBindings.Clear();
            numHocKy.DataBindings.Add("EditValue", nguon, "HocKy");
            //dateNamHoc.DataBindings.Clear();
            //dateNamHoc.DataBindings.Add("EditValue", nguon, "NamHoc");
            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("EditValue", nguon, "MaMH");
            cmbLop.DataBindings.Clear();
            cmbLop.DataBindings.Add("EditValue", nguon, "MaLop");
        }

        private void cmbGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }
    }
}