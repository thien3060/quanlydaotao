using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_HeDT
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_HeDT hedt)
        {
            parameters.Clear();
            parameters.Add("@MaHDT", hedt.MaHDT);
            parameters.Add("@TenHDT", hedt.TenHDT);
        }

        public void ThemHeDT(DTO_HeDT hedt)
        {
            AddParameter(hedt);
            Connection.ExecuteSqlWithParameter("INSERT INTO hedt VALUES (@MaHDT, @TenHDT)", parameters);
        }
        public void CapNhatHeDT(DTO_HeDT hedt)
        {
            AddParameter(hedt);
            Connection.ExecuteSqlWithParameter("UPDATE hedt SET TenHDT=@TenHDT WHERE MaHDT=@MaHDT", parameters);
        }
        public void XoaHeDT(DTO_HeDT hedt)
        {
            AddParameter(hedt);
            Connection.ExecuteSql("DELETE FROM hedt WHERE MaHDT='" + hedt.MaHDT + "'");
        }
        public DataTable TaobangHeDT(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM hedt " + dieukien);
        }
        public string LayMaHeDTLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM hedt ORDER BY MaHDT ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM hedt");
            return dt.Rows.Count;
        }
    }
}
