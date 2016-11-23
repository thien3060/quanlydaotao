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
    public partial class FrmGiangDay : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_GiangDay dto_giangday = new DTO_GiangDay();
        BUS_GiangDay bus_giangday = new BUS_GiangDay();
        BUS_GiaoVien bus_giaovien = new BUS_GiaoVien();
        BUS_NhomHP bus_nhomhp = new BUS_NhomHP();
        BUS_HocKy bus_hocky = new BUS_HocKy();

        private void khoaInput()
        {
            tb_MaGiangDay.Enabled = false;
            cb_MaGV.Enabled = false;
            cb_MaNhomHP.Enabled = false;
            cb_HocKy.Enabled = false;
            tb_GhiChuGD.Enabled = false;
        }

        private void moInput()
        {
            tb_MaGiangDay.Enabled = false;
            cb_MaGV.Enabled = true;
            cb_MaNhomHP.Enabled = true;
            cb_HocKy.Enabled = true;
            tb_GhiChuGD.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaGiangDay.Text = "";
            tb_GhiChuGD.Text = "";
            cb_MaGV.SelectedItem = null;
            cb_MaNhomHP.SelectedItem = null;
            cb_HocKy.SelectedItem = null;
        }


        public FrmGiangDay()
        {
            InitializeComponent();
        }

        private void FrmGiangDay_Load(object sender, EventArgs e)
        {
            bus_giangday = new BUS_GiangDay();
            dg_DanhSachGiangDay.DataSource = bus_giangday.TaobangGiangDay("");
            khoaInput();

            foreach (DataRow datarow in bus_giaovien.TaobangGiaoVien("").Rows)
            {
                cb_MaGV.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_nhomhp.TaobangNhomHP("").Rows)
            {
                cb_MaNhomHP.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_hocky.TaobangHocKy("").Rows)
            {
                cb_HocKy.Properties.Items.Add(datarow[0]);
            }

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
            tb_MaGiangDay.Text = bus_giangday.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaGiangDay.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giảng dạy này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_giangday.MaGV = tb_MaGiangDay.Text;
                bus_giangday.XoadulieuGiangDay(dto_giangday);
                dg_DanhSachGiangDay.DataSource = bus_giangday.TaobangGiangDay("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaGiangDay.Text != "" && tb_GhiChuGD.Text != "" && cb_MaGV.SelectedItem != null && cb_MaNhomHP.SelectedItem != null && cb_HocKy.SelectedItem != null)
            {
                dto_giangday.MaGD = tb_MaGiangDay.Text;
                dto_giangday.MaGV = cb_MaGV.SelectedItem.ToString();
                dto_giangday.MaNHP = cb_MaNhomHP.SelectedItem.ToString();
                dto_giangday.MaHK = cb_HocKy.SelectedItem.ToString();
                dto_giangday.GhiChuGD = tb_GhiChuGD.Text;

                try
                {
                    if (Them)
                    {
                        bus_giangday.ThemdulieuGiangDay(dto_giangday);
                    }
                    else
                    {
                        bus_giangday.SuadulieuGiangDay(dto_giangday);
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
                dg_DanhSachGiangDay.DataSource = bus_giangday.TaobangGiangDay("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giảng dạy", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaGiangDay.Text = dg_DanhSachGiangDay.CurrentRow.Cells[0].Value.ToString();
                cb_MaGV.Text = dg_DanhSachGiangDay.CurrentRow.Cells[1].Value.ToString();
                cb_MaNhomHP.Text = dg_DanhSachGiangDay.CurrentRow.Cells[2].Value.ToString();
                cb_HocKy.Text = dg_DanhSachGiangDay.CurrentRow.Cells[3].Value.ToString();
                tb_GhiChuGD.Text = dg_DanhSachGiangDay.CurrentRow.Cells[4].Value.ToString();

                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }
}
