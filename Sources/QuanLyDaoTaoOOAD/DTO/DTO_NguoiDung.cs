using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguoiDung
    {
        public string MaND { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public string TenND { get; set; }
        public string Quyen { get; set; }
        public string MoTaQuyen { get; set; }

        public DTO_NguoiDung(string maNd, string tenDn, string matKhau, string tenNd, string quyen, string moTaQuyen)
        {
            MaND = maNd;
            TenDN = tenDn;
            MatKhau = matKhau;
            TenND = tenNd;
            Quyen = quyen;
            MoTaQuyen = moTaQuyen;
        }
    }
}
