using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_KhoiLop
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_KhoiLop khoilop)
        {
            parameters.Clear();
            parameters.Add("@MaKL", khoilop.MaKL);
            parameters.Add("@TenKL", khoilop.TenKL);
            parameters.Add("@MaKhoa", khoilop.MaKhoa);
            parameters.Add("@MaHDT", khoilop.MaHDT);            
            parameters.Add("@MaTDDT", khoilop.MaTDDT);
        }

        public void ThemKhoiLop(DTO_KhoiLop khoilop)
        {
            AddParameter(khoilop);
            Connection.ExecuteSqlWithParameter("INSERT INTO khoilop VALUES (@MaKL,@TenKL,@MaKhoa,@MaHDT,@MaTDDT)", parameters);
        }
        public void CapNhatKhoiLop(DTO_KhoiLop khoilop)
        {
            AddParameter(khoilop);
            Connection.ExecuteSqlWithParameter("UPDATE khoilop SET TenKL=@TenKL,MaKhoa=@MaKhoa,MaHDT=@MaHDT,MaTDDT=@MaTDDT WHERE MaKL=@MaKL", parameters);
        }
        public void XoaKhoiLop(DTO_KhoiLop khoilop)
        {
            AddParameter(khoilop);
            Connection.ExecuteSql("DELETE FROM khoilop WHERE MaKL='" + khoilop.MaKL + "'");
        }
        public DataTable TaobangKhoiLop(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM khoilop " + dieukien);
        }
        public string LayMaKhoaLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM khoilop ORDER BY MaKL ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM khoilop");
            return dt.Rows.Count;
        }
    }
}
