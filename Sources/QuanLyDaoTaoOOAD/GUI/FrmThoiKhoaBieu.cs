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
    public partial class FrmThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_ThoiKhoaBieu dto_thoikhoabieu = new DTO_ThoiKhoaBieu();
        BUS_ThoiKhoaBieu bus_thoikhoabieu = new BUS_ThoiKhoaBieu();
        BUS_GiangDay bus_giangday = new BUS_GiangDay();
        BUS_BuoiHoc bus_buoihoc = new BUS_BuoiHoc();
        BUS_PhongHoc bus_phonghoc = new BUS_PhongHoc();

        private void khoaInput()
        {
            cb_MaGiangDay.Enabled = false;
            cb_MaBuoiHoc.Enabled = false;
            cb_MaPhongHoc.Enabled = false;
            tb_CoDay.Enabled = false;
        }

        private void moInput()
        {
            cb_MaGiangDay.Enabled = true;
            cb_MaBuoiHoc.Enabled = true;
            cb_MaPhongHoc.Enabled = true;
            tb_CoDay.Enabled = true;
        }

        private void xoaInput()
        {
            cb_MaGiangDay.SelectedItem = null;
            cb_MaBuoiHoc.SelectedItem = null;
            cb_MaPhongHoc.SelectedItem = null;
            tb_CoDay.Text = "";
        }


        public FrmThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void FrmGiangDay_Load(object sender, EventArgs e)
        {
            bus_thoikhoabieu = new BUS_ThoiKhoaBieu();
            dg_DanhSachThoiKhoaBieu.DataSource = bus_thoikhoabieu.TaobangThoiKhoaBieu("");
            khoaInput();

            foreach (DataRow datarow in bus_giangday.TaobangGiangDay("").Rows)
            {
                cb_MaGiangDay.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_buoihoc.TaobangBuoiHoc("").Rows)
            {
                cb_MaBuoiHoc.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_phonghoc.TaobangPhongHoc("").Rows)
            {
                cb_MaPhongHoc.Properties.Items.Add(datarow[0]);
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
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa thời khóa biểu này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_thoikhoabieu.MaGD = cb_MaGiangDay.SelectedItem.ToString();
                dto_thoikhoabieu.MaBH = cb_MaBuoiHoc.SelectedItem.ToString();
                dto_thoikhoabieu.MaPhong = cb_MaPhongHoc.SelectedItem.ToString();

                bus_thoikhoabieu.XoadulieuThoiKhoaBieu(dto_thoikhoabieu);
                dg_DanhSachThoiKhoaBieu.DataSource = bus_thoikhoabieu.TaobangThoiKhoaBieu("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (cb_MaGiangDay.SelectedItem != null && cb_MaBuoiHoc.SelectedItem != null && cb_MaPhongHoc.SelectedItem != null && tb_CoDay.Text != "")
            {
                dto_thoikhoabieu.MaGD = cb_MaGiangDay.SelectedItem.ToString();
                dto_thoikhoabieu.MaBH = cb_MaBuoiHoc.SelectedItem.ToString();
                dto_thoikhoabieu.MaPhong = cb_MaPhongHoc.SelectedItem.ToString();
                dto_thoikhoabieu.CoDay = tb_CoDay.Text;

                try
                {
                    if (Them)
                    {
                        bus_thoikhoabieu.ThemdulieuThoiKhoaBieu(dto_thoikhoabieu);
                    }
                    else
                    {
                        bus_thoikhoabieu.SuadulieuThoiKhoaBieu(dto_thoikhoabieu);
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
                dg_DanhSachThoiKhoaBieu.DataSource = bus_thoikhoabieu.TaobangThoiKhoaBieu("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thời khóa biểu", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cb_MaGiangDay.Text = dg_DanhSachThoiKhoaBieu.CurrentRow.Cells[0].Value.ToString();
                cb_MaBuoiHoc.Text = dg_DanhSachThoiKhoaBieu.CurrentRow.Cells[1].Value.ToString();
                cb_MaPhongHoc.Text = dg_DanhSachThoiKhoaBieu.CurrentRow.Cells[2].Value.ToString();
                tb_CoDay.Text = dg_DanhSachThoiKhoaBieu.CurrentRow.Cells[3].Value.ToString();

                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void tb_CoDay_KeyPress(object sender, KeyPressEventArgs e)
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
