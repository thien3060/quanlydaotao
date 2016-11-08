using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_HocKy
    {
        public string MaHK { get; set; }
        public string TenHK { get; set; }
        public string MaNH { get; set; }

        public DTO_HocKy(string maHk, string tenHk, string maNh)
        {
            MaHK = maHk;
            TenHK = tenHk;
            MaNH = maNh;
        }
    }
}
