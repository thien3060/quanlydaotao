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
        public string CoDay { get; set; }
        public string DaThanhToan { get; set; }

        public DTO_ThoiKhoaBieu() { }

        public DTO_ThoiKhoaBieu(string maPC, string buoiHoc, string maPhong, string coDay, string daThanhToan)
        {
            MaPC = maPC;
            BuoiHoc = buoiHoc;
            MaPhong = maPhong;
            CoDay = coDay;
            DaThanhToan = daThanhToan;
        }
    }
}
