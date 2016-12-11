using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_MonHoc
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_MonHoc monhoc)
        {
            parameters.Clear();
            parameters.Add("@MaMH", monhoc.MaMH);
            parameters.Add("@TenMH", monhoc.TenMH);
            parameters.Add("@STC", monhoc.STC);
            parameters.Add("@LyThuyet", monhoc.LyThuyet);
            parameters.Add("@ThucHanh", monhoc.ThucHanh);
        }

        public void ThemMonHoc(DTO_MonHoc monhoc)
        {
            AddParameter(monhoc);
            Connection.ExecuteSqlWithParameter("INSERT INTO MonHoc VALUES (@MaMH, @TenMH, @STC, @LyThuyet, @ThucHanh)", parameters);
        }
        public void CapNhatMonHoc(DTO_MonHoc monhoc)
        {
            AddParameter(monhoc);
            Connection.ExecuteSqlWithParameter("UPDATE MonHoc SET TenMH=@TenMH,STC=@STC,LyThuyet=@LyThuyet,ThucHanh=@ThucHanh WHERE MaMH=@MaMH", parameters);
        }
        public void XoaMonHoc(DTO_MonHoc monhoc)
        {
            AddParameter(monhoc);
            Connection.ExecuteSql("DELETE FROM MonHoc WHERE MaMH='" + monhoc.MaMH + "'");
        }
        public DataTable TaobangMonHoc(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM MonHoc " + dieukien);
        }
        public string LayMaMonHocLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM MonHoc ORDER BY MaMH ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM MonHoc");
            return dt.Rows.Count;
        }
    }
}
