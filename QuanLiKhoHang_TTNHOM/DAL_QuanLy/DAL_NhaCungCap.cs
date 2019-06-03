using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
   public class DAL_NhaCungCap : DataProvider 
    {
        public DataTable GetNhaCungCap()
        {
            string query = "Select *from NhaCungCap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public void AddNhaCungCap(int MaNhaCungCap, int maHangHoa , string TenNCC , string diachiNCC )
        {
            string query = "insert into NhaCungCap(MaNhaCungCap,maHangHoa,TenNhaCungCap,DiaChiNCC) values ('" + MaNhaCungCap+ "','" +maHangHoa+ "',N'" + TenNCC+ "',N'" + diachiNCC+ "')";
            DataProvider.Instance.ExecuteNonQuery(query);

        }

        public void DeleteNCC(int MaNhaCungCap)
        {

            DataProvider.Instance.ExecuteNonQuery("delete from KhachHang where  MaNhaCungCap=" + MaNhaCungCap);


        }
        public void UpdateNCC(int MaNhaCungCap, int maHangHoa, string TenNCC, string diachiNCC)

        {
            string query = "Update NhaCungCap set maHangHoa = '" + maHangHoa + "',TenNhaCungCap = N'" +TenNCC + "',DiaChiNCC = '"  + diachiNCC + "' where MaNhaCungCap = " + MaNhaCungCap;

            DataProvider.Instance.ExecuteNonQuery(query);



        }
        public DataTable TimKiem(string TenNCC)
        {
            string query = "select * from NhaCungCap where TenNhaCungCap like N'%" + TenNCC + "%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
