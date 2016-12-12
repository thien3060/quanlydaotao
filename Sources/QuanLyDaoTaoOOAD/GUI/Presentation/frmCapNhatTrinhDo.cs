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
    public partial class frmCapNhatTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        BUS_TDDT bus_trinhdo = new BUS_TDDT();

        public frmCapNhatTrinhDo()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatTrinhDo_Load(object sender, EventArgs e)
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

        private bool check(DTO_TDDT td)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaTrinhDo.Text))
                    td.MaTrinhDo = txtMaTrinhDo.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Mã trình độ không được để trống");
                    txtMaTrinhDo.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(txtTenTrinhDo.Text))
                    td.TenTrinhDo = txtTenTrinhDo.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return false;
                }
                if (numLuong.Value > 0)
                    td.HeSoLuong = numLuong.Value.ToString();
                else
                {
                    MessageBoxUtils.Exclamation("Tên trình độ không được để trống");
                    txtTenTrinhDo.Focus();
                    return false;
                }

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
                DTO_TDDT td = TrinhDoHienTai();
                if (check(td))
                {
                    bus_trinhdo.SuadulieuTDDT(td);
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
                if (MessageBoxUtils.YesNo("Bạn muốn xóa trình độ " + txtTenTrinhDo.Text + "?") == DialogResult.Yes)
                {
                    bus_trinhdo.XoadulieuTDDT(TrinhDoHienTai());
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

        private DTO_TDDT TrinhDoHienTai()
        {
            return new DTO_TDDT(txtMaTrinhDo.Text, txtTenTrinhDo.Text, numLuong.Text);
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_trinhdo.TaobangTDDT("");
            gridControl1.DataSource = nguon;

            txtMaTrinhDo.DataBindings.Clear();
            txtMaTrinhDo.DataBindings.Add("Text", nguon, "MaTrinhDo");
            txtTenTrinhDo.DataBindings.Clear();
            txtTenTrinhDo.DataBindings.Add("Text", nguon, "TenTrinhDo");
            numLuong.DataBindings.Clear();
            numLuong.DataBindings.Add("Text", nguon, "HeSoLuong");
        }
    }
}