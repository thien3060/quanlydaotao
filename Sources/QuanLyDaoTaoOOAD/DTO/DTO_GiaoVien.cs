using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        public string MaGV { get; set; }
        public string HoTenGV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string MaKhoa { get; set; }
        public string MaHV { get; set; }

        public DTO_GiaoVien() { }

        public DTO_GiaoVien(string maGv, string hoTenGv, DateTime ngaySinh, string diaChi, string gioiTinh, string cmnd, string maKhoa, string maHv)
        {
            MaGV = maGv;
            HoTenGV = hoTenGv;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            CMND = cmnd;
            MaKhoa = maKhoa;
            MaHV = maHv;
        }
    }
}
