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
using QuanLyDaoTao.Utils;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            labelQuyen.Text = StaticClass.User.MoTaQuyen;
            labelTen.Text = StaticClass.User.TenNguoiDung;
        }
    }
}