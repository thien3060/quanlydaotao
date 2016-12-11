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
    public partial class frmThemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_NguoiDung bus_nd = new BUS_NguoiDung();
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_Lop bus_lop = new BUS_Lop();
        string _matKhau;
        public frmThemSinhVien()
        {
            try
            {
                InitializeComponent();
                _matKhau = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

        private void ClearText()
        {
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.Focus();
        }

        private bool TaoMoi(DTO_SinhVien sv)
        {

                sv.MSSV = txtMSSV.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    sv.HoTen = txtHoTen.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Họ tên sinh viên không được để trống");
                    txtHoTen.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(dateNgaySinh.Text))
                    sv.NgaySinh = dateNgaySinh.DateTime;
                if (!string.IsNullOrEmpty(cmbLop.Text))
                    sv.MaLop = cmbLop.EditValue.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Hãy chọn lớp cho sinh viên này");
                    cmbLop.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    sv.DiaChi = txtDiaChi.Text.Trim();
                return true;

        }

        #endregion

        private void TaoMa()
        {
            try
            {
                string lop = cmbLop.EditValue.ToString();
                string dinhDang = lop.Substring(0, 1) + lop.Substring(4, 2);
                if (dinhDang[0] == 'D')
                    dinhDang = dinhDang.Insert(3, (int.Parse(lop.Substring(2, 2)) - 1).ToString());
                else
                    dinhDang = dinhDang.Insert(3, (int.Parse(lop.Substring(2, 2)) - 25).ToString());
                txtMSSV.Text = bus_sv.TuTinhMa(dinhDang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLop.Properties.DataSource =bus_lop.TaobangLop("");
                cmbLop.EditValue = cmbLop.Properties.GetDataSourceValue("MaLop", 0);
                dateNgaySinh.DateTime = DateTime.Now.AddYears(-18);
                TaoMa();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                DTO_SinhVien sv = new DTO_SinhVien();
                if (TaoMoi(sv))
                {
                    _matKhau = sv.MSSV;
                    DTO_NguoiDung user = new DTO_NguoiDung()
                    {
                        TenDangNhap = sv.MSSV.ToLower(),
                        MatKhau = UtilitiesClass.MaHoaMD5(_matKhau),
                        TenNguoiDung = sv.HoTen,
                        Quyen = "3",
                        MoTaQuyen = "Sinh viên"
                    };
                    bus_nd.ThemdulieuNguoiDung(user);
                    bus_sv.ThemdulieuSinhVien(sv);
                    MessageBoxUtils.Success("Thành công");
                    ClearText();
                    TaoMa();
                }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        /// <summary>
        /// Hàm nhận mật khẩu từ form con
        /// </summary>
        private void GetMatKhau(string value)
        {
            _matKhau = value;
        }

        private void cmbLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TaoMa();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}