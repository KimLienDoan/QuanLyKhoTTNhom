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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dal_BH = new DAL_HoaDonNhap();
        public DataTable GetHoaDonNhap()
        {
            return dal_BH.GetHoaDonNhap();
        }
        public DataTable AddHoaDonNhap()
        {
            return dal_BH.AddHoaDonNhap();
        }
        public DataTable UpdateHoaDonNhap()
        {
            return dal_BH.UpdateHoaDonNhap();
        }
      
    }
}
