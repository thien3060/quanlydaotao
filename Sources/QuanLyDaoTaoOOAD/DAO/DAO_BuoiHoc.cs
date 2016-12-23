using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTO;
using System;

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
            Connection.ExecuteSqlWithParameter("INSERT INTO buoihoc VALUES (@MaBH, @Ngay, @TietBatDau, @SoTiet)", parameters);
        }
        public void CapNhatBuoiHoc(DTO_BuoiHoc buoiHoc)
        {
            AddParameter(buoiHoc);
            Connection.ExecuteSqlWithParameter("UPDATE buoihoc SET Ngay=@Ngay, TietBatDau=@TietBatDau, SoTiet=@SoTiet WHERE BuoiHoc=@MaBH", parameters);
        }
        public void XoaBuoiHoc(DTO_BuoiHoc buoiHoc)
        {
            AddParameter(buoiHoc);
            Connection.ExecuteSqlWithParameter("DELETE FROM buoihoc WHERE BuoiHoc=@MaBH", parameters);
        }
        public DataRow LayBuoiHoc(string mabuoihoc)
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM buoihoc WHERE BuoiHoc='" + mabuoihoc + "'");
            if (temp.Rows.Count != 0)
            {
                return temp.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataTable TaobangBuoiHoc(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM buoihoc " + dieukien);
        }
        public string LayMaBuoiHocLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM buoihoc ORDER BY BuoiHoc ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public DataTable DanhSachBuoiHocTheoTuan(DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_BuoiHocTheoTuan", parameters);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM buoihoc");
            return dt.Rows.Count;
        }
    }
}
