using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_SinhVien
    {
        private DAO_SinhVien sv = new DAO_SinhVien();
        public DataTable TaobangSinhVien(string dieukien)
        {
            return sv.TaobangSinhVien(dieukien);
        }
        public void ThemdulieuSinhVien(DTO_SinhVien et)
        {
            sv.ThemSinhVien(et);
        }
        public void SuadulieuSinhVien(DTO_SinhVien et)
        {
            sv.CapNhatSinhVien(et);
        }
        public void XoadulieuSinhVienn(DTO_SinhVien et)
        {
            sv.XoaSinhVien(et);
        }

        public string TuTinhMa(string dinhDang)
        {
            string s = sv.LayMaSinhVienLonNhat();
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    string newId = dinhDang + (int.Parse(s.Substring(5)) + 1).ToString("0000");
                    return newId;
                }
                return dinhDang + "0001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
