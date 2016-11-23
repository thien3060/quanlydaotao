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
    public class BUS_NhomHP
    {
        private DAO_NhomHP nhomhp = new DAO_NhomHP();
        public DataTable TaobangNhomHP(string dieukien)
        {
            return nhomhp.TaobangNhomHP(dieukien);
        }
        public void ThemdulieuNhomHP(DTO_NhomHP et)
        {
            nhomhp.ThemNhomHP(et);
        }
        public void SuadulieuNhomHP(DTO_NhomHP et)
        {
            nhomhp.CapNhatNhomHP(et);
        }
        public void XoadulieuNhomHP(DTO_NhomHP et)
        {
            nhomhp.XoaNhomHP(et);
        }

        public string TuTinhMa()
        {
            string s = nhomhp.LayMaNhomHPLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "NHP001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "NHP" + last.ToString("000");
            return maMoi;
        }
    }
}
