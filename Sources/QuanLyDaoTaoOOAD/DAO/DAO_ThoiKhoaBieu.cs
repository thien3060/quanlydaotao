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
            parameters.Add("@MaGD", thoikhoabieu.MaGD);
            parameters.Add("@MaBH", thoikhoabieu.MaBH);
            parameters.Add("@MaPhong", thoikhoabieu.MaPhong);
            parameters.Add("@CoDay", thoikhoabieu.CoDay);
        }

        public void ThemThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSqlWithParameter("INSERT INTO thoikhoabieu VALUES (@MaGD, @MaBH, @MaPhong, @CoDay)", parameters);
        }
        public void CapNhatThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSqlWithParameter("UPDATE thoikhoabieu SET CoDay=@CoDay WHERE MaGD=@MaGD AND MaBH=@MaBH AND MaPhong=@MaPhong", parameters);
        }
        public void XoaThoiKhoaBieu(DTO_ThoiKhoaBieu thoikhoabieu)
        {
            AddParameter(thoikhoabieu);
            Connection.ExecuteSql("DELETE FROM thoikhoabieu WHERE MaGD='" + thoikhoabieu.MaGD + "' AND MaBH='" + thoikhoabieu.MaBH + "' AND MaPhong='" + thoikhoabieu.MaPhong + "'");
        }
        public DataTable TaobangThoiKhoaBieu(string dieukien)
        {
            return Connection.GetDataTable("SELECT * FROM thoikhoabieu " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = Connection.GetDataTable("SELECT * FROM thoikhoabieu");
            return dt.Rows.Count;
        }
    }
}
