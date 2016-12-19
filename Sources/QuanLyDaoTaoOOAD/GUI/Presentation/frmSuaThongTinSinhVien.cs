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
    public partial class frmSuaThongTinSinhVien : DevExpress.XtraEditors.XtraForm
    {
        DTO_SinhVien sv = new DTO_SinhVien();
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_Lop bus_lop = new BUS_Lop();

        public frmSuaThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void frmSuaThongTinSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                sv = bus_sv.GetSinhVienbyID(StaticClass.User.TenDangNhap.ToUpper());
                txtMSSV.Text = sv.MSSV;
                txtHoTen.Text = sv.HoTen;
                dateNgaySinh.EditValue = sv.NgaySinh;
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
                cmbLop.EditValue = sv.MaLop;
                txtDiaChi.Text = sv.DiaChi;
                
                txtDiaChi.Focus();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    sv.DiaChi = txtDiaChi.Text.Trim();
                if (!string.IsNullOrEmpty(dateNgaySinh.Text))
                    sv.NgaySinh = dateNgaySinh.DateTime;
                if (!string.IsNullOrEmpty(cmbLop.Text))
                    sv.MaLop = cmbLop.EditValue.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Hãy chọn lớp cho sinh viên này");
                    cmbLop.Focus();
                    return;
                }
                bus_sv.SuadulieuSinhVien(sv);
                MessageBoxUtils.Success("Đã cập nhật thay đổi vào CSDL");
                txtDiaChi.Text = sv.DiaChi;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}