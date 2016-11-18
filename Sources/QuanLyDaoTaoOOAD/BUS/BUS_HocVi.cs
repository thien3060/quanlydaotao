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
    public class BUS_HocVi
    {
        private DAO_HocVi khoa = new DAO_HocVi();
        public DataTable TaobangHocVi(string dieukien)
        {
            return khoa.TaobangHocVi(dieukien);
        }
        public void ThemdulieuHocVi(DTO_HocVi et)
        {
            khoa.ThemHocVi(et);
        }
        public void SuadulieuHocVi(DTO_HocVi et)
        {
            khoa.CapNhatHocVi(et);
        }
        public void XoadulieuHocVi(DTO_HocVi et)
        {
            khoa.XoaHocVi(et);
        }

        public string TuTinhMa()
        {
            string s = khoa.LayMaHocViLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "HV001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "HV" + last.ToString("000"); 
            return maMoi;
        }
    }
}
