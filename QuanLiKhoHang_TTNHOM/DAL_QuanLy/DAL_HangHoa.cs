using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_HangHoa : DataProvider
    {
        public DataTable GetHangHoa()
        {
            string query = " select *from HangHoa";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable AddHangHoa(DTO_HangHoa hh)
        {
            string query = "insert into HangHoa values ("+hh.MaHangHoa+",'"+hh.TenHagHoa1+"','"+hh.NgaySX1+"',"+hh.SoLuong1+","+hh.GiaHang1+",'"+hh.GiaBanRa1+"''"+hh.DVT1+"',"+hh.MaKhoHang1+",'"+hh.Mota+"')";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;

        }
        public DataTable UpdateHangHoa(DTO_HangHoa hh)
        {
            string query = "update  HangHoa " +
                "set tenHangHoa=N'"+hh.TenHagHoa1+"' , ngaySanXuat='"+hh.NgaySX1+"',soLuong="+hh.SoLuong1+" ,giaHang= "+hh.GiaHang1+ " ,DVT='" + hh.DVT1+"',maLoaiHang="+hh.MaKhoHang1+",moTa='"+hh.Mota+"'" +
                "where maHangHoa="+hh.MaHangHoa+"";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable DeleteHangHoa(int ID)
        {
            string query = "delete HangHoa where maHangHoa =" + ID ;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable LayTTHang(string dieukien)
        {
            DataTable dth = DataProvider.Instance.ExecuteQuery("select maHangHoa, tenHangHoa , GiaHang from HangHoa " + dieukien);
            return dth;

        }
    }
}
