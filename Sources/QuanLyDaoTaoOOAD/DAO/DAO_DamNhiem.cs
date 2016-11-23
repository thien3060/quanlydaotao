using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_DamNhiem
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_DamNhiem damnhiem)
        {
            parameters.Clear();
            parameters.Add("@MaGV", damnhiem.MaGV);
            parameters.Add("@MaCV", damnhiem.MaCV);
            parameters.Add("@NgayNC", damnhiem.NgayNC);
        }

        public void ThemDamNhiem(DTO_DamNhiem damnhiem)
        {
            AddParameter(damnhiem);
            Connection.ExecuteSqlWithParameter("INSERT INTO damnhiem VALUES (@MaGV, @MaCV, @NgayNC)", parameters);
        }
        public void CapNhatDamNhiem(DTO_DamNhiem damnhiem)
        {
            AddParameter(damnhiem);
            Connection.ExecuteSqlWithParameter("UPDATE damnhiem SET NgayNC=@NgayNC WHERE MaGV=@MaGV AND MaCV=@MaCV", parameters);
        }
        public void XoaDamNhiem(DTO_DamNhiem damnhiem)
        {
            AddParameter(damnhiem);
            Connection.ExecuteSql("DELETE FROM damnhiem WHERE MaGV='" + damnhiem.MaGV + "' AND MaCV='" + damnhiem.MaCV + "'");
        }
        public DataTable TaobangDamNhiem(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM damnhiem " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM damnhiem");
            return dt.Rows.Count;
        }
    }
}
