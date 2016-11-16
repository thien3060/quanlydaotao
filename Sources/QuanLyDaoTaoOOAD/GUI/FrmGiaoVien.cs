using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyDaoTao
{
    public partial class FrmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_GiaoVien dto_gv = new DTO_GiaoVien();
        BUS_GiaoVien bus_gv = new BUS_GiaoVien();

        private void khoaInput()
        {
            tb_MaGV.Enabled = false;
            tb_CMND.Enabled = false;
            tb_DiaChi.Enabled = false;
            tb_HoTen.Enabled = false;
            rb_GTNam.Enabled = false;
            rb_GTNu.Enabled = false;
            cb_Ma_Khoa.Enabled = false;
            cb_MaHV.Enabled = false;
            dt_NgaySinh.Enabled = false;
        }

        private void moInput()
        {
            tb_MaGV.Enabled = false;
            tb_CMND.Enabled = true;
            tb_DiaChi.Enabled = true;
            tb_HoTen.Enabled = true;
            rb_GTNam.Enabled = true;
            rb_GTNu.Enabled = true;
            cb_Ma_Khoa.Enabled = true;
            cb_MaHV.Enabled = true;
            dt_NgaySinh.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaGV.Text = "";
            tb_CMND.Text = "";
            tb_DiaChi.Text = "";
            tb_HoTen.Text = "";
            rb_GTNam.Checked = false;
            rb_GTNu.Checked = false;
        }


        public FrmGiaoVien()
        {
            InitializeComponent();
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            bus_gv = new BUS_GiaoVien();
            dg_DanhSachGV.DataSource = bus_gv.TaobangGiaoVien("");
            khoaInput();
            bt_Luu.Enabled = false;

            tb_MaGV.Text = dg_DanhSachGV.Rows[0].Cells[0].Value.ToString();
            tb_HoTen.Text = dg_DanhSachGV.Rows[0].Cells[1].Value.ToString();
            dt_NgaySinh.Text = dg_DanhSachGV.Rows[0].Cells[2].Value.ToString();
            tb_DiaChi.Text = dg_DanhSachGV.Rows[0].Cells[3].Value.ToString(); 
            tb_CMND.Text = dg_DanhSachGV.Rows[0].Cells[5].Value.ToString(); 

            if (Int32.Parse(dg_DanhSachGV.Rows[0].Cells[4].Value.ToString()) == 1)
                rb_GTNam.Checked = true;
            else
                rb_GTNu.Checked = true;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Them.Enabled = false;

            moInput();
            xoaInput();
            tb_MaGV.Text = bus_gv.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaGV.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giáo viên này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_gv.MaGV = tb_MaGV.Text;
                bus_gv.XoadulieuGiaoVien(dto_gv);
                dg_DanhSachGV.DataSource = bus_gv.TaobangGiaoVien("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaGV.Text != "" && tb_CMND.Text != "" && tb_DiaChi.Text != "" && tb_HoTen.Text != "" && dt_NgaySinh.Text != "")
            {
                if (DateTime.Now.Year - DateTime.Parse(dt_NgaySinh.Text).Year < 18)
                {
                    MessageBox.Show("Giáo viên phải lớn hơn 18 tuổi", "Lỗi");
                }
                else
                {
                    dto_gv.MaGV = tb_MaGV.Text;
                    dto_gv.CMND = tb_CMND.Text;
                    dto_gv.DiaChi = tb_DiaChi.Text;
                    dto_gv.HoTenGV = tb_HoTen.Text;
                    dto_gv.MaHV = "HV001";
                    dto_gv.MaKhoa = "KH001";
                    dto_gv.NgaySinh = Convert.ToDateTime(dt_NgaySinh.Text);
                    if (rb_GTNu.Checked)
                        dto_gv.GioiTinh = "0";
                    else
                        dto_gv.GioiTinh = "1";

                    try
                    {
                        if (Them)
                        {
                            bus_gv.ThemdulieuGiaoVien(dto_gv);
                        }
                        else
                        {
                            bus_gv.SuadulieuGiaoVien(dto_gv);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                        //MessageBox.Show("Lỗi hệ thống", "Lỗi");
                    }

                    khoaInput();
                    bt_Sua.Enabled = true;
                    bt_Xoa.Enabled = true;
                    bt_Them.Enabled = true;
                    bt_Luu.Enabled = false;
                    dg_DanhSachGV.DataSource = bus_gv.TaobangGiaoVien("");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giáo viên", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaGV.Text = dg_DanhSachGV.Rows[0].Cells[0].Value.ToString();
                tb_HoTen.Text = dg_DanhSachGV.Rows[0].Cells[1].Value.ToString();
                dt_NgaySinh.Text = dg_DanhSachGV.Rows[0].Cells[2].Value.ToString();
                tb_DiaChi.Text = dg_DanhSachGV.Rows[0].Cells[3].Value.ToString();
                tb_CMND.Text = dg_DanhSachGV.Rows[0].Cells[5].Value.ToString();

                if (Int32.Parse(dg_DanhSachGV.Rows[0].Cells[4].Value.ToString()) == 1)
                    rb_GTNam.Checked = true;
                else
                    rb_GTNu.Checked = true;

                cb_Ma_Khoa.Text = dg_DanhSachGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                cb_MaHV.Text = dg_DanhSachGV.Rows[e.RowIndex].Cells[7].Value.ToString();

                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void tb_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
