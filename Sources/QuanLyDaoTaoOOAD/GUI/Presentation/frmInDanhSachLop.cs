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
    public partial class frmInDanhSachLop : DevExpress.XtraEditors.XtraForm
    {
        DataTable source;
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_Nganh bus_nganh = new BUS_Nganh();
        string masv;
        string malop;
        public frmInDanhSachLop()
        {
            InitializeComponent();
        }

        private void Set_cmbLop_cmbNganh()
        {
            try
            {
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
                //neu dang nhap bang quyen sinh vien
                if (int.Parse(StaticClass.User.Quyen) == (int)QuyenNguoiDung.SinhVien)
                {
                    masv = StaticClass.User.TenDangNhap.ToUpper();
                    malop = bus_sv.GetSinhVienbyID(masv).MaLop;
                    cmbLop.Properties.ReadOnly = true;
                    cmbLop.EditValue = malop;
                }
                else//dang nhap bang quyen admin
                {
                    cmbLop.Properties.ReadOnly = false;
                    cmbLop.EditValue = cmbLop.Properties.GetDataSourceValue("MaLop", 0);
                    malop = cmbLop.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmInDanhSachLop_Load(object sender, EventArgs e)
        {
            try
            {
                Set_cmbLop_cmbNganh();
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
        
        private void btnIn_Click(object sender, EventArgs e)
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

        private void cmbLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                malop = cmbLop.EditValue.ToString();
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void CapNhatDuLieuBang()
        {
            source = bus_sv.GetDanhSachLop(malop);
            gridControl1.DataSource = source;
        }
    }
}