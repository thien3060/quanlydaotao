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
    public class BUS_PhanCong
    {
        private DAO_PhanCong phancong = new DAO_PhanCong();
        public DataTable TaobangPhanCong(string dieukien)
        {
            return phancong.TaobangPhanCong(dieukien);
        }
        public DataTable GetPhanCong(DTO_PhanCong et)
        {
            return phancong.GetPhanCong(et);
        }
        public void ThemdulieuPhanCong(DTO_PhanCong et)
        {
            phancong.ThemPhanCong(et);
        }
        public void SuadulieuPhanCong(DTO_PhanCong et)
        {
            phancong.CapNhatPhanCong(et);
        }
        public void XoadulieuPhanCong(DTO_PhanCong et)
        {
            phancong.XoaPhanCong(et);
        }

        public string TuTinhMa()
        {
            string s = phancong.LayMaPhanCongLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "PC00001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "PC" + last.ToString("00000"); 
            return maMoi;
        }
    }
}
