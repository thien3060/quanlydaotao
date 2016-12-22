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
using QuanLyDaoTao.Utilities;
using BUS;
using DTO;
using QuanLyDaoTao.Utils;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmXepThoiKhoaBieu : DevExpress.XtraEditors.XtraForm
    {
        BUS_PhongHoc bus_ph = new BUS_PhongHoc();
        BUS_ThoiKhoaBieu bus_tkb = new BUS_ThoiKhoaBieu();
        public frmXepThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void Set_cmbGiangVien()
        {
            try
            {
                cmbPhong.Properties.DataSource = bus_ph.TaobangPhongHoc("");
                cmbPhong.EditValue = cmbPhong.Properties.GetDataSourceValue("MaPhong", 0);
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
                thoiKhoaBieu1.MaPhong = cmbPhong.EditValue.ToString();
                txtSucChua.Text = cmbPhong.Properties.GetDataSourceValue("SucChua", cmbPhong.Properties.GetDataSourceRowIndex("MaPhong", cmbPhong.EditValue)).ToString();
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
                thoiKhoaBieu1.NgayDauTuan = DateTime.ParseExact(cmbTuan.SelectedItem.ToString().Substring(3, 10), "dd/MM/yyyy", null);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //bus_tkb.ThemdulieuThoiKhoaBieu(thoiKhoaBieu1.TKBDangXep);
                string tam = thoiKhoaBieu1.MaPhong;
                thoiKhoaBieu1.MaPhong = tam;
                MessageBoxUtils.Success("Thành công");
                //thoiKhoaBieu1.TKBDangXep.Clear();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}