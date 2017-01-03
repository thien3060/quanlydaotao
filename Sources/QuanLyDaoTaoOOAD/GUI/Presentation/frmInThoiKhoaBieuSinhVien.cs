using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using BUS;
using DTO;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Utils;
using QuanLyDaoTao.Enums;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmInThoiKhoaBieuSinhVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        Bitmap memoryImage;
        Image image;

        public frmInThoiKhoaBieuSinhVien()
        {
            InitializeComponent();
        }

        private void Set_cmbSinhVien()
        {
            try
            {
                cmbSinhVien.Properties.DataSource = bus_sv.TaobangSinhVien("");
                //neu dang nhap bang quyen sinh vien
                if (int.Parse(StaticClass.User.Quyen) == (int)QuyenNguoiDung.SinhVien)
                {
                    xemThoiKhoaBieuSinhVien1.MSSV = StaticClass.User.TenDangNhap.ToUpper();
                    cmbSinhVien.EditValue = StaticClass.User.TenDangNhap.ToUpper();
                    cmbSinhVien.Properties.ReadOnly = true;
                }
                else//dang nhap bang quyen admin
                {
                    cmbSinhVien.Properties.ReadOnly = false;
                    cmbSinhVien.EditValue = cmbSinhVien.Properties.GetDataSourceValue("MSSV", 0);
                    xemThoiKhoaBieuSinhVien1.MSSV = cmbSinhVien.EditValue.ToString();
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

        private void frmInThoiKhoaBieuSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                //cmbSinhVien
                Set_cmbSinhVien();

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
                xemThoiKhoaBieuSinhVien1.MSSV = cmbSinhVien.EditValue.ToString();
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
                xemThoiKhoaBieuSinhVien1.NgayDauTuan = DateTime.ParseExact(cmbTuan.SelectedItem.ToString().Substring(3, 10), "dd/MM/yyyy", null);
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

        private void dateNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateNamHoc.EditValue != null)
                    Set_cmbTuan();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            image = memoryImage;

            float newWidth = image.Width * 100 / image.HorizontalResolution;
            float newHeight = image.Height * 100 / image.VerticalResolution;

            float widthFactor = newWidth / e.MarginBounds.Width;
            float heightFactor = newHeight / e.MarginBounds.Height;

            if (widthFactor > 1 | heightFactor > 1)
            {
                if (widthFactor > heightFactor)
                {
                    newWidth = newWidth / widthFactor;
                    newHeight = newHeight / widthFactor;
                }
                else
                {
                    newWidth = newWidth / heightFactor;
                    newHeight = newHeight / heightFactor;
                }
            }

            // calculate width and height scalings taking page margins into account
            var wScale = e.MarginBounds.Width / (float)memoryImage.Width;
            var hScale = e.MarginBounds.Height / (float)memoryImage.Height;

            // choose the smaller of the two scales
            var scale = wScale < hScale ? wScale : hScale;

            // apply scaling to the image
            e.Graphics.ScaleTransform(scale, scale);

            // print to default printer's page
            //e.Graphics.DrawImage(memoryImage, 0, 0);
            e.Graphics.DrawImage(image, 0, 100, newWidth * 3, newHeight * 3);
        }

        private void CaptureScreen()
        {
            // put into using construct because Graphics objects do not 
            //  get automatically disposed when leaving method scope
            using (var myGraphics = CreateGraphics())
            {
                var s = Size;

                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                
                using (var memoryGraphics = Graphics.FromImage(memoryImage))
                {
                    memoryGraphics.CopyFromScreen(this.formBounds.X, this.formBounds.Y, 0, 0, s);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                btnIn.Visible = false;
                CaptureScreen();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                btnIn.Visible = true;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}