using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_NamHoc
    {
        public string MaNH { get; set; }
        public string TenNH { get; set; }

        public DTO_NamHoc(string maNh, string tenNh)
        {
            MaNH = maNh;
            TenNH = tenNh;
        }
    }
}
