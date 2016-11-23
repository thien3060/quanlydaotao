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
    public class BUS_NguoiDung
    {
        private DAO_NguoiDung nguoidung = new DAO_NguoiDung();
        public DataTable TaobangNguoiDung(string dieukien)
        {
            return nguoidung.TaobangNguoiDung(dieukien);
        }
        public void ThemdulieuNguoiDung(DTO_NguoiDung et)
        {
            nguoidung.ThemNguoiDung(et);
        }
        public void SuadulieuNguoiDung(DTO_NguoiDung et)
        {
            nguoidung.CapNhatNguoiDung(et);
        }
        public void XoadulieuNguoiDung(DTO_NguoiDung et)
        {
            nguoidung.XoaNguoiDung(et);
        }

        public string TuTinhMa()
        {
            string s = nguoidung.LayMaNguoiDungLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "USER001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(4).ToString()) + 1;
            maMoi = "USER" + last.ToString("000"); 
            return maMoi;
        }
    }
}
