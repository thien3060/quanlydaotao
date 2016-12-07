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
    public partial class FrmNhomHP : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_NhomHP dto_nhomhp = new DTO_NhomHP();
        BUS_NhomHP bus_nhomhp = new BUS_NhomHP();
        BUS_HocPhan bus_hocphan = new BUS_HocPhan();
        BUS_KhoiLop bus_khoilop = new BUS_KhoiLop();

        private void khoaInput()
        {
            tb_MaNhomHP.Enabled = false;
            tb_TenNhomHP.Enabled = false;
            cb_MaHP.Enabled = false;
            cb_MaKL.Enabled = false;            
        }

        private void moInput()
        {
            tb_MaNhomHP.Enabled = false;
            tb_TenNhomHP.Enabled = true;
            cb_MaHP.Enabled = true;
            cb_MaKL.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaNhomHP.Text = "";
            tb_TenNhomHP.Text = "";
            cb_MaHP.SelectedItem = null;
            cb_MaKL.SelectedItem = null;
        }


        public FrmNhomHP()
        {
            InitializeComponent();
        }

        private void FrmNhomHP_Load(object sender, EventArgs e)
        {
            bus_nhomhp = new BUS_NhomHP();
            dg_DanhSachNhomHP.DataSource = bus_nhomhp.TaobangNhomHP("");
            khoaInput();

            foreach (DataRow datarow in bus_hocphan.TaobangHocPhan("").Rows)
            {
                cb_MaHP.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_khoilop.TaobangKhoiLop("").Rows)
            {
                cb_MaKL.Properties.Items.Add(datarow[0]);
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
            tb_MaNhomHP.Text = bus_nhomhp.TuTinhMa();
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
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhóm học phần này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_nhomhp.MaNHP = tb_MaNhomHP.Text;

                bus_nhomhp.XoadulieuNhomHP(dto_nhomhp);
                dg_DanhSachNhomHP.DataSource = bus_nhomhp.TaobangNhomHP("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaNhomHP.Text != "" && tb_TenNhomHP.Text != "" && cb_MaHP.SelectedItem != null && cb_MaKL.SelectedItem != null)
            {
                dto_nhomhp.MaNHP = tb_MaNhomHP.Text;
                dto_nhomhp.TenNHP = tb_TenNhomHP.Text;
                dto_nhomhp.MaHP = cb_MaHP.SelectedItem.ToString();
                dto_nhomhp.MaKL = cb_MaKL.SelectedItem.ToString();

                try
                {
                    if (Them)
                    {
                        bus_nhomhp.ThemdulieuNhomHP(dto_nhomhp);
                    }
                    else
                    {
                        bus_nhomhp.SuadulieuNhomHP(dto_nhomhp);
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
                dg_DanhSachNhomHP.DataSource = bus_nhomhp.TaobangNhomHP("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học phần này", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaNhomHP.Text = dg_DanhSachNhomHP.CurrentRow.Cells[0].Value.ToString();
                tb_TenNhomHP.Text = dg_DanhSachNhomHP.CurrentRow.Cells[1].Value.ToString();
                cb_MaHP.Text = dg_DanhSachNhomHP.CurrentRow.Cells[2].Value.ToString();
                cb_MaKL.Text = dg_DanhSachNhomHP.CurrentRow.Cells[3].Value.ToString();
                
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
