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
using System.Data.SqlClient;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_MonHoc bus_mh = new BUS_MonHoc();
        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Text = bus_mh.TuTinhMa();
                txtTenMH.Focus();
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
                DTO_MonHoc mh = new DTO_MonHoc();
                if (!string.IsNullOrEmpty(txtMaMH.Text))
                    mh.MaMH = txtMaMH.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Mã môn học không được để trống");
                    txtMaMH.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtTenMH.Text))
                    mh.TenMH = txtTenMH.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Tên môn học không được để trống");
                    txtTenMH.Focus();
                    return;
                }
                if (numSTC.Value > 0)
                    mh.STC = numSTC.Value.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Số tín chỉ không thể nhỏ hơn 0");
                    numSTC.Focus();
                    return;
                }

                if (numLyThuyet.Value > 0)
                    mh.LyThuyet = numLyThuyet.Value.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Số tiết lý thuyết không thể nhỏ hơn 0");
                    numLyThuyet.Focus();
                    return;
                }

                if (numThucHanh.Value >= 0)
                    mh.ThucHanh = numThucHanh.Value.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Số tiết thực hành không thể nhỏ hơn 0");
                    numThucHanh.Focus();
                    return;
                }

                if (numThucHanh.Value + numLyThuyet.Value != numSTC.Value)
                {
                    MessageBoxUtils.Exclamation("Tổng số tiết lý thuyết và thực hành phải bằng số tín chỉ");
                    numSTC.Focus();
                    return;
                }
                bus_mh.ThemdulieuMonHoc(mh);
                MessageBoxUtils.Success("Thành công");
                btnHuy_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ClearText()
        {
            txtMaMH.ResetText();    
            txtTenMH.ResetText();
            numSTC.Value = 0;
            numLyThuyet.Value = 3;
            numThucHanh.Value = 0;
            txtMaMH.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox("Môn học đã tồn tại");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}