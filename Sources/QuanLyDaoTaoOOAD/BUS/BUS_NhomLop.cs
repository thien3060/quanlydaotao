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
    public class BUS_NhomLop
    {
        private DAO_NhomLop nganh = new DAO_NhomLop();
        public DataTable TaobangNhomLop(string dieukien)
        {
            return nganh.TaobangNhomLop(dieukien);
        }
        public void ThemdulieuNhomLop(DTO_NhomLop et)
        {
            nganh.ThemNhomLop(et);
        }
        public void SuadulieuNhomLop(DTO_NhomLop et)
        {
            nganh.CapNhatNhomLop(et);
        }
        public void XoadulieuNhomLop(DTO_NhomLop et)
        {
            nganh.XoaNhomLop(et);
        }

        public string TuTinhMa()
        {
            string s = nganh.LayMaNhomLopLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "NL001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "NL" + last.ToString("000");
            return maMoi;
        }
    }
}
