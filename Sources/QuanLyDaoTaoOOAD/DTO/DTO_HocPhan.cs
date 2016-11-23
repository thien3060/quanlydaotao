using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocPhan
    {
        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public string SoTietLT { get; set; }
        public string SoTietTH { get; set; }
        public string SoTC { get; set; }
        public string MaKHDT { get; set; }

        public DTO_HocPhan() { }

        public DTO_HocPhan(string maHp, string tenHp, string soTietLt, string soTietTh, string soTc, string maKhdt)
        {
            MaHP = maHp;
            TenHP = tenHp;
            SoTietLT = soTietLt;
            SoTietTH = soTietTh;
            SoTC = soTc;
            MaKHDT = maKhdt;
        }
    }
}
