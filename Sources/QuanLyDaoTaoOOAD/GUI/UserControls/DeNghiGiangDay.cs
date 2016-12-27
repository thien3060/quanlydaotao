using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using QuanLyDaoTao.Presentation;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Utils;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.UserControls
{
    public partial class DeNghiGiangDay : UserControl
    {
        BUS_DeNghi bus_denghi = new BUS_DeNghi();
        BUS_BuoiHoc bus_buoihoc = new BUS_BuoiHoc();

        public DataTable buoiHocs;
        public DataTable buoiHocs_them;

        public DataTable deNghis;
        public DataTable deNghis_them;

        public DeNghiGiangDay()
        {
            InitializeComponent();
            ngayDauTuan = DateTime.Now.AddDays(DayOfWeek.Monday - DateTime.Now.DayOfWeek);
            buoiHocs = new DataTable();
            deNghis = new DataTable();
            buoiHocs_them = new DataTable();
            deNghis_them = new DataTable();
            maGV = string.Empty;
        }

        string maGV;

        public string MaGV
        {
            get { return maGV; }
            set
            {
                maGV = value;
                if (!string.IsNullOrEmpty(value))
                {
                    deNghis.Clear();
                    deNghis = bus_denghi.DanhSachDeNghiTheoTuan(value, ngayDauTuan);
                    DeNghiGiangDay_Load(null, null);
                }
            }
        }

        int namHoc;

        public int NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }

        int hocKy;

        public int HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }

        private DateTime ngayDauTuan;

        public DateTime NgayDauTuan
        {
            get { return ngayDauTuan; }
            set
            {
                if (value.DayOfWeek == DayOfWeek.Monday)
                {
                    ngayDauTuan = value;
                    lbl0.Text = "Thứ 2\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl1.Text = "Thứ 3\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl2.Text = "Thứ 4\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl3.Text = "Thứ 5\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl4.Text = "Thứ 6\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl5.Text = "Thứ 7\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(1);
                    lbl6.Text = "Chủ nhật\n" + ngayDauTuan.ToString("dd/MM/yyyy");
                    ngayDauTuan = ngayDauTuan.AddDays(-6);
                    if (value != (new DateTime()) || value != null)
                    {
                        buoiHocs.Clear();
                        buoiHocs = bus_buoihoc.DanhSachBuoiHocTheoTuan(value);
                        buoiHocs_them = buoiHocs.Clone();
                    }
                    if (!string.IsNullOrEmpty(maGV))
                    {
                        deNghis.Clear();
                        deNghis = bus_denghi.DanhSachDeNghiTheoTuan(maGV, value);
                        deNghis_them = deNghis.Clone();
                        DeNghiGiangDay_Load(null, null);
                    }
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }

        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };

        Thu thu;

        public bool ThemBuoiHoc(Thu thu, int tietBD, int soTiet, string monHoc, string lop, string maPC)
        {
            try
            {
                if (tietBD < 0 || tietBD > 9)
                    throw new Exception("Tiết bắt đầu không hợp lệ.");
                if (soTiet < 1 || soTiet > 5)
                    throw new Exception("Số tiết không hợp lệ.");
                int idBuoiHoc;
                if (buoiHocs.Rows.Count != 0)
                {
                    idBuoiHoc = int.Parse(buoiHocs.Rows[buoiHocs.Rows.Count - 1][0].ToString()) + 1;
                }
                else
                {
                    idBuoiHoc = int.Parse(bus_buoihoc.LayMaCuoiCung().ToString()) + 1;
                }

                //kiem tra co ton tai buoi hoc chua
                bool tonTaiBuoiHoc = false;

                foreach (DataRow row in buoiHocs.Rows)
                {
                    DTO_BuoiHoc b = new DTO_BuoiHoc(row[0].ToString(), DateTime.Parse(row[1].ToString()), int.Parse(row[2].ToString()), int.Parse(row[3].ToString()));
                    if (b.Ngay == ngayDauTuan.AddDays((int)thu) && b.TietBatDau == tietBD && b.SoTiet == soTiet)
                    {
                        idBuoiHoc = int.Parse(b.MaBH.ToString());
                        tonTaiBuoiHoc = true;
                        if (bus_denghi.KiemTraTonTai(maPC, idBuoiHoc))
                        {
                            MessageBoxUtils.Exclamation("Đã tồn tại một đề nghị như thế này rồi.");
                            return false;
                        }
                    }
                }
                //them buoi hoc
                if (!tonTaiBuoiHoc)//neu chua ton tai buoi hoc   
                {
                    buoiHocs.Rows.Add(idBuoiHoc.ToString(), ngayDauTuan.AddDays((int)thu), tietBD, soTiet);
                    buoiHocs_them.Rows.Add(idBuoiHoc.ToString(), ngayDauTuan.AddDays((int)thu), tietBD, soTiet);
                }

                //kiểm tra không cho trùng
                int tietKT = tietBD + soTiet - 1;
                DateTime ngayDangXet = ngayDauTuan.AddDays((int)thu);
                
                foreach (DataRow i in deNghis.Rows)
                {
                    DTO_BuoiHoc b = bus_buoihoc.LayBuoiHoc(i[0].ToString());
                    if (b != null)
                    {
                        if (b.Ngay == ngayDangXet)
                        {
                            int tietKTCu = b.TietBatDau + b.SoTiet - 1;
                            if (tietBD == b.TietBatDau)
                            {
                                MessageBoxUtils.Exclamation("Trùng rồi bạn ơi");
                                return false;
                            }
                            if (tietBD < b.TietBatDau && tietKT >= b.TietBatDau)
                            {
                                MessageBoxUtils.Exclamation("Trùng rồi bạn ơi");
                                return false;
                            }
                            if (tietBD > b.TietBatDau && tietKT <= tietKTCu)
                            {
                                MessageBoxUtils.Exclamation("Trùng rồi bạn ơi");
                                return false;
                            }
                            if (tietBD == tietKTCu)
                            {
                                MessageBoxUtils.Exclamation("Trùng rồi bạn ơi");
                                return false;
                            }
                        }
                    }
                }

                //vẽ các panel
                Paint((int)thu, tietBD, soTiet, lop, monHoc);
                deNghis.Rows.Add(idBuoiHoc, maPC);
                deNghis_them.Rows.Add(idBuoiHoc, maPC);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lblThu2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string lbl = ((LinkLabel)sender).Name;
                if (lbl == "lbl0")
                    thu = Thu.Thu2;
                else if (lbl == "lbl1")
                    thu = Thu.Thu3;
                else if (lbl == "lbl2")
                    thu = Thu.Thu4;
                else if (lbl == "lbl3")
                    thu = Thu.Thu5;
                else if (lbl == "lbl4")
                    thu = Thu.Thu6;
                else if (lbl == "lbl5")
                    thu = Thu.Thu7;
                else
                    thu = Thu.ChuNhat;

                frmNhapDeNghi frm = new frmNhapDeNghi() { Text = thu.ToString(), MaGV = maGV, HocKy = hocKy, NamHoc = namHoc };
                frm.truyen = new frmNhapDeNghi.TruyenDulieu(NhanDuLieu);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private bool NhanDuLieu(int tietBD, int soTiet, string monHoc, string lop, string maPC)
        {
            return ThemBuoiHoc(thu, tietBD, soTiet, monHoc, lop, maPC);
        }

        private new void Paint(int thu, int tietBD, int soTiet, string lop, string monHoc)
        {
            try
            {
                switch (soTiet)
                {
                    case 1:
                        MotTiet motTiet = new MotTiet();
                        motTiet.PhongHoc = lop;
                        motTiet.MonHoc = monHoc;
                        motTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = lop;
                        haiTiet.MonHoc = monHoc;
                        haiTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = lop;
                        baTiet.MonHoc = monHoc;
                        baTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = lop;
                        bonTiet.MonHoc = monHoc;
                        bonTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = lop;
                        namTiet.MonHoc = monHoc;
                        namTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        pnChinh.Controls.Add(namTiet);
                        namTiet.BringToFront();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeNghiGiangDay_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                foreach (DataRow row in deNghis.Rows)
                {
                    DTO_DeNghi d = new DTO_DeNghi(row[1].ToString(), int.Parse(row[0].ToString()));
                    DataRow thongTin = bus_denghi.ThongTinDeNghi(d.BuoiHoc, d.MaPC).Rows[0];

                    Thu t = Thu.Thu2;
                    DateTime ngay = DateTime.Parse(thongTin[0].ToString());
                    int sotiet = int.Parse(thongTin[1].ToString());
                    int tietbatdau = int.Parse(thongTin[2].ToString());
                    string malop = thongTin[3].ToString();
                    string tenmh = thongTin[4].ToString();
                    switch (ngay.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            t = Thu.Thu2;
                            break;
                        case DayOfWeek.Tuesday:
                            t = Thu.Thu3;
                            break;
                        case DayOfWeek.Wednesday:
                            t = Thu.Thu4;
                            break;
                        case DayOfWeek.Thursday:
                            t = Thu.Thu5;
                            break;
                        case DayOfWeek.Friday:
                            t = Thu.Thu6;
                            break;
                        case DayOfWeek.Saturday:
                            t = Thu.Thu7;
                            break;
                        case DayOfWeek.Sunday:
                            t = Thu.ChuNhat;
                            break;
                    }
                    Paint((int)t, tietbatdau, sotiet, malop, tenmh);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Clear()
        {
            try
            {
                while (pnChinh.Controls.Count > 15)
                {
                    foreach (Control x in pnChinh.Controls)
                    {
                        if (x is UserControl)
                            pnChinh.Controls.Remove(x);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cancel()
        {
            try
            {
                deNghis.Clear();
                deNghis = bus_denghi.DanhSachDeNghiTheoTuan(maGV, ngayDauTuan);
                DeNghiGiangDay_Load(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReadOnly()
        {
            try
            {
                lbl0.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl1.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl2.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl3.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl4.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl5.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl6.LinkClicked -= new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UnReadOnly()
        {
            try
            {
                lbl0.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl1.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl2.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl3.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl4.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl5.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
                lbl6.LinkClicked += new LinkLabelLinkClickedEventHandler(lblThu2_LinkClicked);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
