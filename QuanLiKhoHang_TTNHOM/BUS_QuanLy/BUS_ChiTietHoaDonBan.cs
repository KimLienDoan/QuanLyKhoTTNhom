using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ChiTietHoaDonBan
    {
        DAL_CTHoaDonBan ct = new DAL_CTHoaDonBan();
        public DataTable GetCTHoaDonBan()
        {
            return ct.GetCTHoaDonBan();
        }
        public void AddCTHoaDonBan(DTO_ChiTietHDBan hd)
        {
            ct.AddCTHoaDonBan(hd);
        }
        public void UpdateCTHoaDonBan(DTO_ChiTietHDBan hd)
        {
            ct.UpdateCTHoaDonBan(hd);

        }
        public void DeleteCTHoaDonBan(int maHH, int maHD)
        {
            ct.DeleteCTHoaDonBan(maHH, maHD);

        }
       
        public DataTable LayCTHang()
        {
            return ct.LayCTHang();
        }
    }
}
