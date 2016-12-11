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
    public partial class frmThemGiangVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_NguoiDung bus_nd = new BUS_NguoiDung();
        BUS_TDDT bus_td = new BUS_TDDT();
        BUS_GiangVien bus_gv = new BUS_GiangVien();
        public frmThemGiangVien()
        {
            InitializeComponent();
        }

        private bool TaoMoi(DTO_GiangVien gv)
        {
            try
            {
                gv.MaGV = txtMaGV.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    gv.HoTen = txtHoTen.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Họ tên giảng viên không được để trống");
                    txtHoTen.Focus();
                    return false;
                }
                if (rdgGioiTinh.SelectedIndex == 0)
                    gv.GioiTinh = false;
                else gv.GioiTinh = true;
                gv.MaTrinhDo = cmbTrinhDo.EditValue.ToString();
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    gv.DiaChi = txtDiaChi.Text.Trim();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTrinhDo.Properties.DataSource = bus_td.TaobangTDDT("");
                cmbTrinhDo.EditValue = cmbTrinhDo.Properties.GetDataSourceValue("MaTrinhDo", 0);
                txtMaGV.Text = bus_gv.TuTinhMa();
                txtHoTen.Focus();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_GiangVien gv = new DTO_GiangVien();
                if (TaoMoi(gv))
                {
                    DTO_NguoiDung user = new DTO_NguoiDung()
                    {
                        TenDangNhap = gv.MaGV.ToLower(),
                        MatKhau = UtilitiesClass.MaHoaMD5(gv.MaGV),
                        TenNguoiDung = gv.HoTen,
                        Quyen = "2",
                        MoTaQuyen = "Giảng viên"
                    };
                    bus_gv.ThemdulieuGiangVien(gv);
                    bus_nd.ThemdulieuNguoiDung(user);
                    MessageBoxUtils.Success("Thành công");
                    ClearText();
                    txtMaGV.Text = bus_gv.TuTinhMa();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}