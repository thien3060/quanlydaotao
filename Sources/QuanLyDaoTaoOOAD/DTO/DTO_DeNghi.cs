using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DeNghi
    {
        public string MaPC { get; set; }
        public int BuoiHoc { get; set; }

        public DTO_DeNghi() { }

        public DTO_DeNghi(string mapc, int buoihoc)
        {
            MaPC = mapc;
            BuoiHoc = buoihoc;
        }
    }
}
