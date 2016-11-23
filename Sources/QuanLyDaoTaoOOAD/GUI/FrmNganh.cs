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
    public partial class FrmNganh : DevExpress.XtraEditors.XtraForm
    {
        private bool Them;
        DTO_Nganh dto_ngh = new DTO_Nganh();
        BUS_Nganh bus_ngh = new BUS_Nganh();
        BUS_Khoa bus_khoa = new BUS_Khoa();

        private void khoaInput()
        {
            tb_MaNganh.Enabled = false;
            tb_TenNganh.Enabled = false;
            cb_MaKhoa.Enabled = false;
        }

        private void moInput()
        {
            tb_MaNganh.Enabled = false;
            tb_TenNganh.Enabled = true;
            cb_MaKhoa.Enabled = true;
        }

        private void xoaInput()
        {
            tb_MaNganh.Text = "";
            tb_TenNganh.Text = "";
        }


        public FrmNganh()
        {
            InitializeComponent();
        }

        private void FrmNganh_Load(object sender, EventArgs e)
        {
            dg_DanhSachNganh.DataSource = bus_ngh.TaobangNganh("");
            khoaInput();
            foreach (DataRow datarow in bus_khoa.TaobangKhoa("").Rows)
            {
                cb_MaKhoa.Properties.Items.Add(datarow[0]);
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

            tb_MaNganh.Text = bus_ngh.TuTinhMa();
            Them = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            bt_Sua.Enabled = false;
            bt_Them.Enabled = false;
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            moInput();

            tb_MaNganh.Enabled = false;
            Them = false;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa ngành này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dto_ngh.MaNganh = tb_MaNganh.Text;
                bus_ngh.XoadulieuNganh(dto_ngh);
                dg_DanhSachNganh.DataSource = bus_ngh.TaobangNganh("");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (tb_MaNganh.Text != "" && tb_TenNganh.Text != "" && cb_MaKhoa.SelectedItem != null)
            {

                dto_ngh.MaNganh = tb_MaNganh.Text;
                dto_ngh.TenNganh = tb_TenNganh.Text;
                dto_ngh.MaKhoa = cb_MaKhoa.SelectedItem.ToString();
                try
                {
                    if (Them)
                    {
                        bus_ngh.ThemdulieuNganh(dto_ngh);
                    }
                    else
                    {
                        bus_ngh.SuadulieuNganh(dto_ngh);
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
                dg_DanhSachNganh.DataSource = bus_ngh.TaobangNganh("");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành", "Lỗi");
            }
        }

        private void dg_DanhSachGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_MaNganh.Text = dg_DanhSachNganh.CurrentRow.Cells[0].Value.ToString();
                tb_TenNganh.Text = dg_DanhSachNganh.CurrentRow.Cells[1].Value.ToString();                
                cb_MaKhoa.Text = dg_DanhSachNganh.CurrentRow.Cells[2].Value.ToString();

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
