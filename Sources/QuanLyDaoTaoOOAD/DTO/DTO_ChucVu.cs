using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }

        public DTO_ChucVu(string maCv, string tenCv)
        {
            MaCV = maCv;
            TenCV = tenCv;
        }
    }
}
