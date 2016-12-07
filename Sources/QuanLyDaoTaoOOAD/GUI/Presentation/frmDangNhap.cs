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
using BUS;
using DTO;
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
            try
            {
                BUS_NguoiDung bus_dangnhap = new BUS_NguoiDung();
                if (bus_dangnhap.KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
                {
                    DTO_NguoiDung user = new DTO_NguoiDung();
                    user.Quyen = "0";
                    StaticClass.User = user;
                    StaticClass.DangNhap = true;
                    DialogResult = DialogResult.OK;
                    this.Close();
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
    }
}