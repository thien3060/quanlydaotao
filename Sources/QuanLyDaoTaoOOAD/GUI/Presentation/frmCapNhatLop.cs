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
    public partial class frmCapNhatLop : DevExpress.XtraEditors.XtraForm
    {
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_Nganh bus_ng = new BUS_Nganh();
        public frmCapNhatLop()
        {
            InitializeComponent();
        }

        private DataTable nguon;

        private void frmCapNhatLop_Load(object sender, EventArgs e)
        {
            try
            {
                CapNhatDuLieuBang();
                cmbLop.Properties.DataSource = bus_lop.TaobangLop("");
                cmbNganh.Properties.DataSource = bus_ng.TaobangNganh("");
                cmbLop.DataBindings.Clear();
                cmbLop.DataBindings.Add("EditValue", nguon, "MaLop");
                cmbNganh.DataBindings.Clear();
                cmbNganh.DataBindings.Add("EditValue", nguon, "MaNganh");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void toolStripMenuXoa_Click()
        {
            try
            {
                if (MessageBoxUtils.YesNo("Bạn muốn xóa lớp " + cmbLop.EditValue.ToString() + "?") == DialogResult.Yes)
                {
                    bus_lop.XoadulieuLop(LopHienTai());
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
                toolStripMenuXoa_Click();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private DTO_Lop LopHienTai()
        {
            return new DTO_Lop(cmbLop.EditValue.ToString(), cmbNganh.EditValue.ToString());
        }

        private void CapNhatDuLieuBang()
        {
            nguon = bus_lop.TaobangLop("");
            gridControl1.DataSource = nguon;
        }
    }
}