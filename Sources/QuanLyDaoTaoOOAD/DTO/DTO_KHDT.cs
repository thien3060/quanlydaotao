using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHDT
    {
        public string MaKHDT { get; set; }
        public string TenKHDT { get; set; }
        public string MaTD { get; set; }
        public string MaHDT { get; set; }
        public string MaNganh { get; set; }

        public DTO_KHDT() { }

        public DTO_KHDT(string maKhdt, string tenKhdt, string maTd, string maHdt, string maNganh)
        {
            MaKHDT = maKhdt;
            TenKHDT = tenKhdt;
            MaTD = maTd;
            MaHDT = maHdt;
            MaNganh = maNganh;
        }
    }
}
