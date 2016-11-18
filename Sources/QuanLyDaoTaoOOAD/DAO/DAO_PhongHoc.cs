using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PhongHoc
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_PhongHoc phongHoc)
        {
            parameters.Clear();
            parameters.Add("@MaPhong", phongHoc.MaPhong);
            parameters.Add("@ChucNang", phongHoc.ChucNang);
            parameters.Add("@SucChua", phongHoc.SucChua);
            parameters.Add("@DiaChi", phongHoc.DiaChi);
        }

        public void ThemPhongHoc(DTO_PhongHoc khoa)
        {
            AddParameter(khoa);
            Connection.ExecuteSqlWithParameter("INSERT INTO phonghoc VALUES (@MaPhong, @ChucNang, @SucChua, @DiaChi)", parameters);
        }
        public void CapNhatPhongHoc(DTO_PhongHoc phongHoc)
        {
            AddParameter(phongHoc);
            Connection.ExecuteSqlWithParameter("UPDATE phonghoc SET ChucNang=@ChucNang, SucChua=@SucChua, DiaChi=@DiaChi WHERE MaPhong=@MaPhong", parameters);
        }
        public void XoaPhongHoc(DTO_PhongHoc phongHoc)
        {
            AddParameter(phongHoc);
            Connection.ExecuteSql("DELETE FROM phonghoc WHERE MaPhong='" + phongHoc.MaPhong + "'");
        }
        public DataTable TaobangPhongHoc(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM phonghoc " + dieukien);
        }
        public string LayMaPhongHocLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM phonghoc ORDER BY MaPhong ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM phonghoc");
            return dt.Rows.Count;
        }
    }
}
