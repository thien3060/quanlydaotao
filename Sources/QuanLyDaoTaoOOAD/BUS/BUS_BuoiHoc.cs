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
    public class BUS_BuoiHoc
    {
        private DAO_BuoiHoc buoihoc = new DAO_BuoiHoc();
        public DataTable TaobangBuoiHoc(string dieukien)
        {
            return buoihoc.TaobangBuoiHoc(dieukien);
        }
        public void ThemdulieuBuoiHoc(DTO_BuoiHoc et)
        {
            buoihoc.ThemBuoiHoc(et);
        }
        public void SuadulieuBuoiHoc(DTO_BuoiHoc et)
        {
            buoihoc.CapNhatBuoiHoc(et);
        }
        public void XoadulieuBuoiHoc(DTO_BuoiHoc et)
        {
            buoihoc.XoaBuoiHoc(et);
        }
        public DataTable DanhSachBuoiHocTheoTuan(DateTime ngayDauTuan)
        {
            return buoihoc.DanhSachBuoiHocTheoTuan(ngayDauTuan);
        }
        public DTO_BuoiHoc LayBuoiHoc(string mabuoihoc)
        {
            DataRow row = buoihoc.LayBuoiHoc(mabuoihoc);
            DTO_BuoiHoc bh = new DTO_BuoiHoc();
            if (row != null)
            {
                bh.MaBH = row[0].ToString();
                bh.Ngay = DateTime.Parse(row[1].ToString());
                bh.TietBatDau = int.Parse(row[2].ToString());
                bh.SoTiet = int.Parse(row[3].ToString());

                return bh;
            }
            else
            {
                return null;
            }
        }
        public void Them(DataTable buoiHocs)
        {
            try
            {
                foreach (DataRow row in buoiHocs.Rows)
                {
                    DTO_BuoiHoc b = new DTO_BuoiHoc(row[0].ToString(), DateTime.Parse(row[1].ToString()), int.Parse(row[2].ToString()), int.Parse(row[3].ToString()));
                    if (LayBuoiHoc(b.MaBH) == null)
                        ThemdulieuBuoiHoc(b);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string LayMaCuoiCung()
        {
            return buoihoc.LayMaBuoiHocLonNhat();
        }

        public string TuTinhMa()
        {
            string s = buoihoc.LayMaBuoiHocLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "BH001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "BH" + last.ToString("000");
            return maMoi;
        }
    }
}
