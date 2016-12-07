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
    public partial class FrmPhongHoc : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_PhongHoc dto_ph = new DTO_PhongHoc();
        BUS_PhongHoc bus_ph = new BUS_PhongHoc();

        private void khoaInput()
        {
            tb_MaPhong.Enabled = false;
            tb_SucChua.Enabled = false;
            tb_DiaChi.Enabled = false;
            tb_ChucNang.Enabled = false;
        }

        private void moInput()
        {
            tb_MaPhong.Enabled = false;
            tb_SucChua.Enabled = true;
            tb_DiaChi.Enabled = true;
            tb_ChucNang.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaPhong.Text = "";
            tb_SucChua.Text = "";
            tb_DiaChi.Text = "";
            tb_ChucNang.Text = "";
        }


        public FrmPhongHoc()
        {
            InitializeComponent();
        }

        private void FrmPhongHoc_Load(object sender, EventArgs e)
        {
            bus_ph = new BUS_PhongHoc();
            dg_DanhSachGV.DataSource = bus_ph.TaobangPhongHoc("");
            khoaInput();
            bt_Luu.Enabled = false;
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Them.Enabled = false;

            moInput();
            xoaInput();
            tb_MaPhong.Text = bus_ph.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaPhong.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa phòng học này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_ph.MaPhong = tb_MaPhong.Text;
                bus_ph.XoadulieuPhongHoc(dto_ph);
                dg_DanhSachGV.DataSource = bus_ph.TaobangPhongHoc("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaPhong.Text != "" && tb_SucChua.Text != "" && tb_DiaChi.Text != "" && tb_ChucNang.Text != "")
            {
                dto_ph.MaPhong = tb_MaPhong.Text;
                dto_ph.SucChua = tb_SucChua.Text;
                dto_ph.DiaChi = tb_DiaChi.Text;
                dto_ph.ChucNang = tb_ChucNang.Text;

                try
                {
                    if (Them)
                    {
                        bus_ph.ThemdulieuPhongHoc(dto_ph);
                    }
                    else
                    {
                        bus_ph.SuadulieuPhongHoc(dto_ph);
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
                dg_DanhSachGV.DataSource = bus_ph.TaobangPhongHoc("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng học", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaPhong.Text = dg_DanhSachGV.CurrentRow.Cells[0].Value.ToString();
                tb_ChucNang.Text = dg_DanhSachGV.CurrentRow.Cells[1].Value.ToString();
                tb_SucChua.Text = dg_DanhSachGV.CurrentRow.Cells[2].Value.ToString();
                tb_DiaChi.Text = dg_DanhSachGV.CurrentRow.Cells[3].Value.ToString();

                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void tb_SucChua_KeyPress(object sender, KeyPressEventArgs e)
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
