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
            parameters.Add("@MaTrinhDo", tddt.MaTrinhDo);
            parameters.Add("@TenTrinhDo", tddt.TenTrinhDo);
            parameters.Add("@HeSoLuong", tddt.HeSoLuong);
        }

        public void ThemTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSqlWithParameter("INSERT INTO TrinhDo VALUES (@MaTrinhDo, @TenTrinhDo, @HeSoLuong)", parameters);
        }
        public void CapNhatTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSqlWithParameter("UPDATE TrinhDo SET TenTrinhDo=@TenTrinhDo,HeSoLuong=@HeSoLuong WHERE MaTrinhDo=@MaTrinhDo", parameters);
        }
        public void XoaTDDT(DTO_TDDT tddt)
        {
            AddParameter(tddt);
            Connection.ExecuteSql("DELETE FROM TrinhDo WHERE MaTrinhDo='" + tddt.MaTrinhDo + "'");
        }
        public DataTable TaobangTDDT(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM TrinhDo " + dieukien);
        }
        public string LayMaTDDTLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM TrinhDo ORDER BY MaTrinhDo ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM TrinhDo");
            return dt.Rows.Count;
        }
    }
}
