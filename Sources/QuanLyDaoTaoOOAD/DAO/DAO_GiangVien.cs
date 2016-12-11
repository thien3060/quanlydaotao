using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_GiangVien
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_GiangVien giangvien)
        {
            parameters.Clear();
            parameters.Add("@MaGV", giangvien.MaGV);
            parameters.Add("@HoTen", giangvien.HoTen);
            parameters.Add("@DiaChi", giangvien.DiaChi);
            parameters.Add("@GioiTinh", giangvien.GioiTinh);
            parameters.Add("@MaTrinhDo", giangvien.MaTrinhDo);
        }

        public void ThemGiangVien(DTO_GiangVien giangvien)
        {
            AddParameter(giangvien);
            Connection.ExecuteSqlWithParameter("INSERT INTO GiangVien VALUES (@MaGV, @HoTen, @GioiTinh, @DiaChi, @MaTrinhDo)", parameters);
        }
        public void CapNhatGiangVien(DTO_GiangVien giangvien)
        {
            AddParameter(giangvien);
            Connection.ExecuteSqlWithParameter("UPDATE GiangVien SET HoTen=@HoTen,DiaChi=@DiaChi,GioiTinh=@GioiTinh,MaTrinhDo=@MaTrinhDo WHERE MaGV=@MaGV", parameters);
        }
        public void XoaGiangVien(DTO_GiangVien giangvien)
        {
            AddParameter(giangvien);
            Connection.ExecuteSql("DELETE FROM GiangVien WHERE MaGV='" + giangvien.MaGV+"'");
        }
        public DataTable TaobangGiangVien(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM GiangVien " + dieukien);
        }
        public string LayMaGiangVienLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM GiangVien ORDER BY MaGV ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM GiangVien");
            return dt.Rows.Count;
        }
    }
}
