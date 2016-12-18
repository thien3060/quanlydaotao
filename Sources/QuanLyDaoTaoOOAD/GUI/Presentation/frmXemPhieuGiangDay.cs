﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using QuanLyDaoTao.Utils;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmXemPhieuGiangDay : DevExpress.XtraEditors.XtraForm
    {
        BUS_GiangVien bus_gv = new BUS_GiangVien();
        public frmXemPhieuGiangDay()
        {
            InitializeComponent();
        }

        private void Set_cmbGiangVien()
        {
            try
            {
                cmbGiangVien.Properties.DataSource = bus_gv.TaobangGiangVien("");
                //neu dang nhap bang quyen giang vien
                if (StaticClass.User.Quyen == QuyenNguoiDung.GiangVien.ToString())
                {
                    xemPhieuGiangDay1.MaGV = StaticClass.User.TenDangNhap.ToUpper();
                    cmbGiangVien.EditValue = StaticClass.User.TenDangNhap.ToUpper();
                    cmbGiangVien.Properties.ReadOnly = true;
                }
                else//dang nhap bang quyen admin
                {
                    cmbGiangVien.Properties.ReadOnly = false;
                    cmbGiangVien.EditValue = cmbGiangVien.Properties.GetDataSourceValue("MaGV", 0);
                    xemPhieuGiangDay1.MaGV = cmbGiangVien.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Set_numHocKy()
        {
            try
            {
                int thang = DateTime.Today.Month;
                if (thang >= 8)//hoc ky 1
                    numHocKy.Value = 1;
                else if (thang >= 1 && thang <= 5)//hoc ky 2
                    numHocKy.Value = 2;
                else
                    numHocKy.Value = 3;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Set_cmbTuan()
        {
            try
            {
                cmbTuan.Properties.Items.Clear();
                if (numHocKy.Value == 1)
                {
                    for (int i = 8; i <= 12; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                else if (numHocKy.Value == 2)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                else
                {
                    for (int i = 6; i <= 7; i++)
                    {
                        DateTime dauThang = new DateTime(dateNamHoc.DateTime.Year, i, 1);
                        List<DateTime> ngayDauTuan = dauThang.GetWeeks();
                        foreach (DateTime d in ngayDauTuan)
                        {
                            cmbTuan.Properties.Items.Add("Từ " + d.ToString("dd/MM/yyyy") + " -- Đến " + d.AddDays(6).ToString("dd/MM/yyyy"));
                        }
                    }
                }
                cmbTuan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemDeNghi_Load(object sender, EventArgs e)
        {
            try
            {
                //cmbPhong
                Set_cmbGiangVien();

                //num Hoc kỳ
                Set_numHocKy();

                //dateNamHoc
                dateNamHoc.DateTime = DateTime.Now;

                //cmbTuan
                Set_cmbTuan();
                DateTime ngayNay = DateTime.Now.GetWeek();
                cmbTuan.SelectedIndex = cmbTuan.Properties.Items.IndexOf("Từ " + ngayNay.ToString("dd/MM/yyyy") + " -- Đến " + ngayNay.AddDays(6).ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                xemPhieuGiangDay1.MaGV = cmbGiangVien.EditValue.ToString();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void cmbTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xemPhieuGiangDay1.NgayDauTuan = DateTime.ParseExact(cmbTuan.SelectedItem.ToString().Substring(3, 10), "dd/MM/yyyy", null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void numHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Set_cmbTuan();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            xemPhieuGiangDay1.InPhieuGiangDay();
        }
    }
}