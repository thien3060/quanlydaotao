using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiangVien
    {
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MaTrinhDo { get; set; }

        public DTO_GiangVien() { }

        public DTO_GiangVien(string maGv, string hoTen, string diaChi, bool gioiTinh, string maTrinhDo)
        {
            MaGV = maGv;
            HoTen = hoTen;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            MaTrinhDo = maTrinhDo;
        }
    }
}
