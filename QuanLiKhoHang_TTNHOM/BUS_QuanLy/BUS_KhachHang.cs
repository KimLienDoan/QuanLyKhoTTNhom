using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
   public class BUS_KhachHang
    {
        DAL_KhachHang dal_KH = new DAL_KhachHang();
        public DataTable GetKhachHang()
        {
            return dal_KH.GetKhachHang();
        }
        public void AddKhachHang(DTO_KhachHang kh)
        {
             dal_KH. AddKhachHang(kh);
        }
        public void DeleteKhachHang(int MaKH)
        {
             dal_KH.DeleteKhachHang(MaKH);
        }
        public void UpdateKhachHang(DTO_KhachHang kh)
        {
             dal_KH.UpdateKhachHang(kh);
        }
        public DataTable TimKiem(string TenKH)
        {
            return dal_KH.TimKiem(TenKH);
        }
  }
}
