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
    public partial class FrmNhomLop : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_NhomLop dto_nhomlop = new DTO_NhomLop();
        BUS_NhomLop bus_nhomlop = new BUS_NhomLop();
        BUS_Khoa bus_khoa = new BUS_Khoa();

        private void khoaInput()
        {
            tb_MaNhomLop.Enabled = false;
            tb_TenNhomLop.Enabled = false;
            cb_MaKhoiLop.Enabled = false;
        }

        private void moInput()
        {
            tb_MaNhomLop.Enabled = false;
            tb_TenNhomLop.Enabled = true;
            cb_MaKhoiLop.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaNhomLop.Text = "";
            tb_TenNhomLop.Text = "";
            cb_MaKhoiLop.SelectedItem = null;
        }


        public FrmNhomLop()
        {
            InitializeComponent();
        }

        private void FrmNhomLop_Load(object sender, EventArgs e)
        {
            dg_DanhSachNhomLop.DataSource = bus_nhomlop.TaobangNhomLop("");
            khoaInput();
            foreach (DataRow datarow in bus_khoa.TaobangKhoa("").Rows)
            {
                cb_MaKhoiLop.Properties.Items.Add(datarow[0]);
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

            tb_MaNhomLop.Text = bus_nhomlop.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaNhomLop.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhóm lớp này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_nhomlop.MaNL = tb_MaNhomLop.Text;
                bus_nhomlop.XoadulieuNhomLop(dto_nhomlop);
                dg_DanhSachNhomLop.DataSource = bus_nhomlop.TaobangNhomLop("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaNhomLop.Text != "" && tb_TenNhomLop.Text != "" && cb_MaKhoiLop.SelectedItem != null)
            {

                dto_nhomlop.MaNL = tb_MaNhomLop.Text;
                dto_nhomlop.TenNL = tb_TenNhomLop.Text;
                dto_nhomlop.MaKL = cb_MaKhoiLop.SelectedItem.ToString();

                try
                {
                    if (Them)
                    {
                        bus_nhomlop.ThemdulieuNhomLop(dto_nhomlop);
                    }
                    else
                    {
                        bus_nhomlop.SuadulieuNhomLop(dto_nhomlop);
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
                dg_DanhSachNhomLop.DataSource = bus_nhomlop.TaobangNhomLop("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhóm lớp", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaNhomLop.Text = dg_DanhSachNhomLop.CurrentRow.Cells[0].Value.ToString();
                tb_TenNhomLop.Text = dg_DanhSachNhomLop.CurrentRow.Cells[1].Value.ToString();                
                cb_MaKhoiLop.Text = dg_DanhSachNhomLop.CurrentRow.Cells[2].Value.ToString();

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
