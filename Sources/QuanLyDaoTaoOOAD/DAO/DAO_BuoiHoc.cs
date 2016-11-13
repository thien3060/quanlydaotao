using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTO;

namespace DAO
{
    public class DAO_BuoiHoc
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_BuoiHoc buoiHoc)
        {
            parameters.Clear();
            parameters.Add("@MaBH", buoiHoc.MaBH);
            parameters.Add("@Ngay", buoiHoc.Ngay);
            parameters.Add("@TietBatDau", buoiHoc.TietBatDau);
            parameters.Add("@SoTiet", buoiHoc.SoTiet);
        }

        public void ThemBuoiHoc(DTO_BuoiHoc buoiHoc)
        {
            AddParameter(buoiHoc);
            Connection.ExecuteSqlWithParameter("INSERT INTO buoihoc VALUES (N@MaBH, N@Ngay, N@TietBatDau, N@SoTiet)", parameters);
        }
        public void CapNhatBuoiHoc(DTO_BuoiHoc buoiHoc)
        {
            AddParameter(buoiHoc);
            Connection.ExecuteSqlWithParameter("UPDATE buoihoc SET Ngay=N@Ngay, TietBatDau=N@TietBatDau, SoTiet=N@SoTiet WHERE MaBH=N@MaBH", parameters);
        }
        public void XoaBuoiHoc(DTO_BuoiHoc buoiHoc)
        {
            AddParameter(buoiHoc);
            Connection.ExecuteSqlWithParameter("DELETE FROM buoihoc WHERE MaBH=N@MaBH", parameters);
        }
        public DataTable TaobangBuoiHoc(string dieukien)
        {
            return Connection.GetDataTable("SECLECT * FROM buoihoc " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM buoihoc");
            return dt.Rows.Count;
        }
    }
}
