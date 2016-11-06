using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDaoTao
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void backstageViewButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
    }
}
