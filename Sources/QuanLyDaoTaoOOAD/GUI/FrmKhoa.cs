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
    public partial class FrmKhoa : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_Khoa dto_khoa = new DTO_Khoa();
        BUS_Khoa bus_khoa = new BUS_Khoa();

        private void khoaInput()
        {
            tb_MaKhoa.Enabled = false;
            tb_TenKhoa.Enabled = false;
        }

        private void moInput()
        {
            tb_MaKhoa.Enabled = false;
            tb_TenKhoa.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaKhoa.Text = "";
            tb_TenKhoa.Text = "";
        }


        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            bus_khoa = new BUS_Khoa();
            dg_DanhSachKhoa.DataSource = bus_khoa.TaobangKhoa("");
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
            tb_MaKhoa.Text = bus_khoa.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaKhoa.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khoa này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_khoa.MaKhoa = tb_MaKhoa.Text;
                bus_khoa.XoadulieuKhoa(dto_khoa);
                dg_DanhSachKhoa.DataSource = bus_khoa.TaobangKhoa("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaKhoa.Text != "" && tb_TenKhoa.Text != "")
            {
                dto_khoa.MaKhoa = tb_MaKhoa.Text;
                dto_khoa.TenKhoa = tb_TenKhoa.Text;

                try
                {
                    if (Them)
                    {
                        bus_khoa.ThemdulieuKhoa(dto_khoa);
                    }
                    else
                    {
                        bus_khoa.SuadulieuKhoa(dto_khoa);
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
                dg_DanhSachKhoa.DataSource = bus_khoa.TaobangKhoa("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khoa", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaKhoa.Text = dg_DanhSachKhoa.CurrentRow.Cells[0].Value.ToString();
                tb_TenKhoa.Text = dg_DanhSachKhoa.CurrentRow.Cells[1].Value.ToString();

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
