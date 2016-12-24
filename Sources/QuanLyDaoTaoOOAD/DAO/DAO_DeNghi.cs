using System;
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
        //public string[] LayMaDeNghiLonNhat()
        //{
        //    DataTable temp = Connection.GetDataTable("SELECT * FROM denghi ORDER BY MaPC ASC, BuoiHoc");
        //    string[] kq = new string[2];
        //    if (temp.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        kq[0] = temp.Rows[temp.Rows.Count - 1][0].ToString();
        //        kq[1] = temp.Rows[temp.Rows.Count - 1][1].ToString();
        //    }
        //    return kq;
        //}
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM denghi");
            return dt.Rows.Count;
        }
        public DataRow LayDeNghi(string mapc, int buoihoc)
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM denghi WHERE MaPC='" + mapc + "' AND BuoiHoc='" + buoihoc + "'");
            if (temp.Rows.Count != 0)
            {
                return temp.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataTable ThongTinDeNghi(int mabuoihoc, string mapc)
        {
            parameters.Clear();
            parameters.Add("@maBuoiHoc", mabuoihoc);
            parameters.Add("@maPC", mapc);
            return Connection.ExecuteStoreProcedure("sp_ThongTinDeNghi", parameters);
        }
        public DataTable ThongTinPhanCongTheoGV(string maGV, int hocky, int namhoc)
        {
            parameters.Clear();
            parameters.Add("@maGV", maGV);
            parameters.Add("@hocKy", hocky);
            parameters.Add("@namHoc", namhoc);
            return Connection.ExecuteStoreProcedure("sp_ThongTinPhanCongTheoGV", parameters);
        }
        public DataTable DanhSachDeNghiTheoTuan(string magv, DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@maGV", magv);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_DeNghiTheoTuan", parameters);
        }
    }
}
