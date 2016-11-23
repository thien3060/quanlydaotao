using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_HocKy
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_HocKy hocky)
        {
            parameters.Clear();
            parameters.Add("@MaHK", hocky.MaHK);
            parameters.Add("@TenHK", hocky.TenHK);
            parameters.Add("@MaNH", hocky.MaNH);
        }

        public void ThemHocKy(DTO_HocKy hocky)
        {
            AddParameter(hocky);
            Connection.ExecuteSqlWithParameter("INSERT INTO hocky VALUES (@MaHK, @TenHK, @MaNH)", parameters);
        }
        public void CapNhatHocKy(DTO_HocKy hocky)
        {
            AddParameter(hocky);
            Connection.ExecuteSqlWithParameter("UPDATE hocky SET TenHK=@TenHK, MaNH=@MaNH WHERE MaHK=@MaHK", parameters);
        }
        public void XoaHocKy(DTO_HocKy hocky)
        {
            AddParameter(hocky);
            Connection.ExecuteSql("DELETE FROM hocky WHERE MaHK='" + hocky.MaHK + "'");
        }
        public DataTable TaobangHocKy(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM hocky " + dieukien);
        }
        public string LayMaHocKyLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM hocky ORDER BY MaHK ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM hocky");
            return dt.Rows.Count;
        }
    }
}
