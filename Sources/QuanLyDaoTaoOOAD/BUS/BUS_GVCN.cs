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
    public class BUS_GVCN
    {
        private DAO_GVCN gvcn = new DAO_GVCN();
        public DataTable TaobangGVCN(string dieukien)
        {
            return gvcn.TaobangGVCN(dieukien);
        }
        public void ThemdulieuGVCN(DTO_GVCN et)
        {
            gvcn.ThemGVCN(et);
        }
        public void SuadulieuGVCN(DTO_GVCN et)
        {
            gvcn.CapNhatGVCN(et);
        }
        public void XoadulieuGVCN(DTO_GVCN et)
        {
            gvcn.XoaGVCN(et);
        }
    }
}
