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
using System.Text.RegularExpressions;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmCapNhatSinhVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_Lop bus_lop = new BUS_Lop();
        public frmCapNhatSinhVien()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
                txtMSSV.DataBindings.Clear();
                txtMSSV.DataBindings.Add("Text", nguon, "MSSV");
                txtHoTen.DataBindings.Clear();
                txtHoTen.DataBindings.Add("Text", nguon, "HoTen");
                dateNgaySinh.DataBindings.Clear();
                dateNgaySinh.DataBindings.Add("DateTime", nguon, "NgaySinh");
                cmbLop.DataBindings.Clear();
                cmbLop.DataBindings.Add("EditValue", nguon, "MaLop");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", nguon, "DiaChi");

                LayNguonChoLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void LayNguonChoLop()
        {
            try
            {
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bus_sv.SuadulieuSinhVien(SinhVienHienTai());
                CapNhatDuLieuBang();
                MessageBoxUtils.Success("Đã cập nhật thay đổi vào CSDL");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void toolStripMenuXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxUtils.YesNo("Bạn muốn xóa sinh viên " + txtMSSV.Text + "?") == DialogResult.Yes)
                {
                    bus_sv.XoadulieuSinhVien(SinhVienHienTai());
                    CapNhatDuLieuBang();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuXoa_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private DTO_SinhVien SinhVienHienTai()
        {
            return new DTO_SinhVien(txtMSSV.Text, txtHoTen.Text, dateNgaySinh.DateTime, txtDiaChi.Text, cmbLop.EditValue.ToString());
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_sv.TaobangSinhVien("");
            gridControl1.DataSource = nguon;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tim = UtilitiesClass.convertToUnSign3(txtTimKiem.Text);
                nguon = bus_sv.TaobangSinhVien(" Where MSSV like '%" + tim + "%' or dbo.fnChuyenKhongDau(HoTen) like '%" + tim + "%'");
                gridControl1.DataSource = nguon;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}