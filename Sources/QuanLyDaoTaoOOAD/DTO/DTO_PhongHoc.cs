using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_PhongHoc
    {
        public string MaPhong { get; set; }
        public string ChucNang { get; set; }
        public string SucChua { get; set; }
        public string DiaChi { get; set; }

        public DTO_PhongHoc(string maPhong, string chucNang, string sucChua, string diaChi)
        {
            MaPhong = maPhong;
            ChucNang = chucNang;
            SucChua = sucChua;
            DiaChi = diaChi;
        }
    }
}
