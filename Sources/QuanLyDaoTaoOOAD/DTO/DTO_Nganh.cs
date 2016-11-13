using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nganh
    {
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        public string MaKhoa { get; set; }

        public DTO_Nganh(string maNganh, string tenNganh, string maKhoa)
        {
            MaNganh = maNganh;
            TenNganh = tenNganh;
            MaKhoa = maKhoa;
        }
    }
}
