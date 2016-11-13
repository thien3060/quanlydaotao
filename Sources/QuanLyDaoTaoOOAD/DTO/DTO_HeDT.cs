using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HeDT
    {
        public string MaHDT { get; set; }
        public string TenHDT { get; set; }

        public DTO_HeDT(string maHdt, string tenHdt)
        {
            MaHDT = maHdt;
            TenHDT = tenHdt;
        }
    }
}
