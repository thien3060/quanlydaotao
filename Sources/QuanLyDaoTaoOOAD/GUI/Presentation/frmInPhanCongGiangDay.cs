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
        
        private DataTable nguon;

        private void frmInPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                cmbGiangVien.Properties.DataSource = bus_giangvien.TaobangGiangVien("");
                cmbGiangVien.EditValue = cmbGiangVien.Properties.GetDataSourceValue("MaGV", 0);           
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_phancong.GetPhanCong(dto_phancong);
            gridControl1.DataSource = nguon;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                dto_phancong.MaGV = cmbGiangVien.EditValue.ToString();
                dto_phancong.HocKy = (int) numHocKy.Value;
                dto_phancong.NamHoc = dateNamHoc.DateTime.Year;
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
    }
}