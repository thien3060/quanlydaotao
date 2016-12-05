using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_HocPhan
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_HocPhan hocphan)
        {
            parameters.Clear();
            parameters.Add("@MaHP", hocphan.MaHP);
            parameters.Add("@TenHP", hocphan.TenHP);
            parameters.Add("@SoTietLT", hocphan.SoTietLT);
            parameters.Add("@SoTietTH", hocphan.SoTietTH);
            parameters.Add("@SoTC", hocphan.SoTC);
            parameters.Add("@MaKHDT", hocphan.MaKHDT);
        }

        public void ThemHocPhan(DTO_HocPhan hocphan)
        {
            AddParameter(hocphan);
            Connection.ExecuteSqlWithParameter("INSERT INTO hocphan VALUES (@MaHP, @TenHP, @SoTietLT, @SoTietTH, @SoTC, @MaKHDT)", parameters);
        }
        public void CapNhatHocPhan(DTO_HocPhan hocphan)
        {
            AddParameter(hocphan);
            Connection.ExecuteSqlWithParameter("UPDATE hocphan SET TenHP=@TenHP,SoTietLT=@SoTietLT,SoTietTH=@SoTietTH,SoTC=@SoTC,MaKHDT=@MaKHDT WHERE MaHP=@MaHP", parameters);
        }
        public void XoaHocPhan(DTO_HocPhan hocphan)
        {
            AddParameter(hocphan);
            Connection.ExecuteSql("DELETE FROM hocphan WHERE MaHP='" + hocphan.MaHP + "'");
        }
        public DataTable TaobangHocPhan(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM hocphan " + dieukien);
        }
        public DataTable GetHocPhanByMaKHDT(String MaKHDT)
        {
            return Connection.GetDataTable("SELECT * FROM hocphan WHERE MaKHDT = '" + MaKHDT + "'");
        }
        public string LayMaHocPhanLonNhat()
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM hocphan ORDER BY MaHP ASC");
            if (temp.Rows.Count == 0)
            {
                return null;
            }
            return temp.Rows[temp.Rows.Count - 1][0].ToString();
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM hocphan");
            return dt.Rows.Count;
        }
    }
}
