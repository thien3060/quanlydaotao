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

namespace QuanLyDaoTao.Presentation
{
    public partial class frmPhanCongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhanCong bus_phancong = new BUS_PhanCong();
        BUS_GiangVien bus_giangvien = new BUS_GiangVien();
        BUS_MonHoc bus_monhoc = new BUS_MonHoc();
        BUS_Lop bus_lop = new BUS_Lop();

        public frmPhanCongGiangDay()
        {
            InitializeComponent();
        }
        
        private DataTable nguon;

        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaPC.Text = bus_phancong.TuTinhMa();
                cmbGiangVien.Properties.DataSource = bus_giangvien.TaobangGiangVien("");
                cmbGiangVien.EditValue = cmbGiangVien.Properties.GetDataSourceValue("MaGV", 0);
                cmbMonHoc.Properties.DataSource = bus_monhoc.TaobangMonHoc("");
                cmbMonHoc.EditValue = cmbMonHoc.Properties.GetDataSourceValue("MaMH", 0);
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
                cmbLop.EditValue = cmbLop.Properties.GetDataSourceValue("MaLop", 0);                
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
                txtMaPC.Text = bus_phancong.TuTinhMa();
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
                dateNamHoc.EditValue = new DateTime(2014, 1, 1, 0, 0, 0, 0);
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
            nguon = bus_phancong.TaobangPhanCong("");
            gridControl1.DataSource = nguon;
        }
    }
}