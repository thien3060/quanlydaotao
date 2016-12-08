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
    public class BUS_Login
    {
        DAO_NguoiDung daoNguoiDung = new DAO_NguoiDung();

        public Boolean KiemTraThongTinDangNhap(DTO_NguoiDung dto_nguoidung)
        {
            DataTable dt = daoNguoiDung.LayThongTinUser(dto_nguoidung);
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }

        public DataTable LayDanhSachTheoID(DTO_NguoiDung dto_nguoidung)
        {
            return daoNguoiDung.LayThongTinUser(dto_nguoidung);
        }

        public DTO_NguoiDung LayThongTiNguoiDung(string tenDN)
        {
            return daoNguoiDung.LayThongTinDangNhap(tenDN);
        }
    }
}
