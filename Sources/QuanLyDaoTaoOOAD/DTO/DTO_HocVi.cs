using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocVi
    {
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string MoTa { get; set; }

        public DTO_HocVi(string maHv, string tenHv, string moTa)
        {
            MaHV = maHv;
            TenHV = tenHv;
            MoTa = moTa;
        }
    }
}
