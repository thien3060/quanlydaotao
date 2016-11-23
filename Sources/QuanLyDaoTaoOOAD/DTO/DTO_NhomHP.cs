using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhomHP
    {
        public string MaNHP { get; set; }
        public string TenNHP { get; set; }
        public string MaHP { get; set; }
        public string MaKL { get; set; }

        public DTO_NhomHP() { }

        public DTO_NhomHP(string maNhp, string tenNhp, string maHp, string maKl)
        {
            MaNHP = maNhp;
            TenNHP = tenNhp;
            MaHP = maHp;
            MaKL = maKl;
        }
    }
}
