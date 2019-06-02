using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NhanVien : DataProvider
    {
        public DataTable GetNhanVien()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT maNV AS [Mã Nhân Viên], tenNV AS [Tên Nhân Viên], ngaySinh AS [Ngày Sinh], GioiTinh AS [Giới Tính], queQuan AS [Quê Quán], "+
                                                        "sDT AS [Số Điện Thoại], maKhoHang AS [Mã Kho Hàng], Matkhau AS [Mật Khẩu] FROM   dbo.NhanVien");
            return (dt);
        }
        public DataTable AddNhanVien(DTO_NhanVien nv)
        {
            string query = "insert into NhanVien(maNV,tenNV,ngaySinh,GioiTinh,queQuan,sDT, maKhoHang, Matkhau)"
                + "values ("+nv.MaNhanVien1+",'"+nv.TenNhanVien1+"','"+nv.NgaySinh1+"','"+nv.GioiTinh1+"','"+nv.QueQuan1+"','"+nv.SDT1+"',"+nv.MaKhoHang1+",'"+nv.Matkhau+"')";
            return DataProvider.Instance.ExecuteQuery(query);
          
        }
        public DataTable UpDateNhanVien(DTO_NhanVien Nv)
        {
            string query = "Update NhanVien set tenNV = N'" + Nv.TenNhanVien1+"',ngaysinh = N'"+Nv.NgaySinh1+ "',GioiTinh = N'"
                + Nv.GioiTinh1 + "',queQuan = N'" + Nv.QueQuan1 + "', sDT = '" + Nv.SDT1 + "', maKhoHang=" +Nv.MaKhoHang1+ " , Matkhau = '" + Nv.Matkhau + "' where maNV = " + Nv.MaNhanVien1 ;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }
        public DataTable DeleteNhanVien(int id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("delete from NhanVien where  maNV=" + id );

            return dt;
        }
      
        public DataTable TTNhanVien()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("Select maNV, tenNV from NhanVien");
            return dt;
        }
    }
}
