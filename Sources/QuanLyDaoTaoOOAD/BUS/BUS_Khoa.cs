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
    public class BUS_Khoa
    {
        private DAO_Khoa khoa = new DAO_Khoa();
        public DataTable TaobangKhoa(string dieukien)
        {
            return khoa.TaobangKhoa(dieukien);
        }
        public void ThemdulieuKhoa(DTO_Khoa et)
        {
            khoa.ThemKhoa(et);
        }
        public void SuadulieuKhoa(DTO_Khoa et)
        {
            khoa.CapNhatKhoa(et);
        }
        public void XoadulieuKhoa(DTO_Khoa et)
        {
            khoa.XoaKhoa(et);
        }

        public string TuTinhMa()
        {
            string s = khoa.LayMaKhoaLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "KH001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "KH" + last.ToString("000"); 
            return maMoi;
        }
    }
}
