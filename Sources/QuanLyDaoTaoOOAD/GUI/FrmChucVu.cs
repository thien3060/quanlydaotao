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
    public partial class FrmChucVu : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_ChucVu dto_chucvu = new DTO_ChucVu();
        BUS_ChucVu bus_chucvu = new BUS_ChucVu();

        private void khoaInput()
        {
            tb_MaChucVu.Enabled = false;
            tb_TenChucVu.Enabled = false;
        }

        private void moInput()
        {
            tb_MaChucVu.Enabled = false;
            tb_TenChucVu.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaChucVu.Text = "";
            tb_TenChucVu.Text = "";
        }


        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            bus_chucvu = new BUS_ChucVu();
            dg_DanhSachChucVu.DataSource = bus_chucvu.TaobangChucVu("");
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
            tb_MaChucVu.Text = bus_chucvu.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaChucVu.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa chức vụ này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_chucvu.MaCV = tb_MaChucVu.Text;
                bus_chucvu.XoadulieuChucVu(dto_chucvu);
                dg_DanhSachChucVu.DataSource = bus_chucvu.TaobangChucVu("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaChucVu.Text != "" && tb_TenChucVu.Text != "")
            {
                dto_chucvu.MaCV = tb_MaChucVu.Text;
                dto_chucvu.TenCV = tb_TenChucVu.Text;

                try
                {
                    if (Them)
                    {
                        bus_chucvu.ThemdulieuChucVu(dto_chucvu);
                    }
                    else
                    {
                        bus_chucvu.SuadulieuChucVu(dto_chucvu);
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
                dg_DanhSachChucVu.DataSource = bus_chucvu.TaobangChucVu("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chức vụ", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaChucVu.Text = dg_DanhSachChucVu.CurrentRow.Cells[0].Value.ToString();
                tb_TenChucVu.Text = dg_DanhSachChucVu.CurrentRow.Cells[1].Value.ToString();

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
