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
    public class BUS_NamHoc
    {
        private DAO_NamHoc namhoc = new DAO_NamHoc();
        public DataTable TaobangNamHoc(string dieukien)
        {
            return namhoc.TaobangNamHoc(dieukien);
        }
        public void ThemdulieuNamHoc(DTO_NamHoc et)
        {
            namhoc.ThemNamHoc(et);
        }
        public void SuadulieuNamHoc(DTO_NamHoc et)
        {
            namhoc.CapNhatNamHoc(et);
        }
        public void XoadulieuNamHoc(DTO_NamHoc et)
        {
            namhoc.XoaNamHoc(et);
        }

        public string TuTinhMa()
        {
            string s = namhoc.LayMaNamHocLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "NH001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "NH" + last.ToString("000"); 
            return maMoi;
        }
    }
}
