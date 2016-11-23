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
    public class BUS_HocKy
    {
        private DAO_HocKy hocky = new DAO_HocKy();
        public DataTable TaobangHocKy(string dieukien)
        {
            return hocky.TaobangHocKy(dieukien);
        }
        public void ThemdulieuHocKy(DTO_HocKy et)
        {
            hocky.ThemHocKy(et);
        }
        public void SuadulieuHocKy(DTO_HocKy et)
        {
            hocky.CapNhatHocKy(et);
        }
        public void XoadulieuHocKy(DTO_HocKy et)
        {
            hocky.XoaHocKy(et);
        }

        public string TuTinhMa()
        {
            string s = hocky.LayMaHocKyLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "HK001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "HK" + last.ToString("000");
            return maMoi;
        }
    }
}
