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
    public partial class frmThemTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        BUS_TDDT bus_td = new BUS_TDDT();
        public frmThemTrinhDo()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_TDDT td = new DTO_TDDT();
                if (!string.IsNullOrEmpty(txtMaTrinhDo.Text))
                    td.MaTrinhDo = txtMaTrinhDo.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Mã trình độ không được để trống");
                    txtMaTrinhDo.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtTenTrinhDo.Text))
                    td.TenTrinhDo = txtTenTrinhDo.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return;
                }
                if (numLuong.Value > 0)
                    td.HeSoLuong = numLuong.Value.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return;
                }
                bus_td.ThemdulieuTDDT(td);
                MessageBoxUtils.Success("Thành công");
                btnHuy_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTrinhDo.ResetText();
            txtTenTrinhDo.ResetText();
            numLuong.Value = 50000;
        }
    }
}