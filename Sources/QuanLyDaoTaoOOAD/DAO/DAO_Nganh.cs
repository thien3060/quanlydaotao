using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Nganh
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_Nganh nganh)
        {
            parameters.Clear();
            parameters.Add("@MaNganh", nganh.MaNganh);
            parameters.Add("@TenNganh", nganh.TenNganh);
            parameters.Add("@MaKhoa", nganh.MaKhoa);
        }

        public void ThemNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSqlWithParameter("INSERT INTO nganh VALUES (@MaNganh, @TenNganh, @MaKhoa)", parameters);
        }
        public void CapNhatNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSqlWithParameter("UPDATE nganh SET TenNganh=@TenNganh, MaKhoa=@MaKhoa WHERE MaNganh=@MaNganh", parameters);
        }
        public void XoaNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSql("DELETE FROM nganh WHERE MaNganh='" + nganh.MaNganh + "'");
        }
        public DataTable TaobangNganh(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM nganh " + dieukien);
        }
        public string LayMaNganhLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM nganh ORDER BY MaNganh ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM nganh");
            return dt.Rows.Count;
        }
    }
}
