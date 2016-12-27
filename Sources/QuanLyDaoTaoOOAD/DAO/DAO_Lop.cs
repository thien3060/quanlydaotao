using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Lop
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_Lop lop)
        {
            parameters.Clear();
            parameters.Add("@MaLop", lop.MaLop);
            parameters.Add("@MaNganh", lop.MaNganh);
        }

        public void ThemLop(DTO_Lop lop)
        {
            AddParameter(lop);
            Connection.ExecuteSqlWithParameter("INSERT INTO Lop VALUES (@MaLop, @MaNganh)", parameters);
        }
        public void CapNhatLop(DTO_Lop lop)
        {
            AddParameter(lop);
            Connection.ExecuteSqlWithParameter("UPDATE Lop SET MaNganh=@MaNganh WHERE MaLop=@MaLop", parameters);
        }
        public void XoaLop(DTO_Lop lop)
        {
            AddParameter(lop);
            Connection.ExecuteSql("DELETE FROM Lop WHERE MaLop='" + lop.MaLop + "'");
        }
        public DataTable TaobangLop(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM Lop " + dieukien);
        }
        public DataTable GetByMaNganh(DTO_Lop lop)
        {
            return Connection.GetDataTable("SELECT * FROM Lop WHERE MaNganh = '" + lop.MaNganh + "'");
        }
        public DataTable DanhSachTuyChinh()
        {
            return Connection.GetDataTable("SELECT * FROM Lop INNER JOIN NganhHoc ON Lop.MaNganh = NganhHoc.MaNganh");
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM Lop");
            return dt.Rows.Count;
        }
    }
}
