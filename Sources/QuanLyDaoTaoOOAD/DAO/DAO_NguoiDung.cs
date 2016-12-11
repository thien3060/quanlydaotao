using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_NguoiDung
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_NguoiDung nguoiDung)
        {
            parameters.Clear();
            parameters.Add("@TenDangNhap", nguoiDung.TenDangNhap);
            parameters.Add("@MatKhau", nguoiDung.MatKhau);
            parameters.Add("@TenNguoiDung", nguoiDung.TenNguoiDung);
            parameters.Add("@Quyen", nguoiDung.Quyen);
            parameters.Add("@MoTaQuyen", nguoiDung.MoTaQuyen);
        }

        public void ThemNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("INSERT INTO nguoidung VALUES (@TenDangNhap, @MatKhau, @TenNguoiDung, @Quyen, @MoTaQuyen)", parameters);
        }
        public void CapNhatNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("UPDATE nguoidung SET MatKhau=@MatKhau,TenND=@TenND,Quyen=@Quyen,MoTaQuyen=@MoTaQuyen WHERE TenDangNhap=@TenDangNhap", parameters);
        }
        public void ThietLapLaiMatKhau(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("UPDATE nguoidung SET MatKhau=@MatKhau WHERE TenDangNhap=@TenDangNhap", parameters);
        }
        public void XoaNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSql("DELETE FROM nguoidung WHERE TenDangNhap='" + nguoiDung.TenDangNhap + "'");
        }
        public DataTable TaobangNguoiDung(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM nguoidung " + dieukien);
        }
        public string LayMaNguoiDungLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM nguoidung ORDER BY TenDangNhap ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM nguoidung");
            return dt.Rows.Count;
        }

        public DataTable LayThongTinUser(DTO_NguoiDung nguoiDung)
        {
            return Connection.GetDataTable("SELECT TenDangNhap, MatKhau, Quyen from nguoidung where TenDangNhap = '" + nguoiDung.TenDangNhap + "'");
        }

        public bool KiemTraTonTai(string TenDangNhap)
        {
            DataTable temp = Connection.GetDataTable("SELECT TenDangNhap from nguoidung where TenDangNhap = '" + TenDangNhap + "'");
            if (temp.Rows.Count != 0)
                return true;
            else
                return false;
        }

        public DTO_NguoiDung LayThongTinDangNhap(string tenDN)
        {
            DataTable temp = Connection.GetDataTable("SELECT TenDangNhap, TenNguoiDung, MatKhau, Quyen, MotaQuyen from nguoidung where TenDangNhap = '" + tenDN + "'");
            DTO_NguoiDung nguoiDung = new DTO_NguoiDung();
            nguoiDung.TenDangNhap = tenDN;
            nguoiDung.MatKhau = temp.Rows[0]["MatKhau"].ToString();
            nguoiDung.Quyen = temp.Rows[0]["Quyen"].ToString();
            nguoiDung.MoTaQuyen = temp.Rows[0]["MoTaQuyen"].ToString();
            nguoiDung.TenNguoiDung = temp.Rows[0]["TenNguoiDung"].ToString();

            return nguoiDung;
        }
    }
}
