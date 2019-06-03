using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;


namespace DAL_QuanLy
{
   public class DAL_HoaDonBan :DataProvider
    {
       
        public DataTable GetHoaDonBan()
        {
            DataTable dth = DataProvider.Instance.ExecuteQuery("select *from HoaDonBanHang");
            return dth;
        }
        public void AddHoaDonBan(DTO_HoaDonBan bh)
        {
         DataProvider.Instance.ExecuteNonQuery(" insert into HoaDonBanHang values("+bh.MaHoaDon1+", '"+bh.NgayThang1+"', "+bh.MaKhachHang1+","+bh.TongTien1+","+bh.MaNV1+")");
        }
        public void UpdateHoaDonBan(DTO_HoaDonBan bh)
        {
            string query = "update HoaDonBanHang set maNV= "+bh.MaNV1+" ,ngayThang = '" + bh.NgayThang1+"', tongTien = "+bh.TongTien1+", maKhachHang = "+bh.MaKhachHang1+" where maHoaDon = "+bh.MaHoaDon1+"";
            DataProvider.Instance.ExecuteNonQuery(query);
            
        }
       
        public DataTable TinhTong(int id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from ChiTietHoaDonBanHang where maHoaDon = " + id);
            return dt;
        }
        public DataTable ThongTinXem()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT  dbo.HoaDonBanHang.maHoaDon AS [Mã Hóa Đơn], dbo.HoaDonBanHang.tongTien AS [Tổng Tiền], dbo.NhanVien.tenNV AS [Nhân Viên], dbo.KhachHang.hoTen AS [Khách Hàng],   dbo.HoaDonBanHang.ngayThang AS[Ngày Tháng] FROM   dbo.ChiTietHoaDonBanHang INNER JOIN " +
                        " dbo.HoaDonBanHang ON dbo.ChiTietHoaDonBanHang.maHoaDon = dbo.HoaDonBanHang.maHoaDon INNER JOIN  dbo.KhachHang ON dbo.HoaDonBanHang.maKhachHang = dbo.KhachHang.maKhachHang INNER JOIN " +
                      "   dbo.NhanVien ON dbo.HoaDonBanHang.maNV = dbo.NhanVien.maNV group by   dbo.HoaDonBanHang.maHoaDon, dbo.HoaDonBanHang.tongTien, dbo.NhanVien.tenNV, dbo.KhachHang.hoTen, dbo.HoaDonBanHang.ngayThang ");
            return dt;
        }
        public DataTable ThongTinXem1HD( int MaHD)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(" ThongTin1HD @MaHD ", new object[] { MaHD });
            return dt;
        }

    }
}
