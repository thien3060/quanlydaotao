using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_GiangDay
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_GiangDay giangday)
        {
            parameters.Clear();
            parameters.Add("@MaGD", giangday.MaGD);
            parameters.Add("@MaGV", giangday.MaGV);
            parameters.Add("@MaNHP", giangday.MaNHP);
            parameters.Add("@MaHK", giangday.MaHK);
            parameters.Add("@GhiChuGD", giangday.GhiChuGD);
        }

        public void ThemGiangDay(DTO_GiangDay giangday)
        {
            AddParameter(giangday);
            Connection.ExecuteSqlWithParameter("INSERT INTO giangday VALUES (@MaGD, @MaGV, @MaNHP, @MaHK, @GhiChuGD)", parameters);
        }
        public void CapNhatGiangDay(DTO_GiangDay giangday)
        {
            AddParameter(giangday);
            Connection.ExecuteSqlWithParameter("UPDATE giangday SET MaGV=@MaGV,MaNHP=@MaNHP,MaHK=@MaHK,GhiChuGD=@GhiChuGD WHERE MaGD=@MaGD", parameters);
        }
        public void XoaGiangDay(DTO_GiangDay giangday)
        {
            AddParameter(giangday);
            Connection.ExecuteSql("DELETE FROM giangday WHERE MaGD='" + giangday.MaGD + "'");
        }
        public DataTable TaobangGiangDay(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM giangday " + dieukien);
        }
        public string LayMaGiangDayLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM giangday ORDER BY MaGD ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM giangday");
            return dt.Rows.Count;
        }
    }
}
