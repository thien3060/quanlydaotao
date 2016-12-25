﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DTO;
using BUS;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Presentation;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Utils;
using System.Collections.ObjectModel;

namespace QuanLyDaoTao.UserControls
{
    public partial class ThoiKhoaBieu : UserControl
    {
        BUS_ThoiKhoaBieu bus_tkb = new BUS_ThoiKhoaBieu();
        public ThoiKhoaBieu()
        {
            try
            {
                InitializeComponent();
                maPhong = string.Empty;
                ngayDauTuan = DateTime.Now.AddDays(DayOfWeek.Monday - DateTime.Now.DayOfWeek);
                TKBDangXep = new Collection<DTO_ThoiKhoaBieu>();
                thongTinhXeopTKB = new DataTable();
                TKBs = new DataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set
            {
                maPhong = value;
                if (!string.IsNullOrEmpty(value))
                {
                    thongTinhXeopTKB.Clear();
                    thongTinhXeopTKB = bus_tkb.DeNghiTheoPhongTrongTuan(maPhong, ngayDauTuan);
                    TKBs.Clear();
                    TKBs = bus_tkb.ThongTinTKB(maPhong, ngayDauTuan);
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
                        thongTinhXeopTKB.Clear();
                        thongTinhXeopTKB = bus_tkb.DeNghiTheoPhongTrongTuan(maPhong, value);
                        TKBs.Clear();
                        TKBs = bus_tkb.ThongTinTKB(maPhong, value);
                        TKBDangXep.Clear();
                        ThoiKhoaBieu_Load(null, null);
                    }
                }
                else
                    throw new Exception("Ngày đầu tuần phải là thứ 2");
            }
        }

        private Thu thu = Thu.Thu2;

        public DataTable TKBs;

        public DataTable thongTinhXeopTKB;

        public Collection<DTO_ThoiKhoaBieu> TKBDangXep;

        private int[] XThu = { 0, 144, 287, 431, 575, 719, 863 };
        private int[] YTiet = { 0, 41, 82, 123, 164, 205, 246, 287, 328, 369 };

