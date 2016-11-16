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
            int i = gv.LayKichThuocBang() + 1;
            string s;
            if (i < 10)
            {
                s = "GV00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                s = "GV0" + i.ToString();
            }
            else
            {
                s = "GV" + i.ToString();
            }
            return s;
        }
    }
}
