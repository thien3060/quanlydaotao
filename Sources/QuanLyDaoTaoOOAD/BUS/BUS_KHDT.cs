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
    public class BUS_KHDT
    {
        private DAO_KHDT khdt = new DAO_KHDT();
        public DataTable TaobangKHDT(string dieukien)
        {
            return khdt.TaobangKHDT(dieukien);
        }
        public void ThemdulieuKHDT(DTO_KHDT et)
        {
            khdt.ThemKHDT(et);
        }
        public void SuadulieuKHDT(DTO_KHDT et)
        {
            khdt.CapNhatKHDT(et);
        }
        public void XoadulieuKHDT(DTO_KHDT et)
        {
            khdt.XoaKHDT(et);
        }

        public string TuTinhMa()
        {
            string s = khdt.LayMaKHDTLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "KHDT001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(4).ToString()) + 1;
            maMoi = "KHDT" + last.ToString("000"); 
            return maMoi;
        }
    }
}
