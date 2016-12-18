using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao.UserControls
{
    public partial class MotTiet : UserControl
    {
        public MotTiet()
        {
            InitializeComponent();
        }

        public string MonHoc
        {
            get { return lblMonHoc.Text; }
            set { lblMonHoc.Text = value; }
        }

        public string PhongHoc
        {
            get { return lblPhong.Text; }
            set { lblPhong.Text = value; }
        }
    }
}
