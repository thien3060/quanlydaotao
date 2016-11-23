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
    public class BUS_DamNhiem
    {
        private DAO_DamNhiem nganh = new DAO_DamNhiem();
        public DataTable TaobangDamNhiem(string dieukien)
        {
            return nganh.TaobangDamNhiem(dieukien);
        }
        public void ThemdulieuDamNhiem(DTO_DamNhiem et)
        {
            nganh.ThemDamNhiem(et);
        }
        public void SuadulieuDamNhiem(DTO_DamNhiem et)
        {
            nganh.CapNhatDamNhiem(et);
        }
        public void XoadulieuDamNhiem(DTO_DamNhiem et)
        {
            nganh.XoaDamNhiem(et);
        }
    }
}
