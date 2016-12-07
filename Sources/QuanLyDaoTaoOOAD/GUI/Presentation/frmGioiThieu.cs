﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmGioiThieu : DevExpress.XtraEditors.XtraForm
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        int GetYearString()
        {
            int ret = DateTime.Now.Year;
            return (ret < 2012 ? 2012 : ret);
        }

        private void frmGioiThieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}