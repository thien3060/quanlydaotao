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
    public partial class frmThemPhongHoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhongHoc bus_ph = new BUS_PhongHoc();
        public frmThemPhongHoc()
        {
            InitializeComponent();
        }

        private void frmThemPhongHoc_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaPhong.Text = bus_ph.TuTinhMa();
                txtChucNang.Focus();
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
                DTO_PhongHoc p = new DTO_PhongHoc();
                if (!string.IsNullOrEmpty(txtMaPhong.Text))
                    p.MaPhong = txtMaPhong.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Mã phòng không được rỗng");
                    return;
                }
                if (!string.IsNullOrEmpty(txtChucNang.Text))
                    p.ChucNang = txtChucNang.Text;
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    p.DiaChi = txtDiaChi.Text;
                else
                {
                    MessageBoxUtils.Exclamation("Địa chỉ phòng không được rỗng");
                    return;
                }

                p.SucChua = numSucChua.Value.ToString();
                bus_ph.ThemdulieuPhongHoc(p);
                MessageBoxUtils.Success("Thành công!");
                ClearText();
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
                txtMaPhong.Text = bus_ph.TuTinhMa();
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
                ClearText();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}