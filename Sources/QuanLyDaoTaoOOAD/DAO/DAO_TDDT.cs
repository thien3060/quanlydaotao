using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_TDDT
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_TDDT tddt)
        {
            parameters.Clear();
            parameters.Add("@MaTD", tddt.MaTD);
            parameters.Add("@TenTD", tddt.TenTD);
        }

        public void ThemTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSqlWithParameter("INSERT INTO tddt VALUES (@MaTD, @TenTD)", parameters);
        }
        public void CapNhatTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSqlWithParameter("UPDATE tddt SET TenTD=@TenTD WHERE MaTD=@MaTD", parameters);
        }
        public void XoaTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSql("DELETE FROM tddt WHERE MaTD='" + tddt.MaTD + "'");
        }
        public DataTable TaobangTDDT(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM tddt " + dieukien);
        }
        public string LayMaTDDTLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM tddt ORDER BY MaTD ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM tddt");
            return dt.Rows.Count;
        }
    }
}
