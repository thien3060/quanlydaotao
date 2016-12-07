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
    public partial class FrmHocPhan : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_HocPhan dto_hocphan = new DTO_HocPhan();
        BUS_HocPhan bus_hocphan = new BUS_HocPhan();
        BUS_KHDT bus_khdt = new BUS_KHDT();

        private void khoaInput()
        {
            tb_MaHP.Enabled = false;
            tb_SoTinChi.Enabled = false;
            tb_SoTietLT.Enabled = false;
            tb_SoTietTH.Enabled = false;
            tb_TenHP.Enabled = false;
            cb_MaKHDT.Enabled = false;
        }

        private void moInput()
        {
            tb_MaHP.Enabled = false;
            tb_SoTinChi.Enabled = true;
            tb_SoTietLT.Enabled = true;
            tb_SoTietTH.Enabled = true;
            tb_TenHP.Enabled = true;
            cb_MaKHDT.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaHP.Text = "";
            tb_SoTinChi.Text = "";
            tb_SoTietLT.Text = "";
            tb_SoTietTH.Text = "";
            tb_TenHP.Text = "";
            cb_MaKHDT.SelectedItem = null;
        }


        public FrmHocPhan()
        {
            InitializeComponent();
        }

        private void FrmHocPhan_Load(object sender, EventArgs e)
        {
            bus_hocphan = new BUS_HocPhan();
            dg_DanhSachHP.DataSource = bus_hocphan.TaobangHocPhan("");
            khoaInput();

            foreach (DataRow datarow in bus_khdt.TaobangKHDT("").Rows)
            {
                cb_MaKHDT.Properties.Items.Add(datarow[0]);
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
            tb_MaHP.Text = bus_hocphan.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaHP.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa học phần này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_hocphan.MaHP = tb_MaHP.Text;
                bus_hocphan.XoadulieuHocPhan(dto_hocphan);
                dg_DanhSachHP.DataSource = bus_hocphan.TaobangHocPhan("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaHP.Text != "" && tb_SoTinChi.Text != "" && tb_SoTietTH.Text != "" && tb_TenHP.Text != "" && cb_MaKHDT.SelectedItem != null)
            {
                //if (Convert.ToInt64(tb_SoTinChi.Text)*15 != (Convert.ToInt64(tb_SoTietLT.Text) + Convert.ToInt64(tb_SoTietTH.Text)))
                //{
                //    MessageBox.Show("Một tín chỉ phải tương ứng với 15 tiết", "Lỗi");
                //}
                //else
                //{
                    dto_hocphan.MaHP = tb_MaHP.Text;
                    dto_hocphan.TenHP = tb_TenHP.Text;
                    dto_hocphan.SoTC = tb_SoTinChi.Text;
                    dto_hocphan.SoTietLT = tb_SoTietLT.Text;
                    dto_hocphan.SoTietTH = tb_SoTietTH.Text;
                    dto_hocphan.MaKHDT = cb_MaKHDT.SelectedItem.ToString();
                    
                   
                    try
                    {
                        if (Them)
                        {
                            bus_hocphan.ThemdulieuHocPhan(dto_hocphan);
                        }
                        else
                        {
                            bus_hocphan.SuadulieuHocPhan(dto_hocphan);
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
                    dg_DanhSachHP.DataSource = bus_hocphan.TaobangHocPhan("");
                //}
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học phần", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaHP.Text = dg_DanhSachHP.CurrentRow.Cells[0].Value.ToString();
                tb_TenHP.Text = dg_DanhSachHP.CurrentRow.Cells[1].Value.ToString();
                tb_SoTietLT.Text = dg_DanhSachHP.CurrentRow.Cells[2].Value.ToString();
                tb_SoTietTH.Text = dg_DanhSachHP.CurrentRow.Cells[3].Value.ToString();
                tb_SoTinChi.Text = dg_DanhSachHP.CurrentRow.Cells[4].Value.ToString();
                cb_MaKHDT.Text = dg_DanhSachHP.CurrentRow.Cells[5].Value.ToString();

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
