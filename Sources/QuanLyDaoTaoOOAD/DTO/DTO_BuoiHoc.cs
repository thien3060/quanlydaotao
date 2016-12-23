using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BuoiHoc
    {
        public string MaBH { get; set; }
        public DateTime Ngay { get; set; }
        public int TietBatDau { get; set; }
        public int SoTiet { get; set; }

        public DTO_BuoiHoc() { }

        public DTO_BuoiHoc(string maBh, DateTime ngay, int tietBatDau, int soTiet)
        {
            MaBH = maBh;
            Ngay = ngay;
            TietBatDau = tietBatDau;
            SoTiet = soTiet;
        }
    }
}
