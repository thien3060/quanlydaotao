using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ThoiKhoaBieu
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            parameters.Clear();
            parameters.Add("@MaPC", thoikhoabieu.MaPC);
            parameters.Add("@BuoiHoc", thoikhoabieu.BuoiHoc);
            parameters.Add("@MaPhong", thoikhoabieu.MaPhong);
            parameters.Add("@CoDay", thoikhoabieu.CoDay);
            parameters.Add("@DaThanhToan", thoikhoabieu.DaThanhToan);
        }

        public void ThemThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSqlWithParameter("INSERT INTO ThoiKhoaBieu VALUES (@MaPC, @BuoiHoc, @MaPhong, @CoDay, @DaThanhToan)", parameters);
        }
        public void CapNhatThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSqlWithParameter("UPDATE ThoiKhoaBieu SET CoDay=@CoDay, MaPhong=@MaPhong, DaThanhToan=@DaThanhToan WHERE MaGD=@MaGD AND BuoiHoc=@BuoiHoc", parameters);
        }
        public void XoaThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSql("DELETE FROM ThoiKhoaBieu WHERE MaPC='" + thoikhoabieu.MaPC + "' AND BuoiHoc='" + thoikhoabieu.BuoiHoc + "'");
        }
        public DataTable TaobangThoiKhoaBieu(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM ThoiKhoaBieu " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM ThoiKhoaBieu");
            return dt.Rows.Count;
        }
        public DataRow LayThoiKhoaBieu(string mapc, int buoihoc)
        {
            DataTable temp = Connection.GetDataTable("SELECT * FROM ThoiKhoaBieu WHERE MaPC='" + mapc + "' AND BuoiHoc='" + buoihoc + "'");
            if (temp.Rows.Count != 0)
            {
                return temp.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataTable XemTKBSinhVien(string mssv, DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@mssv", mssv);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_XemTKBSinhVien", parameters);
        }
        public DataTable XemTKBGiangVien(string magv, DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@maGV", magv);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_XemTKBGiangVien", parameters);
        }
        public DataTable ThongTinTKB(string maPhong, DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@maPhong", maPhong);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_ThongTinTKB", parameters);
        }
        public DataTable DeNghiTheoPhongTrongTuan(string maPhong, DateTime ngayDauTuan)
        {
            parameters.Clear();
            parameters.Add("@maPhong", maPhong);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_DeNghiTheoPhongTrongTuan", parameters);
        }
        public DataTable PhieuGiangDay(string maLop, DateTime ngayDauTuan)
        {
            string mssv = "";
            DataTable temp = Connection.GetDataTable("SELECT * FROM SinhVien WHERE MaLop = '" + maLop + "'");
            
            if (temp.Rows.Count != 0)
            {
                mssv = temp.Rows[0][0].ToString();
            }
            parameters.Clear();
            parameters.Add("@mssv", mssv);
            parameters.Add("@ngayDauTuan", ngayDauTuan);
            return Connection.ExecuteStoreProcedure("sp_XemTKBSinhVien", parameters);
        }
        public void LuuPhieuGiangDay(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSqlWithParameter("UPDATE ThoiKhoaBieu SET CoDay=@CoDay WHERE MaPC=@MaPC AND BuoiHoc=@BuoiHoc", parameters);
        }
    }
}
