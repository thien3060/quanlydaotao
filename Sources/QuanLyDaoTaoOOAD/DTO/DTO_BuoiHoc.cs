using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_BuoiHoc
    {
        public string MaBH { get; set; }
        public DateTime Ngay { get; set; }
        public string TietBatDau { get; set; }
        public string SoTiet { get; set; }

        public DTO_BuoiHoc() { }

        public DTO_BuoiHoc(string maBh, DateTime ngay, string tietBatDau, string soTiet)
        {
            MaBH = maBh;
            Ngay = ngay;
            TietBatDau = tietBatDau;
            SoTiet = soTiet;
        }
    }
}
