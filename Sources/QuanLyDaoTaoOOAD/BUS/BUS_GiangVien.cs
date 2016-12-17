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
    public class BUS_GiangVien
    {
        private DAO_GiangVien gv = new DAO_GiangVien();
        public DataTable TaobangGiangVien(string dieukien)
        {
            return gv.TaobangGiangVien(dieukien);
        }
        public void ThemdulieuGiangVien(DTO_GiangVien et)
        {
            gv.ThemGiangVien(et);
        }
        public void SuadulieuGiangVien(DTO_GiangVien et)
        {
            gv.CapNhatGiangVien(et);
        }
        public void XoadulieuGiangVien(DTO_GiangVien et)
        {
            gv.XoaGiangVien(et);
        }
        public DTO_GiangVien GetGiangVienbyID(string id)
        {
            DataRow row = gv.GetGiangVienByID(id);
            DTO_GiangVien giangvien = new DTO_GiangVien();
            if (row != null)
            {
                giangvien.MaGV = row[0].ToString();
                giangvien.HoTen = row[1].ToString();
                giangvien.GioiTinh = (bool) row[2];
                giangvien.DiaChi = row[3].ToString();
                giangvien.MaTrinhDo = row[4].ToString();

                return giangvien;
            }
            else
            {
                return null;
            }
        }

        public string TuTinhMa()
        {
            string s = gv.LayMaGiangVienLonNhat();
            string maMoi;
            if (s == null)
            {
                maMoi = "GV0001";
                return maMoi;
            }
            int last = Int32.Parse(s.Substring(2).ToString()) + 1;
            maMoi = "GV" + last.ToString("0000");
            return maMoi;
        }
    }
}
