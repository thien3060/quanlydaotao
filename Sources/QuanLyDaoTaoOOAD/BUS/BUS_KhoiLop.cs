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
    public class BUS_KhoiLop
    {
        private DAO_KhoiLop gv = new DAO_KhoiLop();
        public DataTable TaobangKhoiLop(string dieukien)
        {
            return gv.TaobangKhoiLop(dieukien);
        }
        public void ThemdulieuKhoiLop(DTO_KhoiLop et)
        {
            gv.ThemKhoiLop(et);
        }
        public void SuadulieuKhoiLop(DTO_KhoiLop et)
        {
            gv.CapNhatKhoiLop(et);
        }
        public void XoadulieuKhoiLop(DTO_KhoiLop et)
        {
            gv.XoaKhoiLop(et);
        }

        public string TuTinhMa()
        {
            string s = gv.LayMaKhoaLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "KL001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "Kl" + last.ToString("000");
            return maMoi;
        }
    }
}
