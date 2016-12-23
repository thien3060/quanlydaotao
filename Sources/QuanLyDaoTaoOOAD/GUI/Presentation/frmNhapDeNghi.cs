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
using BUS;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmNhapDeNghi : DevExpress.XtraEditors.XtraForm
    {
        BUS_DeNghi denghi = new BUS_DeNghi();
        string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        int hocKy;

        public int HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        int namHoc;

        public int NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }

        public frmNhapDeNghi()
        {
            InitializeComponent();
        }

        public delegate bool TruyenDulieu(int tietBD, int soTiet, string monHoc, string lop, string maPC);
        public TruyenDulieu truyen;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhanCong.EditValue != null)
                {
                    int tietBD = (int)numTietBatDau.Value - 1;
                    int soTiet = (int)numSoTiet.Value;
                    string maPC = cmbPhanCong.EditValue.ToString();
                    string monHoc = cmbPhanCong.Properties.GetDisplayText(cmbPhanCong.EditValue);
                    string lop = cmbPhanCong.Properties.GetDataSourceValue("MaLop", cmbPhanCong.Properties.GetDataSourceRowIndex("MaPC", maPC)).ToString();
                    if (truyen != null)
                    {
                        truyen(tietBD, soTiet, monHoc, lop, maPC);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmNhapDeNghi_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPhanCong.Properties.DataSource = denghi.ThongTinPhanCongTheoGV(maGV, hocKy, namHoc);
                cmbPhanCong.EditValue = cmbPhanCong.Properties.GetDataSourceValue("MaPC", 0);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}