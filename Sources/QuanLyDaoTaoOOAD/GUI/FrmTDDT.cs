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
    public partial class FrmTDDT : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_TDDT dto_tddt = new DTO_TDDT();
        BUS_TDDT bus_tddt = new BUS_TDDT();

        private void khoaInput()
        {
            tb_MaTDDT.Enabled = false;
            tb_TenTDDT.Enabled = false;
        }

        private void moInput()
        {
            tb_MaTDDT.Enabled = false;
            tb_TenTDDT.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaTDDT.Text = "";
            tb_TenTDDT.Text = "";
        }


        public FrmTDDT()
        {
            InitializeComponent();
        }

        private void FrmTDDT_Load(object sender, EventArgs e)
        {
            bus_tddt = new BUS_TDDT();
            dg_DanhSachTDDT.DataSource = bus_tddt.TaobangTDDT("");
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
            tb_MaTDDT.Text = bus_tddt.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaTDDT.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa trình độ đào tạo này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_tddt.MaTD = tb_MaTDDT.Text;
                bus_tddt.XoadulieuTDDT(dto_tddt);
                dg_DanhSachTDDT.DataSource = bus_tddt.TaobangTDDT("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaTDDT.Text != "" && tb_TenTDDT.Text != "")
            {
                dto_tddt.MaTD = tb_MaTDDT.Text;
                dto_tddt.TenTD = tb_TenTDDT.Text;

                try
                {
                    if (Them)
                    {
                        bus_tddt.ThemdulieuTDDT(dto_tddt);
                    }
                    else
                    {
                        bus_tddt.SuadulieuTDDT(dto_tddt);
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
                dg_DanhSachTDDT.DataSource = bus_tddt.TaobangTDDT("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trình độ đào tạo", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaTDDT.Text = dg_DanhSachTDDT.CurrentRow.Cells[0].Value.ToString();
                tb_TenTDDT.Text = dg_DanhSachTDDT.CurrentRow.Cells[1].Value.ToString();

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
