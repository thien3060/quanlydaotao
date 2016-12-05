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
    public class BUS_HocPhan
    {
        private DAO_HocPhan hocphan = new DAO_HocPhan();
        public DataTable TaobangHocPhan(string dieukien)
        {
            return hocphan.TaobangHocPhan(dieukien);
        }
        public DataTable GetHocPhanByMaKHDT(String MaKHDT)
        {
            return hocphan.GetHocPhanByMaKHDT(MaKHDT);
        }
        public void ThemdulieuHocPhan(DTO_HocPhan et)
        {
            hocphan.ThemHocPhan(et);
        }
        public void SuadulieuHocPhan(DTO_HocPhan et)
        {
            hocphan.CapNhatHocPhan(et);
        }
        public void XoadulieuHocPhan(DTO_HocPhan et)
        {
            hocphan.XoaHocPhan(et);
        }

        public string TuTinhMa()
        {
            string s = hocphan.LayMaHocPhanLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "HP001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "HP" + last.ToString("000"); 
            return maMoi;
        }
    }
}
