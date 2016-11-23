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
    public partial class FrmKhoiLop : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_KhoiLop dto_khoilop = new DTO_KhoiLop();
        BUS_KhoiLop bus_khoilop = new BUS_KhoiLop();
        BUS_Khoa bus_khoa = new BUS_Khoa();
        BUS_HeDT bus_hedt = new BUS_HeDT();
        BUS_TDDT bus_tddt = new BUS_TDDT();

        private void khoaInput()
        {
            tb_MaKhoiLop.Enabled = false;
            tb_TenKhoiLop.Enabled = false;
            cb_MaKhoa.Enabled = false;
            cb_MaHeDT.Enabled = false;
            cb_MaTDDT.Enabled = false;
        }

        private void moInput()
        {
            tb_MaKhoiLop.Enabled = false;
            tb_TenKhoiLop.Enabled = true;
            cb_MaKhoa.Enabled = true;
            cb_MaHeDT.Enabled = true;
            cb_MaTDDT.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaKhoiLop.Text = "";
            tb_TenKhoiLop.Text = "";
            cb_MaKhoa.SelectedItem = null;
            cb_MaHeDT.SelectedItem = null;
            cb_MaTDDT.SelectedItem = null;
        }


        public FrmKhoiLop()
        {
            InitializeComponent();
        }

        private void FrmKhoiLop_Load(object sender, EventArgs e)
        {
            bus_khoilop = new BUS_KhoiLop();
            dg_DanhSachKhoiLop.DataSource = bus_khoilop.TaobangKhoiLop("");
            khoaInput();

            foreach (DataRow datarow in bus_khoa.TaobangKhoa("").Rows)
            {
                cb_MaKhoa.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_hedt.TaobangHeDT("").Rows)
            {
                cb_MaHeDT.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_tddt.TaobangTDDT("").Rows)
            {
                cb_MaTDDT.Properties.Items.Add(datarow[0]);
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
            tb_MaKhoiLop.Text = bus_khoilop.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khối lớp này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_khoilop.MaKL = tb_MaKhoiLop.Text;

                bus_khoilop.XoadulieuKhoiLop(dto_khoilop);
                dg_DanhSachKhoiLop.DataSource = bus_khoilop.TaobangKhoiLop("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaKhoiLop.Text != "" && tb_TenKhoiLop.Text != "" && cb_MaKhoa.SelectedItem != null && cb_MaHeDT.SelectedItem != null && cb_MaTDDT.SelectedItem != null)
            {
                dto_khoilop.MaKL = tb_MaKhoiLop.Text;
                dto_khoilop.TenKL = tb_TenKhoiLop.Text;
                dto_khoilop.MaKhoa = cb_MaKhoa.SelectedItem.ToString();
                dto_khoilop.MaHDT = cb_MaHeDT.SelectedItem.ToString();
                dto_khoilop.MaTDDT = cb_MaTDDT.SelectedItem.ToString();

                try
                {
                    if (Them)
                    {
                        bus_khoilop.ThemdulieuKhoiLop(dto_khoilop);
                    }
                    else
                    {
                        bus_khoilop.SuadulieuKhoiLop(dto_khoilop);
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
                dg_DanhSachKhoiLop.DataSource = bus_khoilop.TaobangKhoiLop("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khối lớp", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cb_MaHeDT.Text = dg_DanhSachKhoiLop.CurrentRow.Cells[0].Value.ToString();
                cb_MaTDDT.Text = dg_DanhSachKhoiLop.CurrentRow.Cells[1].Value.ToString();
                                
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
