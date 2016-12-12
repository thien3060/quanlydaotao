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
    public partial class frmCapNhatNganhHoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_Nganh bus_nganh = new BUS_Nganh();

        public frmCapNhatNganhHoc()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private bool check(DTO_Nganh nh)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaNganh.Text))
                    nh.MaNganh = txtMaNganh.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Mã ngành học không được để trống");
                    txtMaNganh.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtTenNganh.Text))
                    nh.TenNganh = txtTenNganh.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Tên ngành học không được để trống");
                    txtTenNganh.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtKhoa.Text))
                    nh.Khoa = txtKhoa.Text;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmCapNhatNganhHoc_Load(object sender, EventArgs e)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Nganh nh = NganhHocHienTai();
                if (check(nh))
                {
                    bus_nganh.SuadulieuNganh(nh);
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
                if (MessageBoxUtils.YesNo("Bạn muốn xóa ngành học " + txtTenNganh.Text + "?") == DialogResult.Yes)
                {
                    bus_nganh.XoadulieuNganh(NganhHocHienTai());
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

        private DTO_Nganh NganhHocHienTai()
        {
            return new DTO_Nganh(txtMaNganh.Text, txtTenNganh.Text, txtKhoa.Text);
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_nganh.TaobangNganh("");
            gridControl1.DataSource = nguon;

            txtMaNganh.DataBindings.Clear();
            txtMaNganh.DataBindings.Add("Text", nguon, "MaNganh");
            txtTenNganh.DataBindings.Clear();
            txtTenNganh.DataBindings.Add("Text", nguon, "TenNganh");
            txtKhoa.DataBindings.Clear();
            txtKhoa.DataBindings.Add("Text", nguon, "Khoa");
        }
    }
}