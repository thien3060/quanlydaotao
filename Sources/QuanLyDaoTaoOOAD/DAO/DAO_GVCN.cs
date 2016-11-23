using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_GVCN
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_GVCN gvcn)
        {
            parameters.Clear();
            parameters.Add("@MaGV", gvcn.MaGV);
            parameters.Add("@MaNL", gvcn.MaNL);
            parameters.Add("@MaNH", gvcn.MaNH);
            parameters.Add("@GhiChu", gvcn.GhiChu);
        }

        public void ThemGVCN(DTO_GVCN gvcn)
        {
            AddParameter(gvcn);
            Connection.ExecuteSqlWithParameter("INSERT INTO gvcn VALUES (@MaGV, @MaNL, @MaNH, @GhiChu)", parameters);
        }
        public void CapNhatGVCN(DTO_GVCN gvcn)
        {
            AddParameter(gvcn);
            Connection.ExecuteSqlWithParameter("UPDATE gvcn SET GhiChu=@GhiChu WHERE MaGV=@MaGV AND MaNL=@MaNL AND MaNH=@MaNH", parameters);
        }
        public void XoaGVCN(DTO_GVCN gvcn)
        {
            AddParameter(gvcn);
            Connection.ExecuteSql("DELETE FROM gvcn WHERE MaGV='" + gvcn.MaGV + "' MaNL='" + gvcn.MaNL + "' MaNH ='" + gvcn.MaNH + "'");
        }
        public DataTable TaobangGVCN(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM gvcn " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM gvcn");
            return dt.Rows.Count;
        }
    }
}
