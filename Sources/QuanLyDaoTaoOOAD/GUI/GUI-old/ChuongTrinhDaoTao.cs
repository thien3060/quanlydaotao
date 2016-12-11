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
    public partial class ChuongTrinhDaoTao : DevExpress.XtraEditors.XtraForm
    {
        private bool CapNhat;
        DTO_Nganh dto_nganh = new DTO_Nganh();
        DTO_KHDT dto_khdt = new DTO_KHDT();
        DTO_GiangVien dto_gv = new DTO_GiangVien();
        BUS_HocPhan bus_hocphan = new BUS_HocPhan();
        BUS_Khoa bus_khoa = new BUS_Khoa();        
        BUS_TDDT bus_tddt = new BUS_TDDT();
        BUS_HeDT bus_hedt = new BUS_HeDT();
        BUS_Nganh bus_nganh = new BUS_Nganh();
        BUS_KHDT bus_khdt = new BUS_KHDT();

        private void khoaInput()
        {
            bt_TimKiem.Enabled = false;
            bt_CapNhat.Enabled = false;
        }

        private void moInput()
        {
            bt_TimKiem.Enabled = true;
            bt_CapNhat.Enabled = true;
        }

        private void xoaInput()
        {
            //lookup_Khoa.Text = "";
            //lookup_KhoaHoc.Text = "";
            //lookup_TrinhDoDaoTao.Text = "";
            //lookup_HeDaoTao.Text = "";
            //lookup_Nganh.Text = "";
        }


        public ChuongTrinhDaoTao()
        {
            InitializeComponent();
        }

        private void ChuongTrinhDaoTao_Load(object sender, EventArgs e)
        {
            khoaInput();
            // Khoa
            lookup_Khoa.Properties.DataSource = bus_khoa.TaobangKhoa("").DefaultView;
            lookup_Khoa.Properties.DisplayMember = "TenKhoa";
            lookup_Khoa.Properties.ValueMember = "MaKhoa";

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col_makhoa, col_tenkhoa;

            col_makhoa = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhoa", "Mã Khoa");
            col_tenkhoa = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoa", "Tên Khoa");

            col_makhoa.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            col_tenkhoa.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            lookup_Khoa.Properties.Columns.Add(col_makhoa);
            lookup_Khoa.Properties.Columns.Add(col_tenkhoa);

            // Trinh do dao tao
            lookup_TrinhDoDaoTao.Properties.DataSource = bus_tddt.TaobangTDDT("").DefaultView;
            lookup_TrinhDoDaoTao.Properties.DisplayMember = "TenTD";
            lookup_TrinhDoDaoTao.Properties.ValueMember = "MaTD";

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col_matd, col_tentd;

            col_matd = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTD", "Mã trình độ đào tạo");
            col_tentd = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTD", "Trình độ đào tạo");

            col_matd.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            col_tentd.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            lookup_TrinhDoDaoTao.Properties.Columns.Add(col_matd);
            lookup_TrinhDoDaoTao.Properties.Columns.Add(col_tentd);            
            // He dao tao
            lookup_HeDaoTao.Properties.DataSource = bus_hedt.TaobangHeDT("").DefaultView;
            lookup_HeDaoTao.Properties.DisplayMember = "TenHDT";
            lookup_HeDaoTao.Properties.ValueMember = "MaHDT";

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col_mahedt, col_tenhedt;

            col_mahedt = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHDT", "Mã hệ đào tạo");
            col_tenhedt = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHDT", "Hệ đào tạo");

            col_mahedt.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            col_tenhedt.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            lookup_HeDaoTao.Properties.Columns.Add(col_mahedt);
            lookup_HeDaoTao.Properties.Columns.Add(col_tenhedt);

            bt_TimKiem.Enabled = true;
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                bt_CapNhat.Enabled = false;

                dto_khdt = new DTO_KHDT();
                dto_khdt.MaNganh = lookup_Nganh.EditValue.ToString();
                dto_khdt.MaHDT = lookup_HeDaoTao.EditValue.ToString();
                dto_khdt.MaTD = lookup_TrinhDoDaoTao.EditValue.ToString();


                bus_khdt = new BUS_KHDT();
                DataColumn col = new DataColumn("Môn học");
                DataColumn col11 = new DataColumn("STT");
                DataColumn col12 = new DataColumn("Tên môn học");
                DataColumn col13 = new DataColumn("Số tín chỉ");
                DataColumn col14 = new DataColumn("Tín chỉ thực hành");
                DataColumn col2 = new DataColumn("Năm 1", typeof(bool));
                DataColumn col3 = new DataColumn("Năm 2", typeof(bool));
                DataColumn col4 = new DataColumn("Năm 3", typeof(bool));
                DataColumn col5 = new DataColumn("Năm 4", typeof(bool));
                DataColumn col6 = new DataColumn("Năm 5", typeof(bool));
                DataTable dt = new DataTable();


                foreach (DataRow dr in bus_khdt.GetKHDT(dto_khdt).Rows)
                {
                    dt.Merge(bus_hocphan.GetHocPhanByMaKHDT(dr[0].ToString()));
                }

                dt.Columns.Remove("MaHP");
                dt.Columns.Remove("SoTietLT");
                dt.Columns.Remove("SoTietTH");
                dt.Columns.Remove("MaKHDT");
                dt.Columns.Add(col2);
                dt.Columns.Add(col3);
                dt.Columns.Add(col4);
                dt.Columns.Add(col5);
                dt.Columns.Add(col6);

                foreach (DataRow dr in dt.Rows)
                {
                    dr[2] = true;
                }

                dg_ChuongTrinhDaoTao.DataSource = dt;

                //stt
                for (int i = 0; i < dg_ChuongTrinhDaoTao.Rows.Count - 1; i++)
                {
                    //dg_ChuongTrinhDaoTao.Rows[i].Cells[0].Value = i + 1;
                }

                moInput();
            }
            catch (Exception)
            {
                
            }
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            bt_CapNhat.Enabled = false;
            bt_TimKiem.Enabled = false;
            
            Console.WriteLine(lookup_Khoa.SelectedText);
            moInput();
        }

        private void lookup_Khoa_EditValueChanged(object sender, EventArgs e)
        {
            dto_nganh.Khoa = lookup_Khoa.EditValue.ToString();
            lookup_Nganh.Properties.DataSource = bus_nganh.GetByMaKhoa(dto_nganh).DefaultView;
            lookup_Nganh.Properties.DisplayMember = "TenNganh";
            lookup_Nganh.Properties.ValueMember = "MaNganh";

            DevExpress.XtraEditors.Controls.LookUpColumnInfo col_manganh, col_tennganh;

            col_tennganh = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNganh", "Tên ngành");
            col_manganh = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNganh", "Mã ngành");

            col_tennganh.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            col_manganh.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            lookup_Nganh.Properties.Columns.Add(col_tennganh);
            lookup_Nganh.Properties.Columns.Add(col_manganh);
        }
    }
}
