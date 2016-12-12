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
    public class BUS_TDDT
    {
        private DAO_TDDT khoa = new DAO_TDDT();
        public DataTable TaobangTDDT(string dieukien)
        {
            return khoa.TaobangTDDT(dieukien);
        }
        public void ThemdulieuTDDT(DTO_TDDT et)
        {
            khoa.ThemTDDT(et);
        }
        public void SuadulieuTDDT(DTO_TDDT et)
        {
            khoa.CapNhatTDDT(et);
        }
        public void XoadulieuTDDT(DTO_TDDT et)
        {
            khoa.XoaTDDT(et);
        }

        public string TuTinhMa()
        {
            string s = khoa.LayMaTDDTLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "TD001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(4).ToString()) + 1;
            maMoi = "TD" + last.ToString("000"); 
            return maMoi;
        }
    }
}
