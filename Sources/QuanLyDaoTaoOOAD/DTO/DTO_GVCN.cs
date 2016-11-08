using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_GVCN
    {
        public string MaGV { get; set; }
        public string MaNL { get; set; }
        public string MaNH { get; set; }
        public string GhiChu { get; set; }

        public DTO_GVCN(string maGv, string maNl, string maNh, string ghiChu)
        {
            MaGV = maGv;
            MaNL = maNl;
            MaNH = maNh;
            GhiChu = ghiChu;
        }
    }
}
