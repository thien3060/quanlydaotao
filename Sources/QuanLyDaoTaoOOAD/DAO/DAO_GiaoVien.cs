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
            Connection.ExecuteSqlWithParameter("INSERT INTO giaovien VALUES (N@MaGV, N@HoTenGV, N@NgaySinh, N@DiaChi, N@GioiTinh, N@CMND, N@MaKhoa, N@MaHV)", parameters);
        }
        public void CapNhatGiaoVien(DTO_GiaoVien giaovien)
        {
            AddParameter(giaovien);
            Connection.ExecuteSqlWithParameter("UPDATE giaovien SET HoTenGV=N@HoTenGV,NgaySinh=N@NgaySinh,DiaChi=N@DiaChi,GioiTinh=N@GioiTinh,CMND=N@CMND,MaKhoa=N@MaKhoa,MaHV=N@MaHV WHERE MaGV=N@MaGV", parameters);
        }
        public void XoaGiaoVien(DTO_GiaoVien giaovien)
        {
            AddParameter(giaovien);
            Connection.ExecuteSqlWithParameter("DELETE FROM giaovien WHERE MaGV=N@MaGV", parameters);
        }
        public DataTable TaobangGiaoVien(string dieukien)
        {
            return Connection.GetDataTable("SECLECT * FROM giaovien " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM giaovien");
            return dt.Rows.Count;
        }
    }
}
