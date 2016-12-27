using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BUS;
using DTO;
using DevExpress.Utils;
using QuanLyDaoTao.Enums;
using System.Collections;

namespace QuanLyDaoTao.UserControls
{
    public partial class NhapPhieuGiangDay : UserControl
    {
        BUS_ThoiKhoaBieu bus_tkb = new BUS_ThoiKhoaBieu();
        public NhapPhieuGiangDay()
        {
            try
            {
                InitializeComponent();
                maLop = string.Empty;
                ngayDauTuan = DateTime.Now.AddDays(DayOfWeek.Monday - DateTime.Now.DayOfWeek);
                phieuGiangDay = bus_tkb.XemTKBSinhVien("DTH110031", new DateTime(2014, 04, 22));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set
            {
                maLop = value;
                if (!string.IsNullOrEmpty(value))
                {
                    phieuGiangDay.Clear();
                    phieuGiangDay = bus_tkb.PhieuGiangDay(maLop, ngayDauTuan);
                    thoiKhoaBieu = bus_tkb.TaobangThoiKhoaBieu("");
                    ThoiKhoaBieu_Load(null, null);
                }
            }
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
                    if (value != (new DateTime()))
                    {
                        phieuGiangDay.Clear();
                        phieuGiangDay = bus_tkb.PhieuGiangDay(maLop, ngayDauTuan);
                        thoiKhoaBieu = bus_tkb.TaobangThoiKhoaBieu("");
                        ThoiKhoaBieu_Load(null, null);
                    }
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }

        /// <summary>
        /// Các thời khóa biểu đã được xếp
        /// </summary>
        private DataTable phieuGiangDay;

        public DataTable thoiKhoaBieu;

        public Dictionary<String, DTO_ThoiKhoaBieu> thoikhoabieu_thaydoi = new Dictionary<string, DTO_ThoiKhoaBieu>();

        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };

        //mode == 0 không có dạy
        //mode == 1: có dạy
        private new void Paint(string maPC, int maBuoiHoc, int thu, int tietBD, int soTiet, string monHoc, string giangVien, string lop, int mode, string diaChi)
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
                        if (mode == 0)//ko có dạy
                        {
                            motTiet.BackColor = Color.Gold;
                            motTiet.lblMonHoc.Click += new EventHandler(XuLy);
                        }
                        else//có dạy
                        {
                            motTiet.BackColor = Color.LightSalmon;
                        }
                        ThongTinChiTietTKB(motTiet.lblMonHoc, motTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi, mode);
                        motTiet.lblMonHoc.Cursor = Cursors.Hand;
                        motTiet.Name = "1" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = lop;
                        haiTiet.MonHoc = monHoc;
                        haiTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//ko có dạy
                        {
                            haiTiet.BackColor = Color.Gold;
                            haiTiet.lblMonHoc.Click += new EventHandler(XuLy);
                        }
                        else//có dạy
                        {
                            haiTiet.BackColor = Color.LightSalmon;
                        }
                        ThongTinChiTietTKB(haiTiet.lblMonHoc, haiTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi, mode);
                        haiTiet.lblMonHoc.Cursor = Cursors.Hand;
                        haiTiet.Name = "2" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = lop;
                        baTiet.MonHoc = monHoc;
                        baTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//ko có dạy
                        {
                            baTiet.BackColor = Color.Gold;
                            baTiet.lblMonHoc.Click += new EventHandler(XuLy);
                        }
                        else//có dạy
                        {
                            baTiet.BackColor = Color.LightSalmon;
                        }
                        ThongTinChiTietTKB(baTiet.lblMonHoc, baTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi, mode);
                        baTiet.lblMonHoc.Cursor = Cursors.Hand;
                        baTiet.Name = "3" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = lop;
                        bonTiet.MonHoc = monHoc;
                        bonTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//ko có dạy
                        {
                            bonTiet.BackColor = Color.Gold;
                            bonTiet.lblMonHoc.Click += new EventHandler(XuLy);
                        }
                        else//có dạy
                        {
                            bonTiet.BackColor = Color.LightSalmon;
                        }
                        ThongTinChiTietTKB(bonTiet.lblMonHoc, bonTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi, mode);
                        bonTiet.lblMonHoc.Cursor = Cursors.Hand;
                        bonTiet.Name = "4" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = lop;
                        namTiet.MonHoc = monHoc;
                        namTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//ko có dạy
                        {
                            namTiet.BackColor = Color.Gold;
                            namTiet.lblMonHoc.Click += new EventHandler(XuLy);
                        }
                        else//có dạy
                        {
                            namTiet.BackColor = Color.LightSalmon;
                        }
                        ThongTinChiTietTKB(namTiet.lblMonHoc, namTiet.toolTipController1, monHoc, tietBD, soTiet, giangVien, lop, diaChi, mode);
                        namTiet.lblMonHoc.Cursor = Cursors.Hand;
                        namTiet.Name = "5" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
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

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                string MaPC, TenMH, TenGV, MaPhong, DiaChi;
                int BuoiHoc, TietBatDau, SoTiet;
                DateTime Ngay;
                bool CoDay;
                #region Vẽ các thời khóa biểu đã xếp
                foreach (DataRow t in phieuGiangDay.Rows)
                {
                    MaPC = t[0].ToString();
                    BuoiHoc = int.Parse(t[6].ToString());
                    TietBatDau = int.Parse(t[8].ToString());
                    SoTiet = int.Parse(t[9].ToString());
                    TenMH = t[4].ToString();
                    TenGV = t[2].ToString();
                    MaPhong = t[10].ToString();
                    DiaChi = t[14].ToString();
                    Ngay = DateTime.Parse(t[7].ToString());
                    CoDay = bool.Parse(t[11].ToString());
                    Thu th = Thu.Thu2;
                    switch (Ngay.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            th = Thu.Thu2;
                            break;
                        case DayOfWeek.Tuesday:
                            th = Thu.Thu3;
                            break;
                        case DayOfWeek.Wednesday:
                            th = Thu.Thu4;
                            break;
                        case DayOfWeek.Thursday:
                            th = Thu.Thu5;
                            break;
                        case DayOfWeek.Friday:
                            th = Thu.Thu6;
                            break;
                        case DayOfWeek.Saturday:
                            th = Thu.Thu7;
                            break;
                        case DayOfWeek.Sunday:
                            th = Thu.ChuNhat;
                            break;
                    }
                    int mode = CoDay ? 1 : 0;
                    Paint(MaPC, BuoiHoc, (int)th, TietBatDau, SoTiet, TenMH, TenGV, MaPhong, mode, DiaChi);
                }
                #endregion
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
                thoikhoabieu_thaydoi.Clear();
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

