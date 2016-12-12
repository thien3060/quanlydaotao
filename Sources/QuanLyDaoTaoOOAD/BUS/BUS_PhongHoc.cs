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
    public class BUS_PhongHoc
    {
        private DAO_PhongHoc phongHoc = new DAO_PhongHoc();
        public DataTable TaobangPhongHoc(string dieukien)
        {
            return phongHoc.TaobangPhongHoc(dieukien);
        }
        public void ThemdulieuPhongHoc(DTO_PhongHoc et)
        {
            phongHoc.ThemPhongHoc(et);
        }
        public void SuadulieuPhongHoc(DTO_PhongHoc et)
        {
            phongHoc.CapNhatPhongHoc(et);
        }
        public void XoadulieuPhongHoc(DTO_PhongHoc et)
        {
            phongHoc.XoaPhongHoc(et);
        }

        public string TuTinhMa()
        {
            string s = phongHoc.LayMaPhongHocLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "PH0001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "PH" + last.ToString("0000");
            return maMoi;
        }
    }
}
