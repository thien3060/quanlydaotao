using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string MaLop { get; set; }

        public DTO_SinhVien() { }

        public DTO_SinhVien(string mssv, string hoTen, DateTime ngaySinh, string diaChi, string maLop)
        {
            MSSV = mssv;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            MaLop = maLop;
        }
    }
}
