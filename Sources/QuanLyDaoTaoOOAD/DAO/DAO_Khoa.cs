using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Khoa
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_Khoa khoa)
        {
            parameters.Clear();
            parameters.Add("@MaKhoa", khoa.MaKhoa);
            parameters.Add("@TenKhoa", khoa.TenKhoa);
        }

        public void ThemKhoa(DTO_Khoa khoa)
        {
            AddParameter(khoa);
            Connection.ExecuteSqlWithParameter("INSERT INTO khoa VALUES (@MaKhoa, @TenKhoa)", parameters);
        }
        public void CapNhatKhoa(DTO_Khoa khoa)
        {
            AddParameter(khoa);
            Connection.ExecuteSqlWithParameter("UPDATE khoa SET TenKhoa=@TenKhoa WHERE MaKhoa=@MaKhoa", parameters);
        }
        public void XoaKhoa(DTO_Khoa khoa)
        {
            AddParameter(khoa);
            Connection.ExecuteSql("DELETE FROM khoa WHERE MaKhoa='" + khoa.MaKhoa + "'");
        }
        public DataTable TaobangKhoa(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM khoa " + dieukien);
        }
        public string LayMaKhoaLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM khoa ORDER BY MaKhoa ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM khoa");
            return dt.Rows.Count;
        }
    }
}
