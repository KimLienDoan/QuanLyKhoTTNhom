using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
namespace DAL_QuanLy
{
   public class DAL_CTHoaDonBan :DataProvider
    {
        DTO_HangHoa dtohh = new DTO_HangHoa();
        public DataTable GetCTHoaDonBan()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select *from HoaDonBanHang");
            return dt;
        }
        public void AddCTHoaDonBan(DTO_ChiTietHDBan ct)
        {
         DataProvider.Instance.ExecuteNonQuery("insert into ChiTietHoaDonBanHang(GiaBanHang,maHangHoa,maHoaDon,soLuong,thanhTien) " +
             "values ("+ct.GiaBanRa1+","+ct.MahangHoa1+","+ct.MaHoaDon1+","+ct.SoLuong1+",("+ct.SoLuong1+"*"+ct.GiaBanRa1+"))" );


        }
        public void UpdateCTHoaDonBan(DTO_ChiTietHDBan ct)
        {
            string query = "update ChiTietHoaDonBanHang set maHangHoa = " + ct.MahangHoa1 + ", soLuong = " + ct.SoLuong1+ ",GiaBanHang=" + ct.GiaBanRa1 + ", thanhTien =( " + ct.SoLuong1 + "*" + ct.GiaBanRa1+") where maHoaDon = "+ct.MaHoaDon1+"";
             DataProvider.Instance.ExecuteQuery(query);
           
        }
        public void DeleteCTHoaDonBan(int maHH, int maHD)
        {

            DataProvider.Instance.ExecuteQuery("delete ChiTietHoaDonBanHang where maHangHoa = "+maHH+" and maHoaDon = "+maHD+"");
  
        }
        public DataTable LayTTHang(string dieukien)
        {
            DataTable dth = DataProvider.Instance.ExecuteQuery("select maHangHoa, tenHangHoa , GiaHang from HangHoa " + dieukien );
            return dth;

        }
        public DataTable LayCTHang()
        {
            return DataProvider.Instance.ExecuteQuery("select MaHangHoa, GiaBanHang  from ChiTietHoaDonBanHang");
        }


    }
}
