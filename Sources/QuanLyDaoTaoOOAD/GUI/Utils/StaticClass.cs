using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace QuanLyDaoTao.Utils
{
    public static class StaticClass
    {
        /// <summary>
        /// Người dùng đang đăng nhập hệ thống
        /// </summary>
        public static DTO_NguoiDung User;

        /// <summary>
        /// Cho biết đang đăng nhập hay đã đăng xuất.
        /// </summary>
        public static bool DangNhap = false;
    }
}
