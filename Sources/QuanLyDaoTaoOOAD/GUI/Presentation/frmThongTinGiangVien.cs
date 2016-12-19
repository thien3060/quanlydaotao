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
    public partial class frmThongTinGiangVien : DevExpress.XtraEditors.XtraForm
    {
        DTO_GiangVien gv = new DTO_GiangVien();
        BUS_GiangVien bus_gv = new BUS_GiangVien();
        BUS_TDDT bus_td = new BUS_TDDT();

        public frmThongTinGiangVien()
        {
            InitializeComponent();
        }

        private void frmThongTinGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                gv = bus_gv.GetGiangVienbyID(StaticClass.User.TenDangNhap.ToUpper());
                labelHoTen.Text = gv.HoTen;
                if (gv.GioiTinh)
                    labelGioiTinh.Text = "Nam";
                else
                    labelGioiTinh.Text = "Nữ";
                DataTable trinhdo = bus_td.TaobangTDDT("");                
                DataRow tentrinhdo = trinhdo.Select("MaTrinhDo = '" + gv.MaTrinhDo + "'")[0];
                labelTrinhDo.Text = tentrinhdo.ItemArray[1].ToString();
                labelDiaChi.Text = gv.DiaChi;

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