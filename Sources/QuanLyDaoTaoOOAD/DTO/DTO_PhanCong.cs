using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhanCong
    {
        public string MaPC { get; set; }
        public string MaGV { get; set; }
        public string MaMH { get; set; }
        public string MaLop { get; set; }
        public int HocKy { get; set; }
        public int NamHoc { get; set; }

        public DTO_PhanCong() { }

        public DTO_PhanCong(string mapc, string magv, string mamh, string malop, int hocky, int namhoc)
        {
            MaPC = mapc;
            MaGV = magv;
            MaMH = mamh;
            MaLop = malop;
            HocKy = hocky;
            NamHoc = namhoc;
        }
    }
}
