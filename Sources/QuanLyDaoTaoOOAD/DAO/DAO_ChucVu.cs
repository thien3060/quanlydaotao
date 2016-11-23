using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ChucVu
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_ChucVu chucvu)
        {
            parameters.Clear();
            parameters.Add("@MaCV", chucvu.MaCV);
            parameters.Add("@TenCV", chucvu.TenCV);
        }

        public void ThemChucVu(DTO_ChucVu chucvu)
        {
            AddParameter(chucvu);
            Connection.ExecuteSqlWithParameter("INSERT INTO chucvu VALUES (@MaCV, @TenCV)", parameters);
        }
        public void CapNhatChucVu(DTO_ChucVu chucvu)
        {
            AddParameter(chucvu);
            Connection.ExecuteSqlWithParameter("UPDATE chucvu SET TenCV=@TenCV WHERE MaCV=@MaCV", parameters);
        }
        public void XoaChucVu(DTO_ChucVu chucvu)
        {
            AddParameter(chucvu);
            Connection.ExecuteSql("DELETE FROM chucvu WHERE MaCV='" + chucvu.MaCV + "'");
        }
        public DataTable TaobangChucVu(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM chucvu " + dieukien);
        }
        public string LayMaChucVuLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM chucvu ORDER BY MaCV ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM chucvu");
            return dt.Rows.Count;
        }
    }
}
