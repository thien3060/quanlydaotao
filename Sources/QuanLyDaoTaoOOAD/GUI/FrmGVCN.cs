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
    public partial class FrmGVCN : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_GVCN dto_gvcn = new DTO_GVCN();
        BUS_GVCN bus_gvcn = new BUS_GVCN();
        BUS_GiaoVien bus_giaovien = new BUS_GiaoVien();
        BUS_NhomLop bus_nhomlop = new BUS_NhomLop();
        BUS_NamHoc bus_namhoc = new BUS_NamHoc();

        private void khoaInput()
        {
            cb_MaGV.Enabled = false;
            cb_MaNL.Enabled = false;
            cb_MaNH.Enabled = false;
            tb_GhiChu.Enabled = false;
        }

        private void moInput()
        {
            cb_MaGV.Enabled = false;
            cb_MaNL.Enabled = true;
            cb_MaNH.Enabled = true;
            tb_GhiChu.Enabled = true;
        }

        private void xoaInput()
        {
            cb_MaGV.SelectedItem = null;
            cb_MaNL.SelectedItem = null;
        }


        public FrmGVCN()
        {
            InitializeComponent();
        }

        private void FrmGVCN_Load(object sender, EventArgs e)
        {
            bus_gvcn = new BUS_GVCN();
            dg_DanhSachGVCN.DataSource = bus_gvcn.TaobangGVCN("");
            khoaInput();

            foreach (DataRow datarow in bus_giaovien.TaobangGiaoVien("").Rows)
            {
                cb_MaGV.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_nhomlop.TaobangNhomLop("").Rows)
            {
                cb_MaNL.Properties.Items.Add(datarow[0]);
            }

            foreach (DataRow datarow in bus_namhoc.TaobangNamHoc("").Rows)
            {
                cb_MaNH.Properties.Items.Add(datarow[0]);
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
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giáo viên chủ nhiệm này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_gvcn.MaGV = cb_MaGV.SelectedItem.ToString();
                dto_gvcn.MaNL = cb_MaNL.SelectedItem.ToString();
                dto_gvcn.MaNH = cb_MaNH.SelectedItem.ToString();

                bus_gvcn.XoadulieuGVCN(dto_gvcn);
                dg_DanhSachGVCN.DataSource = bus_gvcn.TaobangGVCN("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (cb_MaGV.SelectedItem != null && cb_MaNL.SelectedItem != null && cb_MaNH.SelectedItem != null && tb_GhiChu.Text != "")
            {
                dto_gvcn.MaGV = cb_MaGV.SelectedItem.ToString();
                dto_gvcn.MaNL = cb_MaNL.SelectedItem.ToString();
                dto_gvcn.MaNH = cb_MaNH.SelectedItem.ToString();
                dto_gvcn.GhiChu = tb_GhiChu.Text;

                try
                {
                    if (Them)
                    {
                        bus_gvcn.ThemdulieuGVCN(dto_gvcn);
                    }
                    else
                    {
                        bus_gvcn.SuadulieuGVCN(dto_gvcn);
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
                dg_DanhSachGVCN.DataSource = bus_gvcn.TaobangGVCN("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giáo viên chủ nhiệm", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cb_MaGV.Text = dg_DanhSachGVCN.CurrentRow.Cells[0].Value.ToString();
                cb_MaNL.Text = dg_DanhSachGVCN.CurrentRow.Cells[1].Value.ToString();
                cb_MaNH.Text = dg_DanhSachGVCN.CurrentRow.Cells[2].Value.ToString();
                tb_GhiChu.Text = dg_DanhSachGVCN.CurrentRow.Cells[3].Value.ToString();

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
