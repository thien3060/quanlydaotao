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
    public partial class FrmBuoiHoc : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_BuoiHoc dto_buoihoc = new DTO_BuoiHoc();
        BUS_BuoiHoc bus_buoihoc = new BUS_BuoiHoc();

        private void khoaInput()
        {
            tb_MaBH.Enabled = false;
            dt_Ngay.Enabled = false;
            tb_TietBatDau.Enabled = false;
            tb_SoTiet.Enabled = false;
        }

        private void moInput()
        {
            tb_MaBH.Enabled = false;
            dt_Ngay.Enabled = true;
            tb_TietBatDau.Enabled = true;
            tb_SoTiet.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaBH.Text = "";
            dt_Ngay.Text = "";
            tb_TietBatDau.Text = "";
            tb_SoTiet.Text = "";
        }


        public FrmBuoiHoc()
        {
            InitializeComponent();
        }

        private void FrmBuoiHoc_Load(object sender, EventArgs e)
        {
            bus_buoihoc = new BUS_BuoiHoc();
            dg_DanhSachBuoiHoc.DataSource = bus_buoihoc.TaobangBuoiHoc("");
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
            tb_MaBH.Text = bus_buoihoc.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaBH.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa buổi học này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_buoihoc.MaBH = tb_MaBH.Text;
                bus_buoihoc.XoadulieuBuoiHoc(dto_buoihoc);
                dg_DanhSachBuoiHoc.DataSource = bus_buoihoc.TaobangBuoiHoc("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaBH.Text != "" && tb_TietBatDau.Text != "" && tb_SoTiet.Text != "" && dt_Ngay.Text != "")
            {
                dto_buoihoc.MaBH = tb_MaBH.Text;
                dto_buoihoc.Ngay = Convert.ToDateTime(dt_Ngay.Text);
                dto_buoihoc.TietBatDau = tb_TietBatDau.Text;
                dto_buoihoc.SoTiet = tb_SoTiet.Text;

                try
                {
                    if (Them)
                    {
                        bus_buoihoc.ThemdulieuBuoiHoc(dto_buoihoc);
                    }
                    else
                    {
                        bus_buoihoc.SuadulieuBuoiHoc(dto_buoihoc);
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
                dg_DanhSachBuoiHoc.DataSource = bus_buoihoc.TaobangBuoiHoc("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin buổi học", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaBH.Text = dg_DanhSachBuoiHoc.CurrentRow.Cells[0].Value.ToString();
                dt_Ngay.Text = dg_DanhSachBuoiHoc.CurrentRow.Cells[1].Value.ToString();
                tb_TietBatDau.Text = dg_DanhSachBuoiHoc.CurrentRow.Cells[2].Value.ToString();
                tb_SoTiet.Text = dg_DanhSachBuoiHoc.CurrentRow.Cells[3].Value.ToString();

                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
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
