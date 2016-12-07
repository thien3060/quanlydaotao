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
    public partial class FrmHocKy : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_HocKy dto_hocky = new DTO_HocKy();
        BUS_HocKy bus_hocky = new BUS_HocKy();
        BUS_Khoa bus_namhoc = new BUS_Khoa();

        private void khoaInput()
        {
            tb_MaHocKy.Enabled = false;
            tb_TenHocKy.Enabled = false;
            cb_MaNamHoc.Enabled = false;
        }

        private void moInput()
        {
            tb_MaHocKy.Enabled = false;
            tb_TenHocKy.Enabled = true;
            cb_MaNamHoc.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaHocKy.Text = "";
            tb_TenHocKy.Text = "";
        }


        public FrmHocKy()
        {
            InitializeComponent();
        }

        private void FrmHocKy_Load(object sender, EventArgs e)
        {
            dg_DanhSachHocKy.DataSource = bus_hocky.TaobangHocKy("");
            khoaInput();
            foreach (DataRow khoa in bus_namhoc.TaobangKhoa("").Rows)
            {
                cb_MaNamHoc.Properties.Items.Add(khoa[0]);
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

            tb_MaHocKy.Text = bus_hocky.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaHocKy.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa học kỳ này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_hocky.MaHK = tb_MaHocKy.Text;
                bus_hocky.XoadulieuHocKy(dto_hocky);
                dg_DanhSachHocKy.DataSource = bus_hocky.TaobangHocKy("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaHocKy.Text != "" && tb_TenHocKy.Text != "" && cb_MaNamHoc.SelectedItem != null)
            {
                dto_hocky.MaHK = tb_MaHocKy.Text;
                dto_hocky.TenHK = tb_TenHocKy.Text;
                dto_hocky.MaNH = cb_MaNamHoc.SelectedItem.ToString();

                try
                {
                    if (Them)
                    {
                        bus_hocky.ThemdulieuHocKy(dto_hocky);
                    }
                    else
                    {
                        bus_hocky.SuadulieuHocKy(dto_hocky);
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
                dg_DanhSachHocKy.DataSource = bus_hocky.TaobangHocKy("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học kỳ", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaHocKy.Text = dg_DanhSachHocKy.CurrentRow.Cells[0].Value.ToString();
                tb_TenHocKy.Text = dg_DanhSachHocKy.CurrentRow.Cells[1].Value.ToString();                
                cb_MaNamHoc.Text = dg_DanhSachHocKy.CurrentRow.Cells[2].Value.ToString();

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
