using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TDDT
    {
        public string MaTrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public string HeSoLuong { get; set; }

        public DTO_TDDT() { }

        public DTO_TDDT(string maTrinhDo, string tenTrinhDo, string heSoLuong)
        {
            MaTrinhDo = maTrinhDo;
            TenTrinhDo = tenTrinhDo;
            HeSoLuong = heSoLuong;
        }
    }
}
