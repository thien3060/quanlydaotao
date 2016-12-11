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
        public string Khoa { get; set; }

        public DTO_Nganh() { }

        public DTO_Nganh(string maNganh, string tenNganh, string khoa)
        {
            MaNganh = maNganh;
            TenNganh = tenNganh;
            Khoa = khoa;
        }
    }
}
