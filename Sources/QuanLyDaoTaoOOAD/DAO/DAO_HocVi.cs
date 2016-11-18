using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_HocVi
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_HocVi hocvi)
        {
            parameters.Clear();
            parameters.Add("@MaHV", hocvi.MaHV);
            parameters.Add("@TenHV", hocvi.TenHV);
            parameters.Add("@MoTa", hocvi.MoTa);
        }

        public void ThemHocVi(DTO_HocVi hocvi)
        {
            AddParameter(hocvi);
            Connection.ExecuteSqlWithParameter("INSERT INTO hocvi VALUES (@MaHV, @TenHV, @MoTa)", parameters);
        }
        public void CapNhatHocVi(DTO_HocVi hocvi)
        {
            AddParameter(hocvi);
            Connection.ExecuteSqlWithParameter("UPDATE hocvi SET TenHV=@TenHV, MoTa=@MoTa WHERE MaHV=@MaHV", parameters);
        }
        public void XoaHocVi(DTO_HocVi hocvi)
        {
            AddParameter(hocvi);
            Connection.ExecuteSql("DELETE FROM hocvi WHERE MaHV='" + hocvi.MaHV + "'");
        }
        public DataTable TaobangHocVi(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM hocvi " + dieukien);
        }
        public string LayMaHocViLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM hocvi ORDER BY MaHocVi ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM hocvi");
            return dt.Rows.Count;
        }
    }
}
