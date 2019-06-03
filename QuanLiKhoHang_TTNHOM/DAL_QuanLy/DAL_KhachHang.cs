using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_KhachHang :DataProvider
    {
        public DataTable GetKhachHang()
        {
            string query = "SELECT maKhachHang AS [Mã Khách Hàng], hoTen AS [Tên Khách Hàng], ngaySinh AS [Ngày Sinh], gioiTinh AS [Giới Tính], diaChi AS [Địa Chỉ], sdt AS [Số Điện Thoại]" +
                                "FROM dbo.KhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
      
        public void AddKhachHang(DTO_KhachHang kh)
        {
            string query = "insert into KhachHang(maKhachHang,hoTen,ngaySinh,gioiTinh,diaChi,sdt) values (N'" + kh._MaKhachHang + "',N'" + kh._TenKhachHang + "',N'" + kh._NgaySinh + "',N'" + kh._GioiTinh + "',N'" + kh._DiaChi + "',N'" + kh._SDT +"')";
             DataProvider.Instance.ExecuteNonQuery(query);

        }
        
        public void DeleteKhachHang(int maKhachHang)
        {

             DataProvider.Instance.ExecuteNonQuery("delete from KhachHang where  maKhachHang="+maKhachHang);
            
     
        }
        public void UpdateKhachHang(DTO_KhachHang kh)
            
        {
            string query = "Update KhachHang set hoTen = N'"+kh._TenKhachHang+"',ngaysinh = N'"+kh._NgaySinh+"',gioitinh = '"
                +kh._GioiTinh+"',diachi = N'"+kh._DiaChi+"', sdt = '"+kh._SDT+"' where maKhachHang = "  +kh._MaKhachHang;

           DataProvider.Instance.ExecuteNonQuery(query);
          
            
           
        }
        public DataTable TimKiem(string TenKH)
        {
            string query = "select * from KhachHang where hoTen like N'%"+TenKH+"%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
