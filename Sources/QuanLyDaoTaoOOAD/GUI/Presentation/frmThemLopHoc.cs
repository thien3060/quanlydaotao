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
using QuanLyDaoTao.Utilities;
using BUS;
using DTO;
using QuanLyDaoTao.Utils;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemLopHoc()
        {
            InitializeComponent();
        }

        private void frmThemLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                BUS_Nganh bus_nganh = new BUS_Nganh();
                cmbNganh.Properties.DataSource = bus_nganh.TaobangNganh("");
                cmbNganh.EditValue = cmbNganh.Properties.GetDataSourceValue("MaNganh", 0);
                dateBatDau.DateTime = DateTime.Now;
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void dateBatDau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdgBacHoc.SelectedIndex == 0)
                    dateKetThuc.DateTime = dateBatDau.DateTime.AddYears(4);
                else
                    dateKetThuc.DateTime = dateBatDau.DateTime.AddYears(3);
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void rdgBacHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dateBatDau_EditValueChanged(null, null);
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbNganh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TaoMaLop();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void TaoMaLop()
        {
            try
            {
                if (rdgBacHoc.SelectedIndex == 0)
                    txtMaLop.Text = "DH" + (dateBatDau.DateTime.Year + 1).ToString().Substring(2) + cmbNganh.EditValue.ToString();
                else
                    txtMaLop.Text = "CD" + (dateBatDau.DateTime.Year + 25).ToString().Substring(2) + cmbNganh.EditValue.ToString();
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
                DTO_Lop lop = new DTO_Lop() { MaLop = txtMaLop.Text, MaNganh = cmbNganh.EditValue.ToString() };
                BUS_Lop bus_lop = new BUS_Lop();
                bus_lop.ThemdulieuLop(lop);
                MessageBoxUtils.Success("Thành công");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}