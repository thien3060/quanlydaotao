using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_GiaoVien
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_GiaoVien giaovien)
        {
            parameters.Clear();
            parameters.Add("@MaGV", giaovien.MaGV);
            parameters.Add("@HoTenGV", giaovien.HoTenGV);
            parameters.Add("@NgaySinh", giaovien.NgaySinh);
            parameters.Add("@DiaChi", giaovien.DiaChi);
            parameters.Add("@GioiTinh", giaovien.GioiTinh);
            parameters.Add("@CMND", giaovien.CMND);
            parameters.Add("@MaKhoa", giaovien.MaKhoa);
            parameters.Add("@MaHV", giaovien.MaHV);
        }

        public void ThemGiaoVien(DTO_GiaoVien giaovien)
        {
            AddParameter(giaovien);
            Connection.ExecuteSqlWithParameter("INSERT INTO giaovien VALUES (@MaGV, @HoTenGV, @NgaySinh, @DiaChi, @GioiTinh, @CMND, @MaKhoa, @MaHV)", parameters);
        }
        public void CapNhatGiaoVien(DTO_GiaoVien giaovien)
        {
            AddParameter(giaovien);
            Connection.ExecuteSqlWithParameter("UPDATE giaovien SET HoTenGV=@HoTenGV,NgaySinh=@NgaySinh,DiaChi=@DiaChi,GioiTinh=@GioiTinh,CMND=@CMND,MaKhoa=@MaKhoa,MaHV=@MaHV WHERE MaGV=@MaGV", parameters);
        }
        public void XoaGiaoVien(DTO_GiaoVien giaovien)
        {
            AddParameter(giaovien);
            Connection.ExecuteSql("DELETE FROM giaovien WHERE MaGV='"+giaovien.MaGV+"'");
        }
        public DataTable TaobangGiaoVien(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM giaovien " + dieukien);
        }
        public string LayMaGiaoVienLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM giaovien ORDER BY MaGV ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM giaovien");
            return dt.Rows.Count;
        }
    }
}
