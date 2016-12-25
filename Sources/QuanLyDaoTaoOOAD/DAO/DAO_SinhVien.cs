using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_SinhVien
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_SinhVien sinhvien)
        {
            parameters.Clear();
            parameters.Add("@MSSV", sinhvien.MSSV);
            parameters.Add("@HoTen", sinhvien.HoTen);
            parameters.Add("@NgaySinh", sinhvien.NgaySinh);
            parameters.Add("@DiaChi", sinhvien.DiaChi);
            parameters.Add("@MaLop", sinhvien.MaLop);
        }

        public void ThemSinhVien(DTO_SinhVien sinhvien)
        {
            AddParameter(sinhvien);
            Connection.ExecuteSqlWithParameter("INSERT INTO SinhVien VALUES (@MSSV, @HoTen, @NgaySinh, @DiaChi, @MaLop)", parameters);
        }
        public void CapNhatSinhVien(DTO_SinhVien sinhvien)
        {
            AddParameter(sinhvien);
            Connection.ExecuteSqlWithParameter("UPDATE SinhVien SET HoTen=@HoTen,NgaySinh=@NgaySinh,DiaChi=@DiaChi,MaLop=@MaLop WHERE MSSV=@MSSV", parameters);
        }
        public void XoaSinhVien(DTO_SinhVien sinhvien)
        {
            AddParameter(sinhvien);
            Connection.ExecuteSql("DELETE FROM SinhVien WHERE MSSV='" + sinhvien.MSSV + "'");
        }
        public DataRow GetSinhVienByID(string id)
        {
            DataRow temp = Connection.GetDataTable("SELECT * FROM SinhVien WHERE MSSV = '" + id + "'").Rows[0];
            return temp;
        }
        public DataTable GetDanhSanhLop(string malop)
        {
            return Connection.GetDataTable("SELECT ROW_NUMBER() over (order by (select 1)) as STT, SinhVien.MSSV, SinhVien.HoTen, SinhVien.NgaySinh, SinhVien.DiaChi, Lop.MaLop FROM SinhVien, Lop " +
                                            "WHERE Lop.MaLop = '" + malop + "' and SinhVien.MaLop = '" + malop + "'");
        }
        public DataTable TaobangSinhVien(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM SinhVien " + dieukien);
        }
        public string LayMaSinhVienLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM SinhVien ORDER BY MSSV ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM SinhVien");
            return dt.Rows.Count;
        }
    }
}
