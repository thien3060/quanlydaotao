using System;
using System.Windows.Forms;
using BUS;
using DTO;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Utils;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            try
            {
                BUS_Login bus_login = new BUS_Login();
                BUS_NguoiDung bus_dangnhap = new BUS_NguoiDung();
                if (bus_dangnhap.KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
                {
                    DTO_NguoiDung user = new DTO_NguoiDung();
                    user.TenDangNhap = txtTenDangNhap.Text.Trim();
                    user = bus_login.LayThongTiNguoiDung(txtTenDangNhap.Text.Trim());
                    if (user.MatKhau == UtilitiesClass.MaHoaMD5(txtMatKhau.Text))
                    {
                        StaticClass.User = user;
                        StaticClass.DangNhap = true; DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBoxUtils.Exclamation("Mật khẩu không đúng.");
                        txtMatKhau.Focus();
                        txtMatKhau.SelectAll();
                        return;
                    }
                }
                else
                {
                    MessageBoxUtils.Exclamation("Người dùng không tồn tại");
                    txtTenDangNhap.Focus();
                    txtTenDangNhap.SelectAll();
                    return;
                }

        }
            catch (Exception ex)
            {
                MessageBoxUtils.Error(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        public bool KiemTra()
        {
            try
            {
                if (txtTenDangNhap.Text.Trim().Length == 0)
                {
                    MessageBoxUtils.Exclamation("Bạn chưa nhập Tên người dùng");
                    txtTenDangNhap.Focus();
                    return false;
                }
                if (txtMatKhau.Text.Trim().Length == 0)
                {
                    MessageBoxUtils.Exclamation("Bạn chưa nhập Mật khẩu");
                    txtMatKhau.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}