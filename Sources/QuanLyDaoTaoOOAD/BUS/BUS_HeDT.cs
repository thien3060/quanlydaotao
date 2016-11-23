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
    public class BUS_HeDT
    {
        private DAO_HeDT khoa = new DAO_HeDT();
        public DataTable TaobangHeDT(string dieukien)
        {
            return khoa.TaobangHeDT(dieukien);
        }
        public void ThemdulieuHeDT(DTO_HeDT et)
        {
            khoa.ThemHeDT(et);
        }
        public void SuadulieuHeDT(DTO_HeDT et)
        {
            khoa.CapNhatHeDT(et);
        }
        public void XoadulieuHeDT(DTO_HeDT et)
        {
            khoa.XoaHeDT(et);
        }

        public string TuTinhMa()
        {
            string s = khoa.LayMaHeDTLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "HDT001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "HDT" + last.ToString("000"); 
            return maMoi;
        }
    }
}
