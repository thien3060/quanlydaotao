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
    public partial class FrmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_NamHoc dto_namhoc = new DTO_NamHoc();
        BUS_NamHoc bus_namhoc = new BUS_NamHoc();

        private void khoaInput()
        {
            tb_MaNamHoc.Enabled = false;
            tb_TenNamHoc.Enabled = false;
        }

        private void moInput()
        {
            tb_MaNamHoc.Enabled = false;
            tb_TenNamHoc.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaNamHoc.Text = "";
            tb_TenNamHoc.Text = "";
        }


        public FrmNamHoc()
        {
            InitializeComponent();
        }

        private void FrmNamHoc_Load(object sender, EventArgs e)
        {
            bus_namhoc = new BUS_NamHoc();
            dg_DanhSachNamHoc.DataSource = bus_namhoc.TaobangNamHoc("");
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
            tb_MaNamHoc.Text = bus_namhoc.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaNamHoc.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa năm học này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_namhoc.MaNH = tb_MaNamHoc.Text;
                bus_namhoc.XoadulieuNamHoc(dto_namhoc);
                dg_DanhSachNamHoc.DataSource = bus_namhoc.TaobangNamHoc("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaNamHoc.Text != "" && tb_TenNamHoc.Text != "")
            {
                dto_namhoc.MaNH = tb_MaNamHoc.Text;
                dto_namhoc.TenNH = tb_TenNamHoc.Text;

                try
                {
                    if (Them)
                    {
                        bus_namhoc.ThemdulieuNamHoc(dto_namhoc);
                    }
                    else
                    {
                        bus_namhoc.SuadulieuNamHoc(dto_namhoc);
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
                dg_DanhSachNamHoc.DataSource = bus_namhoc.TaobangNamHoc("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin năm học", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaNamHoc.Text = dg_DanhSachNamHoc.CurrentRow.Cells[0].Value.ToString();
                tb_TenNamHoc.Text = dg_DanhSachNamHoc.CurrentRow.Cells[1].Value.ToString();

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
