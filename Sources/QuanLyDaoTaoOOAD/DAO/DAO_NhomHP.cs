using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_NhomHP
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_NhomHP nhomhp)
        {
            parameters.Clear();
            parameters.Add("@MaNHP", nhomhp.MaNHP);
            parameters.Add("@TenNHP", nhomhp.TenNHP);
            parameters.Add("@MaHP", nhomhp.MaHP);
            parameters.Add("@MaKL", nhomhp.MaKL);
        }

        public void ThemNhomHP(DTO_NhomHP nhomhp)
        {
            AddParameter(nhomhp);
            Connection.ExecuteSqlWithParameter("INSERT INTO nhomhp VALUES (@MaNHP, @TenNHP, @MaHP, @MaKL)", parameters);
        }
        public void CapNhatNhomHP(DTO_NhomHP nhomhp)
        {
            AddParameter(nhomhp);
            Connection.ExecuteSqlWithParameter("UPDATE nhomhp SET TenNHP=@TenNHP, MaHP=@MaHP, MaKL=@MaKL WHERE MaNHP=@MaNHP", parameters);
        }
        public void XoaNhomHP(DTO_NhomHP nhomhp)
        {
            AddParameter(nhomhp);
            Connection.ExecuteSql("DELETE FROM nhomhp WHERE MaNHP='" + nhomhp.MaNHP + "'");
        }
        public DataTable TaobangNhomHP(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM nhomhp " + dieukien);
        }
        public string LayMaNhomHPLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM nhomhp ORDER BY MaNHP ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM nhomhp");
            return dt.Rows.Count;
        }
    }
}
