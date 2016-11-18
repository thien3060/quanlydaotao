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
    public class BUS_Nganh
    {
        private DAO_Nganh nganh = new DAO_Nganh();
        public DataTable TaobangNganh(string dieukien)
        {
            return nganh.TaobangNganh(dieukien);
        }
        public void ThemdulieuNganh(DTO_Nganh et)
        {
            nganh.ThemNganh(et);
        }
        public void SuadulieuNganh(DTO_Nganh et)
        {
            nganh.CapNhatNganh(et);
        }
        public void XoadulieuNganh(DTO_Nganh et)
        {
            nganh.XoaNganh(et);
        }

        public string TuTinhMa()
        {
            string s = nganh.LayMaNganhLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "NGH001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(3).ToString()) + 1;
            maMoi = "NGH" + last.ToString("000");
            return maMoi;
        }
    }
}
