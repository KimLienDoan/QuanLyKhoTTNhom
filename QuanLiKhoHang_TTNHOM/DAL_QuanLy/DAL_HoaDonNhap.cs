using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;


namespace DAL_QuanLy
{
   public class DAL_HoaDonNhap : DataProvider
    {
        public DataTable GetHoaDonNhap()
        {
            string query = "select hh.maHangHoa, hd.maHoaDonNhap,hd.ngayThang,hh.tenHangHoa,ct.soLuong, ct.thanhTien,hd.maNV, hd.tongTien " +
"from HoaDonNhap hd , ChiTietHoaDonNhap ct, HangHoa hh " +
" where hd.maHoaDonNhap = ct.maHoaDonNhap and hh.maHangHoa = ct.maHangHoa";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable AddHoaDonNhap()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("");
            return dt;
        }
        public DataTable UpdateHoaDonNhap()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("");
            return dt;
        }
     
    }
}