        public bool ThemTKB(DataRow t)
        {
            try
            {
                TKBDangXep.Add(new DTO_ThoiKhoaBieu(t[0].ToString(), t[6].ToString(), maPhong, false, false));

                Paint(t[0].ToString(), int.Parse(t[6].ToString()), (int)thu, int.Parse(t[8].ToString()), int.Parse(t[9].ToString()), t[4].ToString(), t[2].ToString(), t[5].ToString(), 1, t[1].ToString(), t[3].ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //mode == 0: đề nghị chưa được xếp thời khóa biểu
        //mode == 1: thời khóa biểu đang đucợ xếp nhưng chưa lưu vào CSDL
        //mode == 2: thời khóa biểu đã lưu vào CSDL rồi
        private new void Paint(string maPC, int maBuoiHoc, int thu, int tietBD, int soTiet, string monHoc, string giangVien, string lop, int mode, string maGV, string maMH)
        {
            try
            {
                switch (soTiet)
                {
                    case 1:
                        MotTiet motTiet = new MotTiet();
                        motTiet.PhongHoc = lop;
                        motTiet.MonHoc = monHoc + "\n" + giangVien;
                        motTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//de nghi
                        {
                            motTiet.Cursor = Cursors.Hand;
                            motTiet.Controls.Remove(motTiet.lblMonHoc);
                            motTiet.Controls.Remove(motTiet.lblPhong);
                            motTiet.Click += new EventHandler(XepTKB);
                        }
                        else if (mode == 1)//dang xep
                        {
                            motTiet.lblMonHoc.Cursor = Cursors.Hand;
                            motTiet.lblMonHoc.Click += new EventHandler(RemoveTKB);
                            motTiet.BackColor = Color.PaleTurquoise;
                            ThongTinChiTietTKB(motTiet.lblMonHoc, motTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                        }
                        else//da xep roi
                        {
                            motTiet.BackColor = Color.Gold;
                            ThongTinChiTietTKB(motTiet.lblMonHoc, motTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                            motTiet.lblMonHoc.Cursor = Cursors.Hand;
                            motTiet.lblMonHoc.Click += new EventHandler(XoaTKBDaXep);
                        }
                        motTiet.Name = "1" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(motTiet);
                        motTiet.BringToFront();
                        break;
                    case 2:
                        HaiTiet haiTiet = new HaiTiet();
                        haiTiet.PhongHoc = lop;
                        haiTiet.MonHoc = monHoc + "\n" + giangVien;
                        haiTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//de nghi
                        {
                            haiTiet.Cursor = Cursors.Hand;
                            haiTiet.Controls.Remove(haiTiet.lblMonHoc);
                            haiTiet.Controls.Remove(haiTiet.lblPhong);
                            haiTiet.Click += new EventHandler(XepTKB);
                        }
                        else if (mode == 1)//dang xep
                        {
                            haiTiet.lblMonHoc.Cursor = Cursors.Hand;
                            haiTiet.lblMonHoc.Click += new EventHandler(RemoveTKB);
                            haiTiet.BackColor = Color.PaleTurquoise;
                            ThongTinChiTietTKB(haiTiet.lblMonHoc, haiTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                        }
                        else//da xep roi
                        {
                            haiTiet.BackColor = Color.Gold;
                            ThongTinChiTietTKB(haiTiet.lblMonHoc, haiTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                            haiTiet.lblMonHoc.Cursor = Cursors.Hand;
                            haiTiet.lblMonHoc.Click += new EventHandler(XoaTKBDaXep);
                        }
                        haiTiet.Name = "2" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(haiTiet);
                        haiTiet.BringToFront();
                        break;
                    case 3:
                        BaTiet baTiet = new BaTiet();
                        baTiet.PhongHoc = lop;
                        baTiet.MonHoc = monHoc + "\n" + giangVien;
                        baTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//de nghi
                        {
                            baTiet.Cursor = Cursors.Hand;
                            baTiet.Controls.Remove(baTiet.lblMonHoc);
                            baTiet.Controls.Remove(baTiet.lblPhong);
                            baTiet.Click += new EventHandler(XepTKB);
                        }
                        else if (mode == 1)//dang xep
                        {
                            baTiet.lblMonHoc.Cursor = Cursors.Hand;
                            baTiet.lblMonHoc.Click += new EventHandler(RemoveTKB);
                            baTiet.BackColor = Color.PaleTurquoise;
                            ThongTinChiTietTKB(baTiet.lblMonHoc, baTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                        }
                        else//da xep roi
                        {
                            baTiet.BackColor = Color.Gold;
                            ThongTinChiTietTKB(baTiet.lblMonHoc, baTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                            baTiet.lblMonHoc.Cursor = Cursors.Hand;
                            baTiet.lblMonHoc.Click += new EventHandler(XoaTKBDaXep);
                        }
                        baTiet.Name = "3" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(baTiet);
                        baTiet.BringToFront();
                        break;
                    case 4:
                        BonTiet bonTiet = new BonTiet();
                        bonTiet.PhongHoc = lop;
                        bonTiet.MonHoc = monHoc + "\n" + giangVien;
                        bonTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//de nghi
                        {
                            bonTiet.Cursor = Cursors.Hand;
                            bonTiet.Controls.Remove(bonTiet.lblMonHoc);
                            bonTiet.Controls.Remove(bonTiet.lblPhong);
                            bonTiet.Click += new EventHandler(XepTKB);
                        }
                        else if (mode == 1)//dang xep
                        {
                            bonTiet.lblMonHoc.Cursor = Cursors.Hand;
                            bonTiet.lblMonHoc.Click += new EventHandler(RemoveTKB);
                            bonTiet.BackColor = Color.PaleTurquoise;
                            ThongTinChiTietTKB(bonTiet.lblMonHoc, bonTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                        }
                        else//da xep roi
                        {
                            bonTiet.BackColor = Color.Gold;
                            ThongTinChiTietTKB(bonTiet.lblMonHoc, bonTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                            bonTiet.lblMonHoc.Cursor = Cursors.Hand;
                            bonTiet.lblMonHoc.Click += new EventHandler(XoaTKBDaXep);
                        }
                        bonTiet.Name = "4" + ngayDauTuan.AddDays((int)thu).ToString("dd/MM/yyyy") + tietBD.ToString() + soTiet.ToString() + mode.ToString() + maPC + maBuoiHoc.ToString();
                        pnChinh.Controls.Add(bonTiet);
                        bonTiet.BringToFront();
                        break;
                    case 5:
                        NamTiet namTiet = new NamTiet();
                        namTiet.PhongHoc = lop;
                        namTiet.MonHoc = monHoc + "\n" + giangVien;
                        namTiet.Location = new Point(XThu[thu], YTiet[tietBD]);
                        if (mode == 0)//de nghi
                        {
                            namTiet.Cursor = Cursors.Hand;
                            namTiet.Controls.Remove(namTiet.lblMonHoc);
                            namTiet.Controls.Remove(namTiet.lblPhong);
                            namTiet.Click += new EventHandler(XepTKB);
                        }
                        else if (mode == 1)//dang xep
                        {
                            namTiet.lblMonHoc.Cursor = Cursors.Hand;
                            namTiet.lblMonHoc.Click += new EventHandler(RemoveTKB);
                            namTiet.BackColor = Color.PaleTurquoise;
                            ThongTinChiTietTKB(namTiet.lblMonHoc, namTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                        }
                        else//da xep roi
                        {
                            namTiet.BackColor = Color.Gold;
                            ThongTinChiTietTKB(namTiet.lblMonHoc, namTiet.toolTipController1, monHoc, tietBD, soTiet, lop, maGV, giangVien, maMH);
                            namTiet.lblMonHoc.Cursor = Cursors.Hand;
                            namTiet.lblMonHoc.Click += new EventHandler(XoaTKBDaXep);
                        }
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

                #region Vẽ các đề nghị
                foreach (DataRow i in thongTinhXeopTKB.Rows)
                {
                    Thu t = Thu.Thu2;
                    switch (DateTime.Parse(i[7].ToString()).DayOfWeek)
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
                    Paint(i[0].ToString(), int.Parse(i[6].ToString()), (int)t, int.Parse(i[8].ToString()), int.Parse(i[9].ToString()), "", "", "", 0, "", "");
                }
                #endregion

                #region Vẽ các thời khóa biểu đã xếp
                foreach (DataRow t in TKBs.Rows)
                {
                    Thu th = Thu.Thu2;
                    switch (DateTime.Parse(t[7].ToString()).DayOfWeek)
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
                    Paint(t[0].ToString(), int.Parse(t[6].ToString()), (int)th, int.Parse(t[8].ToString()), int.Parse(t[9].ToString()), t[4].ToString(), t[2].ToString(), t[5].ToString(), 2, t[1].ToString(), t[3].ToString());
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
                while (pnChinh.Controls.Count > 19)
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
                TKBs.Clear();
                TKBs = bus_tkb.ThongTinTKB(maPhong, ngayDauTuan);
                ThoiKhoaBieu_Load(null, null);
                TKBDangXep.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void XepTKB(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay = DateTime.ParseExact(((UserControl)sender).Name.Substring(1, 10), "dd/MM/yyyy", null);
                Label lbl = new Label();
                switch ((int)ngay.Subtract(ngayDauTuan).TotalDays)
                {
                    case 0:
                        lbl = lbl0;
                        break;
                    case 1:
                        lbl = lbl1;
                        break;
                    case 2:
                        lbl = lbl2;
                        break;
                    case 3:
                        lbl = lbl3;
                        break;
                    case 4:
                        lbl = lbl4;
                        break;
                    case 5:
                        lbl = lbl5;
                        break;
                    case 6:
                        lbl = lbl6;
                        break;
                }
                lbl0_LinkClicked(lbl, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RemoveTKB(object sender, EventArgs e)
        {
            try
            {
                string name = ((Label)sender).Parent.Name;
                int mode = int.Parse(name.Substring(13, 1));
                if (mode == 1)
                {
                    pnChinh.Controls.Remove(((Label)sender).Parent);
                    string maPC = name.Substring(14, 7);
                    int maBuoi = int.Parse(name.Substring(21));
                    TKBDangXep.Remove(TKBDangXep.Single(x => x.MaPC == maPC && x.BuoiHoc == maBuoi.ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void XoaTKBDaXep(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxUtils.YesNo("Bạn chắc chắn muốn xóa buổi học này?") == DialogResult.Yes)
                {
                    string name = ((Label)sender).Parent.Name;
                    int mode = int.Parse(name.Substring(13, 1));
                    if (mode == 2)
                    {
                        pnChinh.Controls.Remove(((Label)sender).Parent);
                        string maPC = name.Substring(14, 7);
                        int maBuoi = int.Parse(name.Substring(21));
                        bus_tkb.XoadulieuThoiKhoaBieu(maPC, maBuoi);
                        thongTinhXeopTKB.Clear();
                        thongTinhXeopTKB = bus_tkb.DeNghiTheoPhongTrongTuan(maPhong, ngayDauTuan);
                        TKBs.Clear();
                        TKBs = bus_tkb.ThongTinTKB(maPhong, ngayDauTuan);
                        ThoiKhoaBieu_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lbl0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

                frmNhapTKB frm = new frmNhapTKB() { NgayDauTuan = ngayDauTuan, MaPhong = maPhong, Thu = thu };
                frm.TKBDangXep = this.TKBDangXep;
                frm.TKBs = this.TKBs;
                frm.truyen += new frmNhapTKB.TruyenMatKhau(ThemTKB);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void ThongTinChiTietTKB(Label lbl, ToolTipController toolTipController1, string tenMH, int tietBD, int soTiet, string lop, string maGV, string tenGV, string maMH)
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
                toolTipItem1.Text += "Giảng viên: " + maGV + " - " + tenGV;
                toolTipItem1.Text += "\nMôn học: " + maMH + " - " + tenMH;
                toolTipItem1.Text += "\nTiết bắt đầu: " + (tietBD + 1).ToString();
                toolTipItem1.Text += "\nSố tiết: " + soTiet.ToString();
                toolTipItem1.Text += "\nLớp: " + lop;

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
    }
}
