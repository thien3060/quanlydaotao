using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_KHDT
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_KHDT khdt)
        {
            parameters.Clear();
            parameters.Add("@MaKHDT", khdt.MaKHDT);
            parameters.Add("@TenKHDT", khdt.TenKHDT);
            parameters.Add("@MaTD", khdt.MaTD);
            parameters.Add("@MaHDT", khdt.MaHDT);
            parameters.Add("@MaNganh", khdt.MaNganh);
        }

        public void ThemKHDT(DTO_KHDT khdt)
        {
            AddParameter(khdt);
            Connection.ExecuteSqlWithParameter("INSERT INTO khdt VALUES (@MaKHDT, @TenKHDT, @MaTD, @MaHDT, @MaNganh)", parameters);
        }
        public void CapNhatKHDT(DTO_KHDT khdt)
        {
            AddParameter(khdt);
            Connection.ExecuteSqlWithParameter("UPDATE khdt SET TenKHDT=@TenKHDT,MaTD=@MaTD,MaHDT=@MaHDT,MaNganh=@MaNganh WHERE MaKHDT=@MaKHDT", parameters);
        }
        public void XoaKHDT(DTO_KHDT khdt)
        {
            AddParameter(khdt);
            Connection.ExecuteSql("DELETE FROM khdt WHERE MaKHDT='" + khdt.MaKHDT + "'");
        }
        public DataTable TaobangKHDT(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM khdt " + dieukien);
        }
        public string LayMaKHDTLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM khdt ORDER BY MaKHDT ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM khdt");
            return dt.Rows.Count;
        }
    }
}
