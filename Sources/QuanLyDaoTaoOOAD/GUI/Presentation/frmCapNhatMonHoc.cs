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
    public partial class frmCapNhatMonHoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_MonHoc bus_monhoc = new BUS_MonHoc();

        public frmCapNhatMonHoc()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatMonHoc_Load(object sender, EventArgs e)
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
                bus_monhoc.SuadulieuMonHoc(MonHocHienTai());
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
                if (MessageBoxUtils.YesNo("Bạn muốn xóa môn học " + txtTenMH.Text + "?") == DialogResult.Yes)
                {
                    bus_monhoc.XoadulieuMonHoc(MonHocHienTai());
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

        private DTO_MonHoc MonHocHienTai()
        {
            return new DTO_MonHoc(txtMaMH.Text, txtTenMH.Text, numSTC.Text, numLyThuyet.Text, numThucHanh.Text);
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_monhoc.TaobangMonHoc("");
            gridControl1.DataSource = nguon;

            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", nguon, "MaMH");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", nguon, "TenMH");
            numSTC.DataBindings.Clear();
            numSTC.DataBindings.Add("Text", nguon, "STC");
            numLyThuyet.DataBindings.Clear();
            numLyThuyet.DataBindings.Add("Text", nguon, "LyThuyet");
            numThucHanh.DataBindings.Clear();
            numThucHanh.DataBindings.Add("Text", nguon, "ThucHanh");
        }
    }
}