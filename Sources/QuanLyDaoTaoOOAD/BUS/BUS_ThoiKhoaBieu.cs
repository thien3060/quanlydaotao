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
    public class BUS_ThoiKhoaBieu
    {
        private DAO_ThoiKhoaBieu thoikhoabieu = new DAO_ThoiKhoaBieu();
        public DataTable TaobangThoiKhoaBieu(string dieukien)
        {
            return thoikhoabieu.TaobangThoiKhoaBieu(dieukien);
        }
        public void ThemdulieuThoiKhoaBieu(DTO_ThoiKhoaBieu et)
        {
            thoikhoabieu.ThemThoiKhoaBieu(et);
        }
        public void SuadulieuThoiKhoaBieu(DTO_ThoiKhoaBieu et)
        {
            thoikhoabieu.CapNhatThoiKhoaBieu(et);
        }
        public void XoadulieuThoiKhoaBieu(DTO_ThoiKhoaBieu et)
        {
            thoikhoabieu.XoaThoiKhoaBieu(et);
        }
        public void XoadulieuThoiKhoaBieu(string maPC, int maBuoi)
        { 
            thoikhoabieu.XoaThoiKhoaBieu(new DTO_ThoiKhoaBieu(maPC, maBuoi.ToString(), "", false, false));
        }
        public DataRow LayThoiKhoaBieu(string mapc, int buoihoc)
        {
            return thoikhoabieu.LayThoiKhoaBieu(mapc, buoihoc);
        }
        public DataTable XemTKBSinhVien(string mssv, DateTime ngayDauTuan)
        {
            return thoikhoabieu.XemTKBSinhVien(mssv, ngayDauTuan);
        }
        public DataTable XemTKBGiangVien(string magv, DateTime ngayDauTuan)
        {
            return thoikhoabieu.XemTKBGiangVien(magv, ngayDauTuan);
        }
        public DataTable ThongTinTKB(string maPhong, DateTime ngayDauTuan)
        {
            return thoikhoabieu.ThongTinTKB(maPhong, ngayDauTuan);
        }
        public DataTable DeNghiTheoPhongTrongTuan(string maPhong, DateTime ngayDauTuan)
        {
            return thoikhoabieu.DeNghiTheoPhongTrongTuan(maPhong, ngayDauTuan);
        }
        public DataTable PhieuGiangDay(string maLop, DateTime ngayDauTuan)
        {
            return thoikhoabieu.PhieuGiangDay(maLop, ngayDauTuan);
        }
        public void LuuPhieuGiangDay(DTO_ThoiKhoaBieu tkb)
        {
            thoikhoabieu.LuuPhieuGiangDay(tkb);
        }
    }
}
