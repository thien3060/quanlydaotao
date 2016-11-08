using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_GiangDay
    {
        public string MaGD { get; set; }
        public string MaGV { get; set; }
        public string MaNHP { get; set; }
        public string MaHK { get; set; }
        public string GhiChuGD { get; set; }

        public DTO_GiangDay(string maGd, string maGv, string maNhp, string maHk, string ghiChuGd)
        {
            MaGD = maGd;
            MaGV = maGv;
            MaNHP = maNhp;
            MaHK = maHk;
            GhiChuGD = ghiChuGd;
        }
    }
}
