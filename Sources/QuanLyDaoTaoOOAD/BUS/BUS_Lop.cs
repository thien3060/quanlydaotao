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
    public class BUS_Lop
    {
        private DAO_Lop lop = new DAO_Lop();
        public DataTable TaobangLop(string dieukien)
        {
            return lop.TaobangLop(dieukien);
        }
        public DataTable GetByMaLop(DTO_Lop et)
        {
            return lop.GetByMaNganh(et);
        }
        public void ThemdulieuLop(DTO_Lop et)
        {
            lop.ThemLop(et);
        }
        public void SuadulieuLop(DTO_Lop et)
        {
            lop.CapNhatLop(et);
        }
        public void XoadulieuLop(DTO_Lop et)
        {
            lop.XoaLop(et);
        }
    }
}
