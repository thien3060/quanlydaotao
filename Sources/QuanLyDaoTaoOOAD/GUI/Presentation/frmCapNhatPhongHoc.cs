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
    public partial class frmCapNhatPhongHoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhongHoc bus_phonghoc = new BUS_PhongHoc();

        public frmCapNhatPhongHoc()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatPhongHoc_Load(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private bool check(DTO_PhongHoc ph)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaPhong.Text))
                    ph.MaPhong = txtMaPhong.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Mã phòng không được rỗng");
                    return false;
                }
                if (!string.IsNullOrEmpty(txtChucNang.Text))
                    ph.ChucNang = txtChucNang.Text;

                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    ph.DiaChi = txtDiaChi.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Địa chỉ phòng không được rỗng");
                    return false;
                }
                ph.SucChua = numSucChua.Value.ToString();

                return true;
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
                DTO_PhongHoc ph = PhongHocHienTai();
                if (check(ph))
                {
                    bus_phonghoc.SuadulieuPhongHoc(ph);
                    CapNhatDuLieuBang();
                    MessageBoxUtils.Success("Đã cập nhật thay đổi vào CSDL");
                }
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
                if (MessageBoxUtils.YesNo("Bạn muốn xóa phòng học " + txtMaPhong.Text + "?") == DialogResult.Yes)
                {
                    bus_phonghoc.XoadulieuPhongHoc(PhongHocHienTai());
                    CapNhatDuLieuBang();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            try
            {
                txtMaPhong.ResetText();
                numSucChua.Value = 1;
                txtChucNang.ResetText();
                txtDiaChi.ResetText();
                txtMaPhong.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private DTO_PhongHoc PhongHocHienTai()
        {
            return new DTO_PhongHoc(txtMaPhong.Text, txtChucNang.Text, numSucChua.Text, txtDiaChi.Text);
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_phonghoc.TaobangPhongHoc("");
            gridControl1.DataSource = nguon;

            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("Text", nguon, "MaPhong");
            txtChucNang.DataBindings.Clear();
            txtChucNang.DataBindings.Add("Text", nguon, "ChucNang");
            numSucChua.DataBindings.Clear();
            numSucChua.DataBindings.Add("Text", nguon, "SucChua");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nguon, "DiaChi");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tim = UtilitiesClass.convertToUnSign3(txtTimKiem.Text);
                nguon = bus_phonghoc.TaobangPhongHoc(" Where MaPhong like '%" + tim + "%' or dbo.fnChuyenKhongDau(DiaChi) like '%" + tim + "%'");
                gridControl1.DataSource = nguon;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}