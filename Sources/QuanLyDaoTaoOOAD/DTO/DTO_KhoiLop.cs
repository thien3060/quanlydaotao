using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhoiLop
    {
        public string MaKL { get; set; }
        public string TenKL { get; set; }
        public string MaHDT { get; set; }
        public string MaKhoa { get; set; }
        public string MaTDDT { get; set; }

        public DTO_KhoiLop(string maKl, string tenKl, string maHdt, string maKhoa, string maTddt)
        {
            MaKL = maKl;
            TenKL = tenKl;
            MaHDT = maHdt;
            MaKhoa = maKhoa;
            MaTDDT = maTddt;
        }
    }
}
