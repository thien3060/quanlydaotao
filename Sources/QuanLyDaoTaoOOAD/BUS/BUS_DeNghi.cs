using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_DeNghi
    {
        private DAO_DeNghi denghi = new DAO_DeNghi();
        public DataTable TaobangDeNghi(string dieukien)
        {
            return denghi.TaobangDeNghi(dieukien);
        }
        public void ThemdulieuDeNghi(DTO_DeNghi et)
        {
            denghi.ThemDeNghi(et);
        }
        public void SuadulieuDeNghi(DTO_DeNghi et)
        {
            denghi.CapNhatDeNghi(et);
        }
        public void XoadulieuDeNghi(DTO_DeNghi et)
        {
            denghi.XoaDeNghi(et);
        }
        //public string[] LayMaCuoiCung()
        //{
        //    return denghi.LayMaDeNghiLonNhat();
        //}
        public DTO_DeNghi LayDeNghi(string mapc, int buoihoc)
        {
            DataRow row = denghi.LayDeNghi(mapc, buoihoc);
            DTO_DeNghi dn = new DTO_DeNghi();
            if (row != null)
            {
                dn.MaPC = row[0].ToString();
                dn.BuoiHoc = int.Parse(row[1].ToString());
                
                return dn;
            }
            else
            {
                return null;
            }
        }
        public bool KiemTraTonTai(string mapc, int buoihoc)
        {
            DataRow row = denghi.LayDeNghi(mapc, buoihoc);
            if (row != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Them(DataTable deNghis)
        {
            try
            {
                foreach (DataRow row in deNghis.Rows)
                {
                    DTO_DeNghi dn = new DTO_DeNghi(row[1].ToString(), int.Parse(row[0].ToString()));
                    ThemdulieuDeNghi(dn);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ThongTinDeNghi(int mabuoihoc, string mapc)
        {
            return denghi.ThongTinDeNghi(mabuoihoc, mapc);
        }
        public DataTable ThongTinPhanCongTheoGV(string maGV, int hocky, int namhoc)
        {
            return denghi.ThongTinPhanCongTheoGV(maGV, hocky, namhoc);
        }
        public DataTable DanhSachDeNghiTheoTuan(string magv, DateTime ngayDauTuan)
        {
            return denghi.DanhSachDeNghiTheoTuan(magv, ngayDauTuan);
        }
    }
}
