using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        public string MaLop { get; set; }
        public string MaNganh { get; set; }

        public DTO_Lop() { }

        public DTO_Lop(string maLop, string maNganh)
        {
            MaLop = maLop;
            MaNganh = maNganh;
        }
    }
}
