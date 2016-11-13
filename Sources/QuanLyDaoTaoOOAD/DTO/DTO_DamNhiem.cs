using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DamNhiem
    {
        public string MaGV { get; set; }
        public string MaCV { get; set; }
        public DateTime NgayNC { get; set; }

        public DTO_DamNhiem(string maGv, string maCv, DateTime ngayNc)
        {
            MaGV = maGv;
            MaCV = maCv;
            NgayNC = ngayNc;
        }
    }
}
