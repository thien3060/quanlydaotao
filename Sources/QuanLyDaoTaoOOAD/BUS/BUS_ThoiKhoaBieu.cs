﻿using System;
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
        public DataTable XemTKBSinhVien(string mssv, DateTime ngayDauTuan)
        {
            return thoikhoabieu.XemTKBSinhVien(mssv, ngayDauTuan);
        }
    }
}
