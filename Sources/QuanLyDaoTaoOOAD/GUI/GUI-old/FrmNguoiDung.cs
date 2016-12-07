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
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_NguoiDung dto_user = new DTO_NguoiDung();
        BUS_NguoiDung bus_user = new BUS_NguoiDung();

        private void khoaInput()
        {
            tb_MaND.Enabled = false;
            tb_TenND.Enabled = false;
            tb_TenDN.Enabled = false;
            tb_MatKhau.Enabled = false;
            tb_Quyen.Enabled = false;
            tb_MoTaQuyen.Enabled = false;
        }

        private void moInput()
        {
            tb_MaND.Enabled = false;
            tb_TenND.Enabled = true;
            tb_TenDN.Enabled = true;
            tb_MatKhau.Enabled = true;
            tb_Quyen.Enabled = true;
            tb_MoTaQuyen.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaND.Text = "";
            tb_TenND.Text = "";
            tb_TenDN.Text = "";
            tb_MatKhau.Text = "";
            tb_Quyen.Text = "";
            tb_MoTaQuyen.Text = "";
            tb_TenND.Text = "";
        }


        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            bus_user = new BUS_NguoiDung();
            dg_DanhSachND.DataSource = bus_user.TaobangNguoiDung("");
            
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
            tb_MaND.Text = bus_user.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaND.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa người dùng này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_user.MaND = tb_MaND.Text;
                bus_user.XoadulieuNguoiDung(dto_user);
                dg_DanhSachND.DataSource = bus_user.TaobangNguoiDung("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaND.Text != "" && tb_TenDN.Text != "" && tb_MatKhau.Text != "")
            {

                dto_user.MaND = tb_MaND.Text;
                dto_user.TenND = tb_TenND.Text;
                dto_user.TenDN = tb_TenDN.Text;
                dto_user.MatKhau = tb_MatKhau.Text;
                dto_user.Quyen = tb_Quyen.Text;
                dto_user.MoTaQuyen = tb_MoTaQuyen.Text;

                try
                {
                    if (Them)
                    {
                        bus_user.ThemdulieuNguoiDung(dto_user);
                    }
                    else
                    {
                        bus_user.SuadulieuNguoiDung(dto_user);
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
                dg_DanhSachND.DataSource = bus_user.TaobangNguoiDung("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người dùng", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaND.Text = dg_DanhSachND.CurrentRow.Cells[0].Value.ToString();                
                tb_TenDN.Text = dg_DanhSachND.CurrentRow.Cells[1].Value.ToString();
                tb_MatKhau.Text = dg_DanhSachND.CurrentRow.Cells[2].Value.ToString();
                tb_TenND.Text = dg_DanhSachND.CurrentRow.Cells[3].Value.ToString();
                tb_Quyen.Text = dg_DanhSachND.CurrentRow.Cells[4].Value.ToString();
                tb_MoTaQuyen.Text = dg_DanhSachND.CurrentRow.Cells[5].Value.ToString();
                                
                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Them.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void tb_Quyen_KeyPress(object sender, KeyPressEventArgs e)
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
