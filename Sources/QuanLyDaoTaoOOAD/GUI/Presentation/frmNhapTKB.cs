using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Utilities;
using System.Collections.ObjectModel;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmNhapTKB : DevExpress.XtraEditors.XtraForm
    {
        BUS_ThoiKhoaBieu bus_tkb = new BUS_ThoiKhoaBieu();
        BUS_BuoiHoc bus_bh = new BUS_BuoiHoc();
        public frmNhapTKB()
        {
            try
            {
                InitializeComponent();
                source = new DataTable();
                maPhong = string.Empty;
                ngayDauTuan = new DateTime();
                TKBDangXep = new Collection<DTO_ThoiKhoaBieu>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Collection<DTO_ThoiKhoaBieu> TKBDangXep;

        public DataTable TKBs;

        string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        DateTime ngayDauTuan;

        public DateTime NgayDauTuan
        {
            get { return ngayDauTuan; }
            set { ngayDauTuan = value; }
        }

        Thu thu = Thu.Thu2;

        public Thu Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        public delegate bool TruyenMatKhau(DataRow t);
        public TruyenMatKhau truyen;
        private DataTable source;


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0)
                {
                    DataRow x = source.Rows[gridView1.GetDataSourceRowIndex(selectedRowIndex)];
                    if (truyen != null)
                    {
                        truyen(x);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmNhapTKB_Load(object sender, EventArgs e)
        {
            try
            {
                groupControl1.Text = "Các đề nghị giảng dạy ngày: " + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy");
                source = bus_tkb.DeNghiTheoPhongTrongTuan(maPhong, ngayDauTuan);
                List<DataRow> remove_list = new List<DataRow>();

                foreach (DataRow t in source.Rows)
                {
                    int tietKT = int.Parse(t[8].ToString()) + int.Parse(t[9].ToString()) - 1;
                    DateTime ngayDangXet = ngayDauTuan.AddDays((int)thu);

                    if (DateTime.Parse(t[7].ToString()) != ngayDauTuan.AddDays((int)thu))//loại bỏ các đề nghị không nằm trong ngày đã chọn
                    {
                        remove_list.Add(t);
                        continue;
                    }
                        
                    foreach (var x in TKBDangXep)//loại bỏ các đề nghị đang được xếp thời khóa biểu (chưa lưu vào CSDL)
                    {
                        if (t[6].ToString() == x.BuoiHoc)
                        {
                            remove_list.Add(t);
                            continue;
                        } 
                    }

                    foreach (DataRow x in TKBs.Rows)
                    {
                        //loại bỏ các đề nghị trùng với thời khóa biểu đã được xếp rồi (đã lưu trong CSDL)
                        DTO_BuoiHoc buoi = bus_bh.LayBuoiHoc(x[6].ToString());
                        if(t[5].ToString() == x[5].ToString() && t[8].ToString() == x[8].ToString() && t[9].ToString() == x[9].ToString())
                        {
                            remove_list.Add(t);
                            break;
                        }

                        //loại bỏ các đề nghị mà mã lớp của đề nghị đó đã được xếp vào học buổi đang chọn rồi để tránh trường hợp 1 lớp học 2 môn cùng 1 buổi
                        if (t[5].ToString() == x[5].ToString() && t[6].ToString() == x[6].ToString())
                        {
                            remove_list.Add(t);
                            break;
                        }

                        //loại bỏ các trường hợp trùng 1 số tiết với thời khóa biểu đã xếp
                        if (buoi.Ngay == ngayDangXet)
                        {
                            int tietKTCu = buoi.TietBatDau + buoi.SoTiet - 1;
                            if (int.Parse(t[8].ToString()) == buoi.TietBatDau)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) < buoi.TietBatDau && tietKT >= buoi.TietBatDau)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) > buoi.TietBatDau && tietKT <= tietKTCu)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) == tietKTCu)
                            {
                                remove_list.Add(t);
                                break;
                            }
                        }
                    }

                    //loại bỏ các trường hợp trùng 1 số tiết với thời khóa biểu đang xếp
                    foreach (var tkb in TKBDangXep)
                    {
                        DTO_BuoiHoc b = bus_bh.LayBuoiHoc(tkb.BuoiHoc);
                        if (b.Ngay == ngayDangXet)
                        {
                            int tietKTCu = b.TietBatDau + b.SoTiet - 1;
                            if (int.Parse(t[8].ToString()) == b.TietBatDau)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) < b.TietBatDau && tietKT >= b.TietBatDau)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) > b.TietBatDau && tietKT <= tietKTCu)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) > b.TietBatDau && int.Parse(t[8].ToString()) <= tietKTCu && tietKT > tietKTCu)
                            {
                                remove_list.Add(t);
                                break;
                            }
                            if (int.Parse(t[8].ToString()) == tietKTCu)
                            {
                                remove_list.Add(t);
                                break;
                            }
                        }
                    }
                }

                foreach (DataRow i in remove_list.Distinct().ToList())
                    source.Rows.Remove(i);

                gridControl1.DataSource = source;
                if (source.Rows.Count > 0)
                    selectedRowIndex = gridView1.GetDataSourceRowIndex(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        int selectedRowIndex = -1;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectedRowIndex = e.RowHandle;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                simpleButton1_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}