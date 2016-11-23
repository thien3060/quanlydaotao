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
    public partial class FrmKHDT : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_KHDT dto_khdt = new DTO_KHDT();
        BUS_KHDT bus_khdt = new BUS_KHDT();
        
        BUS_Khoa bus_khoa = new BUS_Khoa();
        BUS_TDDT bus_tddt = new BUS_TDDT();
        BUS_HeDT bus_hedt = new BUS_HeDT();
        BUS_Nganh bus_nganh = new BUS_Nganh();

        private void khoaInput()
        {
            tb_MaKHDT.Enabled = false;
            tb_TenKHDT.Enabled = false;
            cb_MaTDDT.Enabled = false;
            cb_MaHeDT.Enabled = false;
            cb_MaNganh.Enabled = false;
        }

        private void moInput()
        {
            tb_MaKHDT.Enabled = false;
            tb_TenKHDT.Enabled = true;
            cb_MaTDDT.Enabled = true;
            cb_MaHeDT.Enabled = true;
            cb_MaNganh.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaKHDT.Text = "";
            tb_TenKHDT.Text = "";
        }


        public FrmKHDT()
        {
            InitializeComponent();
        }

        private void FrmKHDT_Load(object sender, EventArgs e)
        {
            dg_DanhSachKHDT.DataSource = bus_khdt.TaobangKHDT("");
            khoaInput();
            //init combobox trình độ đào tạo
            foreach (DataRow datarow in bus_tddt.TaobangTDDT("").Rows)
            {
                cb_MaTDDT.Properties.Items.Add(datarow[0]);
            }
            //init combobox hệ đào tạo
            foreach (DataRow datarow in bus_hedt.TaobangHeDT("").Rows)
            {
                cb_MaHeDT.Properties.Items.Add(datarow[0]);
            }
            //init combobox ngành
            foreach (DataRow datarow in bus_nganh.TaobangNganh("").Rows)
            {
                cb_MaNganh.Properties.Items.Add(datarow[0]);
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

            tb_MaKHDT.Text = bus_khdt.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaKHDT.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa kế hoạch đào tạo này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_khdt.MaKHDT = tb_MaKHDT.Text;
                bus_khdt.XoadulieuKHDT(dto_khdt);
                dg_DanhSachKHDT.DataSource = bus_khdt.TaobangKHDT("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaKHDT.Text != "" && tb_TenKHDT.Text != "")
            {

                dto_khdt.MaKHDT = tb_MaKHDT.Text;
                dto_khdt.TenKHDT = tb_TenKHDT.Text;
                dto_khdt.MaTD = cb_MaTDDT.SelectedItem.ToString();
                dto_khdt.MaHDT = cb_MaHeDT.SelectedItem.ToString();
                dto_khdt.MaNganh = cb_MaNganh.SelectedItem.ToString();

                try
                {
                    if (Them)
                    {
                        bus_khdt.ThemdulieuKHDT(dto_khdt);
                    }
                    else
                    {
                        bus_khdt.SuadulieuKHDT(dto_khdt);
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
                dg_DanhSachKHDT.DataSource = bus_khdt.TaobangKHDT("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin kế hoạch đào tạo", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaKHDT.Text = dg_DanhSachKHDT.CurrentRow.Cells[0].Value.ToString();
                tb_TenKHDT.Text = dg_DanhSachKHDT.CurrentRow.Cells[1].Value.ToString();                
                cb_MaTDDT.Text = dg_DanhSachKHDT.CurrentRow.Cells[2].Value.ToString();

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
