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
    public partial class FrmHeDT : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_HeDT dto_hedt = new DTO_HeDT();
        BUS_HeDT bus_hedt = new BUS_HeDT();

        private void khoaInput()
        {
            tb_MaHeDT.Enabled = false;
            tb_TenHeDT.Enabled = false;
        }

        private void moInput()
        {
            tb_MaHeDT.Enabled = false;
            tb_TenHeDT.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaHeDT.Text = "";
            tb_TenHeDT.Text = "";
        }


        public FrmHeDT()
        {
            InitializeComponent();
        }

        private void FrmHeDT_Load(object sender, EventArgs e)
        {
            bus_hedt = new BUS_HeDT();
            dg_DanhSachHeDT.DataSource = bus_hedt.TaobangHeDT("");
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
            tb_MaHeDT.Text = bus_hedt.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaHeDT.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa hệ đào tạo này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_hedt.MaHDT = tb_MaHeDT.Text;
                bus_hedt.XoadulieuHeDT(dto_hedt);
                dg_DanhSachHeDT.DataSource = bus_hedt.TaobangHeDT("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaHeDT.Text != "" && tb_TenHeDT.Text != "")
            {
                dto_hedt.MaHDT = tb_MaHeDT.Text;
                dto_hedt.TenHDT = tb_TenHeDT.Text;

                try
                {
                    if (Them)
                    {
                        bus_hedt.ThemdulieuHeDT(dto_hedt);
                    }
                    else
                    {
                        bus_hedt.SuadulieuHeDT(dto_hedt);
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
                dg_DanhSachHeDT.DataSource = bus_hedt.TaobangHeDT("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hệ đào tạo", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaHeDT.Text = dg_DanhSachHeDT.CurrentRow.Cells[0].Value.ToString();
                tb_TenHeDT.Text = dg_DanhSachHeDT.CurrentRow.Cells[1].Value.ToString();

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
