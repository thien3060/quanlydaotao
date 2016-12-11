using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string STC { get; set; }
        public string LyThuyet { get; set; }
        public string ThucHanh { get; set; }

        public DTO_MonHoc() { }

        public DTO_MonHoc(string _MaMH, string _TenMH, string _STC, string _LyThuyet, string _ThucHanh)
        {
            MaMH = _MaMH;
            TenMH = _TenMH;
            STC = _STC;
            LyThuyet = _LyThuyet;
            ThucHanh = _ThucHanh;
        }
    }
}
