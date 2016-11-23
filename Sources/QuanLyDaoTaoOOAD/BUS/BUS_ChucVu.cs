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
    public class BUS_ChucVu
    {
        private DAO_ChucVu chucvu = new DAO_ChucVu();
        public DataTable TaobangChucVu(string dieukien)
        {
            return chucvu.TaobangChucVu(dieukien);
        }
        public void ThemdulieuChucVu(DTO_ChucVu et)
        {
            chucvu.ThemChucVu(et);
        }
        public void SuadulieuChucVu(DTO_ChucVu et)
        {
            chucvu.CapNhatChucVu(et);
        }
        public void XoadulieuChucVu(DTO_ChucVu et)
        {
            chucvu.XoaChucVu(et);
        }

        public string TuTinhMa()
        {
            string s = chucvu.LayMaChucVuLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "CV001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "CV" + last.ToString("000"); 
            return maMoi;
        }
    }
}
