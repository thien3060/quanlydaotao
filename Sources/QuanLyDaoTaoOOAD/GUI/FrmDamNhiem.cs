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
    public partial class FrmDamNhiem : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_DamNhiem dto_damnhiem = new DTO_DamNhiem();
        BUS_DamNhiem bus_damnhiem = new BUS_DamNhiem();
        BUS_GiaoVien bus_giaovien = new BUS_GiaoVien();
        BUS_ChucVu bus_chucvu = new BUS_ChucVu();

        private void khoaInput()
        {
            cb_MaGV.Enabled = false;
            cb_MaCV.Enabled = false;
            dt_NgayNC.Enabled = false;
        }

        private void moInput()
        {
            cb_MaGV.Enabled = false;
            cb_MaCV.Enabled = true;
            dt_NgayNC.Enabled = true;
        }

        private void xoaInput()
        {
            cb_MaGV.SelectedItem = null;
            cb_MaCV.SelectedItem = null;
            dt_NgayNC.Text = "";
        }


        public FrmDamNhiem()
        {
            InitializeComponent();
        }

        private void FrmDamNhiem_Load(object sender, EventArgs e)
        {
            bus_damnhiem = new BUS_DamNhiem();
            dg_DanhSachDamNhiem.DataSource = bus_damnhiem.TaobangDamNhiem("");
            khoaInput();

            foreach (DataRow datarow in bus_giaovien.TaobangGiaoVien("").Rows)
            {
                cb_MaGV.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_chucvu.TaobangChucVu("").Rows)
            {
                cb_MaCV.Properties.Items.Add(datarow[0]);
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
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa đảm nhiệm này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_damnhiem.MaGV = cb_MaGV.SelectedItem.ToString();
                dto_damnhiem.MaCV = cb_MaCV.SelectedItem.ToString();

                bus_damnhiem.XoadulieuDamNhiem(dto_damnhiem);
                dg_DanhSachDamNhiem.DataSource = bus_damnhiem.TaobangDamNhiem("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (cb_MaGV.SelectedItem != null && cb_MaCV.SelectedItem != null && dt_NgayNC.Text != "")
            {
                dto_damnhiem.MaGV = cb_MaGV.SelectedItem.ToString();
                dto_damnhiem.MaCV = cb_MaCV.SelectedItem.ToString();
                dto_damnhiem.NgayNC = Convert.ToDateTime(dt_NgayNC.Text);

                try
                {
                    if (Them)
                    {
                        bus_damnhiem.ThemdulieuDamNhiem(dto_damnhiem);
                    }
                    else
                    {
                        bus_damnhiem.SuadulieuDamNhiem(dto_damnhiem);
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
                dg_DanhSachDamNhiem.DataSource = bus_damnhiem.TaobangDamNhiem("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đảm nhiệm", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cb_MaGV.Text = dg_DanhSachDamNhiem.CurrentRow.Cells[0].Value.ToString();
                cb_MaCV.Text = dg_DanhSachDamNhiem.CurrentRow.Cells[1].Value.ToString();
                dt_NgayNC.Text = dg_DanhSachDamNhiem.CurrentRow.Cells[2].Value.ToString();
                
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
