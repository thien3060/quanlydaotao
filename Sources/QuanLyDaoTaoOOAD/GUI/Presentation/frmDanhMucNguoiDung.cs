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
    public partial class frmDanhMucNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        BUS_NguoiDung bus_nd = new BUS_NguoiDung();

        DataTable source;
        string matKhau;
        public frmDanhMucNguoiDung()
        {
            InitializeComponent();
        }
        private void frmDanhMucNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                source = bus_nd.TaobangNguoiDung("");
                gridControl1.DataSource = source;

                txtTenDangNhap.DataBindings.Clear();
                txtTenDangNhap.DataBindings.Add("Text", source, "TenDangNhap");
                txtHoTen.DataBindings.Clear();
                txtHoTen.DataBindings.Add("Text", source, "TenNguoiDung");
                txtQuyen.DataBindings.Clear();
                txtQuyen.DataBindings.Add("Text", source, "MoTaQuyen");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmMatKhau frm = new frmMatKhau();
            frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bus_nd.ThietLapLaiMatKhau(txtTenDangNhap.Text, UtilitiesClass.MaHoaMD5(matKhau));
                MessageBoxUtils.Success("Đã thiết lập lại mật khẩu cho \"" + txtTenDangNhap.Text + "\"");
            }
        }

        private void GetMatKhau(string value)
        {
            matKhau = value;
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

        private void btnThemGiaoVu_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenDangNhap.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtQuyen.DataBindings.Clear();

                txtQuyen.Text = "Giáo vụ";
                txtQuyen.Properties.ReadOnly = true;
                txtQuyen.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}