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
    public class BUS_GiangDay
    {
        private DAO_GiangDay giangday = new DAO_GiangDay();
        public DataTable TaobangGiangDay(string dieukien)
        {
            return giangday.TaobangGiangDay(dieukien);
        }
        public void ThemdulieuGiangDay(DTO_GiangDay et)
        {
            giangday.ThemGiangDay(et);
        }
        public void SuadulieuGiangDay(DTO_GiangDay et)
        {
            giangday.CapNhatGiangDay(et);
        }
        public void XoadulieuGiangDay(DTO_GiangDay et)
        {
            giangday.XoaGiangDay(et);
        }

        public string TuTinhMa()
        {
            string s = giangday.LayMaGiangDayLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "GD001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "GD" + last.ToString("000"); 
            return maMoi;
        }
    }
}
