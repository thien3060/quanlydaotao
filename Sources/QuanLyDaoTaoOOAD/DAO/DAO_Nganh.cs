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
            parameters.Add("@Khoa", nganh.Khoa);
        }

        public void ThemNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSqlWithParameter("INSERT INTO NganhHoc VALUES (@MaNganh, @TenNganh, @Khoa)", parameters);
        }
        public void CapNhatNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSqlWithParameter("UPDATE NganhHoc SET TenNganh=@TenNganh, Khoa=@Khoa WHERE MaNganh=@MaNganh", parameters);
        }
        public void XoaNganh(DTO_Nganh nganh)
        {
            AddParameter(nganh);
            Connection.ExecuteSql("DELETE FROM NganhHoc WHERE MaNganh='" + nganh.MaNganh + "'");
        }
        public DataTable TaobangNganh(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM NganhHoc " + dieukien);
        }
        public DataTable GetByMaKhoa(DTO_Nganh nganh)
        {
            return Connection.GetDataTable("SELECT * FROM NganhHoc WHERE Khoa = '" + nganh.Khoa + "'");
        }
        public string LayMaNganhLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM NganhHoc ORDER BY MaNganh ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM NganhHoc");
            return dt.Rows.Count;
        }
    }
}
