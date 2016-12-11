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
using QuanLyDaoTao.Utils;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemNganhHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNganhHoc()
        {
            InitializeComponent();
        }

        private bool TaoMoi(DTO_Nganh nh)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Nganh nh = new DTO_Nganh();
                if (TaoMoi(nh))
                {
                    BUS_Nganh bus_nganh = new BUS_Nganh();
                    bus_nganh.ThemdulieuNganh(nh);
                    MessageBoxUtils.Success("Thành công");
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            txtMaNganh.ResetText();
            txtTenNganh.ResetText();
            txtKhoa.ResetText();
            txtMaNganh.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void frmThemNganhHoc_Load(object sender, EventArgs e)
        {
            txtMaNganh.Focus();
        }
    }
}