        private void ThongTinChiTietTKB(Label lbl, ToolTipController toolTipController1, string tenMH, int tietBD, int soTiet, string tenGV, string phongHoc, string diaChi, int mode)
        {
            try
            {
                SuperToolTip superToolTip1 = new SuperToolTip();

                ToolTipTitleItem toolTipTitleItem1 = new ToolTipTitleItem();
                toolTipTitleItem1.Appearance.Image = global::QuanLyDaoTao.Properties.Resources.non_32;
                toolTipTitleItem1.Appearance.Options.UseImage = true;
                toolTipTitleItem1.Image = global::QuanLyDaoTao.Properties.Resources.non_32;
                toolTipTitleItem1.Text = "Thông tin chi tiết thời khóa biểu";

                ToolTipItem toolTipItem1 = new ToolTipItem();
                toolTipItem1.LeftIndent = 6;
                toolTipItem1.Text += "Tên môn học: " + tenMH;
                toolTipItem1.Text += "\nTiết bắt đầu: " + (tietBD + 1).ToString();
                toolTipItem1.Text += "\nSố tiết: " + soTiet.ToString();
                toolTipItem1.Text += "\nGiảng viên: " + tenGV;
                toolTipItem1.Text += "\nPhòng học: " + phongHoc;
                toolTipItem1.Text += "\nĐịa chỉ: " + diaChi;
                if (mode == 1)
                    toolTipItem1.Text += "\nTrạng thái: Đã dạy";
                else
                    toolTipItem1.Text += "\nTrạng thái: Chưa/không dạy";

                ToolTipTitleItem toolTipTitleItem2 = new ToolTipTitleItem();
                toolTipTitleItem2.LeftIndent = 6;
                toolTipTitleItem2.Text = "Hệ thống quản lý đào tạo";
                superToolTip1.Items.Add(toolTipTitleItem1);
                superToolTip1.Items.Add(toolTipItem1);

                ToolTipSeparatorItem toolTipSeparatorItem1 = new ToolTipSeparatorItem();
                superToolTip1.Items.Add(toolTipSeparatorItem1);
                superToolTip1.Items.Add(toolTipTitleItem2);

                toolTipController1.SetSuperTip(lbl, superToolTip1);
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
                phieuGiangDay.Clear();
                phieuGiangDay = bus_tkb.PhieuGiangDay(maLop, ngayDauTuan);
                ThoiKhoaBieu_Load(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void XuLy(object sender, EventArgs e)
        {
            try
            {
                Label obj = (Label)sender;
                string name = obj.Parent.Name;
                int mode = -1;
                mode = int.Parse(name.Substring(13, 1));
                if (mode == 0)
                {
                    string maPC = name.Substring(14, 7);
                    int maBuoi = int.Parse(name.Substring(21));
                    DTO_ThoiKhoaBieu add;
                    if (obj.Parent.BackColor == Color.Gold)//chưa có dạy
                    {
                        add = new DTO_ThoiKhoaBieu(maPC, maBuoi.ToString(), "", false, false);
                        if (thoikhoabieu_thaydoi.ContainsKey(add.MaPC + add.BuoiHoc))
                        {
                            thoikhoabieu_thaydoi.Remove(add.MaPC + add.BuoiHoc);
                            add.CoDay = true;
                            thoikhoabieu_thaydoi.Add(add.MaPC + add.BuoiHoc, add);
                        }
                        else
                        {
                            add.CoDay = true;
                            thoikhoabieu_thaydoi.Add(add.MaPC + add.BuoiHoc, add);
                        }

                        obj.Parent.BackColor = Color.PaleTurquoise;
                    }
                    else if (obj.Parent.BackColor == Color.PaleTurquoise)
                    {
                        add = new DTO_ThoiKhoaBieu(maPC, maBuoi.ToString(), "", true, false);
                        if (thoikhoabieu_thaydoi.ContainsKey(add.MaPC + add.BuoiHoc))
                        {
                            thoikhoabieu_thaydoi.Remove(add.MaPC + add.BuoiHoc);
                            add.CoDay = false;
                            thoikhoabieu_thaydoi.Add(add.MaPC + add.BuoiHoc, add);
                        }
                        else
                        {
                            add.CoDay = false;
                            thoikhoabieu_thaydoi.Add(add.MaPC + add.BuoiHoc, add);
                        }

                        obj.Parent.BackColor = Color.Gold;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
