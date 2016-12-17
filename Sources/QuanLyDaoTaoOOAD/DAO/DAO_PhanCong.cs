using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PhanCong
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_PhanCong phancong)
        {
            parameters.Clear();
            parameters.Add("@MaPC", phancong.MaPC);
            parameters.Add("@MaGV", phancong.MaGV);
            parameters.Add("@MaMH", phancong.MaMH);
            parameters.Add("@MaLop", phancong.MaLop);
            parameters.Add("@HocKy", phancong.HocKy);
            parameters.Add("@NamHoc", phancong.NamHoc);
        }

        public void ThemPhanCong(DTO_PhanCong phancong)
        {
            AddParameter(phancong);
            Connection.ExecuteSqlWithParameter("INSERT INTO phancong VALUES (@MaPC, @MaGV, @MaMH, @MaLop, @HocKy, @NamHoc)", parameters);
        }
        public void CapNhatPhanCong(DTO_PhanCong phancong)
        {
            AddParameter(phancong);
            Connection.ExecuteSqlWithParameter("UPDATE phancong SET MaGV=@MaGV,MaMH=@MaMH,MaLop=@MaLop,HocKy=@HocKy,NamHoc=@NamHoc WHERE MaPC=@MaPC", parameters);
        }
        public void XoaPhanCong(DTO_PhanCong phancong)
        {
            AddParameter(phancong);
            Connection.ExecuteSql("DELETE FROM phancong WHERE MaPC='" + phancong.MaPC + "'");
        }
        public DataTable TaobangPhanCong(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM phancong " + dieukien);
        }
        public DataTable GetPhanCong(DTO_PhanCong phancong)
        {
            return Connection.GetDataTable("SELECT * FROM phancong WHERE MaGV = '" + phancong.MaGV + "' AND HocKy = '" + phancong.HocKy + "' AND NamHoc = '" + phancong.NamHoc + "'");
        }

        public string LayMaPhanCongLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM phancong ORDER BY MaPC ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM phancong");
            return dt.Rows.Count;
        }
    }
}
