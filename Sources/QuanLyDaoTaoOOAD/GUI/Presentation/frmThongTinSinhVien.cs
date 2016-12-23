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
    public partial class frmThongTinSinhVien : DevExpress.XtraEditors.XtraForm
    {
        DTO_SinhVien sv = new DTO_SinhVien();
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_TDDT bus_td = new BUS_TDDT();

        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                if (StaticClass.User.Quyen == "3")
                {

                    sv = bus_sv.GetSinhVienbyID(StaticClass.User.TenDangNhap.ToUpper());
                    labelMSSV.Text = sv.MSSV;
                    labelHoTen.Text = sv.HoTen;
                    labelNgaySinh.Text = sv.NgaySinh.ToString("dd-MM-yyyy");
                    labelDiaChi.Text = sv.DiaChi;

                }
                else
                {
                    lblMSSV.Visible = false;
                    lblHoTen.Visible = false;
                    lblNgaySinh.Visible = false;
                    lblDiaChi.Visible = false;

                    labelMSSV.Visible = false;
                    labelHoTen.Visible = false;
                    labelNgaySinh.Visible = false;
                    labelDiaChi.Visible = false;

                    lblThongBao.Visible = true;
                }

                btnDong.Focus();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}