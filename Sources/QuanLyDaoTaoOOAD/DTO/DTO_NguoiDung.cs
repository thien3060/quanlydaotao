using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguoiDung
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenNguoiDung { get; set; }
        public string Quyen { get; set; }
        public string MoTaQuyen { get; set; }

        public DTO_NguoiDung() { }

        public DTO_NguoiDung(string tenDangNhap, string matKhau, string tenNguoiDung, string quyen, string moTaQuyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            TenNguoiDung = tenNguoiDung;
            Quyen = quyen;
            MoTaQuyen = moTaQuyen;
        }
    }
}
