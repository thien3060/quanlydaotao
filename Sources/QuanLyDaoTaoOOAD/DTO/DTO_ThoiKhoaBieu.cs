using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThoiKhoaBieu
    {
        public string MaPC { get; set; }
        public string BuoiHoc { get; set; }
        public string MaPhong { get; set; }
        public bool CoDay { get; set; }
        public bool DaThanhToan { get; set; }

        public DTO_ThoiKhoaBieu() { }

        public DTO_ThoiKhoaBieu(string maPC, string buoiHoc, string maPhong, bool coDay, bool daThanhToan)
        {
            MaPC = maPC;
            BuoiHoc = buoiHoc;
            MaPhong = maPhong;
            CoDay = coDay;
            DaThanhToan = daThanhToan;
        }
    }
}
