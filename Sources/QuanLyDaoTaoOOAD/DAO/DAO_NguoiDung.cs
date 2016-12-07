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
            parameters.Add("@MaND", nguoiDung.MaND);
            parameters.Add("@TenDN", nguoiDung.TenDN);
            parameters.Add("@MatKhau", nguoiDung.MatKhau);
            parameters.Add("@TenND", nguoiDung.TenND);
            parameters.Add("@Quyen", nguoiDung.Quyen);
            parameters.Add("@MoTaQuyen", nguoiDung.MoTaQuyen);
        }

        public void ThemNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("INSERT INTO nguoidung VALUES (@MaND, @TenDN, @MatKhau, @TenND, @Quyen, @MoTaQuyen)", parameters);
        }
        public void CapNhatNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("UPDATE nguoidung SET TenDN=@TenDN,MatKhau=@MatKhau,TenND=@TenND,Quyen=@Quyen,MoTaQuyen=@MoTaQuyen WHERE MaND=@MaND", parameters);
        }
        public void XoaNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSql("DELETE FROM nguoidung WHERE MaND='" + nguoiDung.MaND + "'");
        }
        public DataTable TaobangNguoiDung(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM nguoidung " + dieukien);
        }
        public string LayMaNguoiDungLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM nguoidung ORDER BY MaND ASC");
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
            return Connection.GetDataTable("SELECT TenDN, MatKhau, Quyen from nguoidung where TenDN = '" + nguoiDung.TenDN + "' and MatKhau = '" + nguoiDung.MatKhau + "'");
        }

        public bool KiemTraTonTai(string TenDangNhap)
        {
            DataTable temp = Connection.GetDataTable("SELECT TenDN from nguoidung where TenDN = '" + TenDangNhap + "'");
            if (temp.Rows.Count != 0)
                return true;
            else
                return false;
        }
    }
}
