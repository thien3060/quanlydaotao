using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ThoiKhoaBieu
    {
        public string MaGD { get; set; }
        public string MaBH { get; set; }
        public string MaPhong { get; set; }
        public string CoDay { get; set; }

        public DTO_ThoiKhoaBieu(string maGd, string maBh, string maPhong, string coDay)
        {
            MaGD = maGd;
            MaBH = maBh;
            MaPhong = maPhong;
            CoDay = coDay;
        }
    }
}
