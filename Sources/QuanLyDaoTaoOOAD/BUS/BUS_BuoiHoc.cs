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
