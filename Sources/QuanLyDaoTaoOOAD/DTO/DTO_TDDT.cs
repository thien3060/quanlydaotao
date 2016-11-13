using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TDDT
    {
        public string MaTD { get; set; }
        public string TenTD { get; set; }

        public DTO_TDDT(string maTd, string tenTd)
        {
            MaTD = maTd;
            TenTD = tenTd;
        }
    }
}
