using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_NamHoc
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_NamHoc namhoc)
        {
            parameters.Clear();
            parameters.Add("@MaNH", namhoc.MaNH);
            parameters.Add("@TenNH", namhoc.TenNH);
        }

        public void ThemNamHoc(DTO_NamHoc namhoc)
        {
            AddParameter(namhoc);
            Connection.ExecuteSqlWithParameter("INSERT INTO namhoc VALUES (@MaNH, @TenNH)", parameters);
        }
        public void CapNhatNamHoc(DTO_NamHoc namhoc)
        {
            AddParameter(namhoc);
            Connection.ExecuteSqlWithParameter("UPDATE namhoc SET TenNH=@TenNH WHERE MaNH=@MaNH", parameters);
        }
        public void XoaNamHoc(DTO_NamHoc namhoc)
        {
            AddParameter(namhoc);
            Connection.ExecuteSql("DELETE FROM namhoc WHERE MaNH='" + namhoc.MaNH + "'");
        }
        public DataTable TaobangNamHoc(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM namhoc " + dieukien);
        }
        public string LayMaNamHocLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM namhoc ORDER BY MaNH ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM namhoc");
            return dt.Rows.Count;
        }
    }
}
