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
    public partial class FrmHocVi : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_HocVi dto_hocvi = new DTO_HocVi();
        BUS_HocVi bus_hocvi = new BUS_HocVi();

        private void khoaInput()
        {
            tb_MaHocVi.Enabled = false;
            tb_TenHocVi.Enabled = false;
            tb_MoTa.Enabled = false;
        }

        private void moInput()
        {
            tb_MaHocVi.Enabled = false;
            tb_TenHocVi.Enabled = true;
            tb_MoTa.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaHocVi.Text = "";
            tb_TenHocVi.Text = "";
            tb_MoTa.Text = "";
        }


        public FrmHocVi()
        {
            InitializeComponent();
        }

        private void FrmHocVi_Load(object sender, EventArgs e)
        {
            dg_DanhSachHocVi.DataSource = bus_hocvi.TaobangHocVi("");
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

            tb_MaHocVi.Text = bus_hocvi.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaHocVi.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa học vị này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_hocvi.MaHV = tb_MaHocVi.Text;
                bus_hocvi.XoadulieuHocVi(dto_hocvi);
                dg_DanhSachHocVi.DataSource = bus_hocvi.TaobangHocVi("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaHocVi.Text != "" && tb_TenHocVi.Text != "" && tb_MoTa.Text != "")
            {

                dto_hocvi.MaHV = tb_MaHocVi.Text;
                dto_hocvi.TenHV = tb_TenHocVi.Text;
                dto_hocvi.MoTa = tb_MoTa.Text;

                try
                {
                    if (Them)
                    {
                        bus_hocvi.ThemdulieuHocVi(dto_hocvi);
                    }
                    else
                    {
                        bus_hocvi.SuadulieuHocVi(dto_hocvi);
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
                dg_DanhSachHocVi.DataSource = bus_hocvi.TaobangHocVi("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học vị", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaHocVi.Text = dg_DanhSachHocVi.CurrentRow.Cells[0].Value.ToString();
                tb_TenHocVi.Text = dg_DanhSachHocVi.CurrentRow.Cells[1].Value.ToString();                
                tb_MoTa.Text = dg_DanhSachHocVi.CurrentRow.Cells[2].Value.ToString();

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
