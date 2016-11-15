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
            Connection.ExecuteSqlWithParameter("INSERT INTO nguoidung VALUES (N@MaND, N@TenDN, N@MatKhau, N@TenND, N@Quyen, N@MoTaQuyen)", parameters);
        }
        public void CapNhatNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("UPDATE nguoidung SET TenDN=N@TenDN,MatKhau=N@MatKhau,TenND=N@TenND,Quyen=N@Quyen,MoTaQuyen=N@MoTaQuyen WHERE MaND=N@MaND", parameters);
        }
        public void XoaNguoiDung(DTO_NguoiDung nguoiDung)
        {
            AddParameter(nguoiDung);
            Connection.ExecuteSqlWithParameter("DELETE FROM nguoidung WHERE MaND=N@MaND", parameters);
        }
        public DataTable TaobangNguoiDung(string dieukien)
        {
            return Connection.GetDataTable("SECLECT * FROM nguoidung " + dieukien);
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
    }
}
