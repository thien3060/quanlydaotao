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
    public partial class frmCapNhatGiangVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_GiangVien bus_giangvien = new BUS_GiangVien();
        BUS_TDDT bus_td = new BUS_TDDT();

        public frmCapNhatGiangVien()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTrinhDo.Properties.DataSource = bus_td.TaobangTDDT("");
                cmbTrinhDo.EditValue = cmbTrinhDo.Properties.GetDataSourceValue("MaTrinhDo", 0);
                CapNhatDuLieuBang();          
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
                bus_giangvien.SuadulieuGiangVien(GiangVienHienTai());
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
                if (MessageBoxUtils.YesNo("Bạn muốn xóa giảng viên " + txtHoTen.Text + "?") == DialogResult.Yes)
                {
                    bus_giangvien.XoadulieuGiangVien(GiangVienHienTai());
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

        private DTO_GiangVien GiangVienHienTai()
        {
            bool gioitinh;
            if (rdgGioiTinh.SelectedIndex == 0)
                gioitinh = false;
            else gioitinh = true;

            return new DTO_GiangVien(txtMaGV.Text, txtHoTen.Text, rdgGioiTinh.Text, gioitinh, cmbTrinhDo.EditValue.ToString());
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_giangvien.TaobangGiangVien("");
            gridControl1.DataSource = nguon;

            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", nguon, "MaGV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", nguon, "HoTen");
            rdgGioiTinh.DataBindings.Clear();
            rdgGioiTinh.DataBindings.Add("SelectedIndex", nguon, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nguon, "DiaChi");
            cmbTrinhDo.DataBindings.Clear();
            cmbTrinhDo.DataBindings.Add("EditValue", nguon, "MaTrinhDo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tim = UtilitiesClass.convertToUnSign3(txtTimKiem.Text);
                nguon = bus_giangvien.TaobangGiangVien(" Where MaGV like '%" + tim + "%' or dbo.fnChuyenKhongDau(HoTen) like '%" + tim + "%'");
                gridControl1.DataSource = nguon;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}