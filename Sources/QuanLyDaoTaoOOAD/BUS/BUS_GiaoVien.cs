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
    public class BUS_GiaoVien
    {
        private DAO_GiaoVien gv = new DAO_GiaoVien();
        public DataTable TaobangGiaoVien(string dieukien)
        {
            return gv.TaobangGiaoVien(dieukien);
        }
        public void ThemdulieuGiaoVien(DTO_GiaoVien et)
        {
            gv.ThemGiaoVien(et);
        }
        public void SuadulieuGiaoVien(DTO_GiaoVien et)
        {
            gv.CapNhatGiaoVien(et);
        }
        public void XoadulieuGiaoVien(DTO_GiaoVien et)
        {
            gv.XoaGiaoVien(et);
        }

        public string TuTinhMa()
        {
            string s = gv.LayMaGiaoVienLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "GV001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "GV" + last.ToString("000");
            return maMoi;
        }
    }
}
