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
    public class BUS_MonHoc
    {
        private DAO_MonHoc monhoc = new DAO_MonHoc();
        public DataTable TaobangMonHoc(string dieukien)
        {
            return monhoc.TaobangMonHoc(dieukien);
        }
        public void ThemdulieuMonHoc(DTO_MonHoc et)
        {
            monhoc.ThemMonHoc(et);
        }
        public void SuadulieuMonHoc(DTO_MonHoc et)
        {
            monhoc.CapNhatMonHoc(et);
        }
        public void XoadulieuMonHoc(DTO_MonHoc et)
        {
            monhoc.XoaMonHoc(et);
        }

        public string TuTinhMa()
        {
            string s = monhoc.LayMaMonHocLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "MMH001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "MMH" + last.ToString("000"); 
            return maMoi;
        }
    }
}
