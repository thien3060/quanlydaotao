using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhomLop
    {
        public string MaNL { get; set; }
        public string TenNL { get; set; }
        public string MaKL { get; set; }

        public DTO_NhomLop() { }

        public DTO_NhomLop(string maNl, string tenNl, string maKl)
        {
            MaNL = maNl;
            TenNL = tenNl;
            MaKL = maKl;
        }
    }
}
