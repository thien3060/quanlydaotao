using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTO;

namespace DAO
{
    public class DAO_DeNghi
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_DeNghi denghi)
        {
            parameters.Clear();
            parameters.Add("@MaPC", denghi.MaPC);
            parameters.Add("@BuoiHoc", denghi.BuoiHoc);
        }

        public void ThemDeNghi(DTO_DeNghi denghi)
        {
            AddParameter(denghi);
            Connection.ExecuteSqlWithParameter("INSERT INTO denghi VALUES (@MaPC, @BuoiHoc)", parameters);
        }
        public void CapNhatDeNghi(DTO_DeNghi denghi)
        {
            //AddParameter(denghi);
            //Connection.ExecuteSqlWithParameter("UPDATE denghi SET MaBH=@MaBH,BuoiHoc=@BuoiHoc WHERE MaBH=@MaBH AND BuoiHoc=@BuoiHoc", parameters);
        }
        public void XoaDeNghi(DTO_DeNghi denghi)
        {
            AddParameter(denghi);
            Connection.ExecuteSqlWithParameter("DELETE FROM denghi WHERE MaPC=@MaPC AND BuoiHoc=@BuoiHoc", parameters);
        }
        public DataTable TaobangDeNghi(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM denghi " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM denghi");
            return dt.Rows.Count;
        }
    }
}
