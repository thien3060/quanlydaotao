using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    class DAO_NhomLop
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_NhomLop nhomlop)
        {
            parameters.Clear();
            parameters.Add("@MaNL", nhomlop.MaNL);
            parameters.Add("@TenNL", nhomlop.TenNL);
            parameters.Add("@MaKL", nhomlop.MaKL);
        }

        public void ThemNhomLop(DTO_NhomLop nhomlop)
        {
            AddParameter(nhomlop);
            Connection.ExecuteSqlWithParameter("INSERT INTO nhomlop VALUES (@MaNL, @TenNL)", parameters);
        }
        public void CapNhatNhomLop(DTO_NhomLop nhomlop)
        {
            AddParameter(nhomlop);
            Connection.ExecuteSqlWithParameter("UPDATE nhomlop SET TenNL=@TenNL WHERE MaNhomLop=@MaNhomLop", parameters);
        }
        public void XoaNhomLop(DTO_NhomLop nhomlop)
        {
            AddParameter(nhomlop);
            Connection.ExecuteSql("DELETE FROM nhomlop WHERE MaNL='" + nhomlop.MaNL + "'");
        }
        public DataTable TaobangNhomLop(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM nhomlop " + dieukien);
        }
        public string LayMaNhomLopLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM nhomlop ORDER BY MaNL ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM nhomlop");
            return dt.Rows.Count;
        }
    }
}
