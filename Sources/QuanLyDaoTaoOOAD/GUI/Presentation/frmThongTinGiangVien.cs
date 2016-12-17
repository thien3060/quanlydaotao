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
                txtHoTen.Text = gv.HoTen;
                if (gv.GioiTinh)
                    txtGioiTinh.Text = "Nam";
                else
                    txtGioiTinh.Text = "Nữ";
                cmbTrinhDo.Properties.DataSource = bus_td.TaobangTDDT("");
                cmbTrinhDo.EditValue = gv.MaTrinhDo;
                txtDiaChi.Text = gv.DiaChi;
                
                txtDiaChi.Focus();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    gv.DiaChi = txtDiaChi.Text.Trim();
                else
                {
                    MessageBoxUtils.Exclamation("Địa chỉ không được để trống");
                    return;
                }

                bus_gv.SuadulieuGiangVien(gv);
                MessageBoxUtils.Success("Đã cập nhật thay đổi vào CSDL");
                txtDiaChi.Text = gv.DiaChi;
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