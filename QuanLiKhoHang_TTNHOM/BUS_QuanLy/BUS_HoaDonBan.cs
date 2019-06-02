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
    public class BUS_HoaDonBan 
    {
        DAL_HoaDonBan dal_BH = new DAL_HoaDonBan();
        public DataTable GetHoaDonBan()
        {
            return dal_BH.GetHoaDonBan();
        }
        public void AddHoaDonBan(DTO_HoaDonBan db)
        {
             dal_BH.AddHoaDonBan(db);
        }
        public void UpdateHoaDonBan(DTO_HoaDonBan  db)
        {
             dal_BH.UpdateHoaDonBan(db);
        }
      
        public DataTable TinhTong(int id)
        {
            return dal_BH.TinhTong(id);
        }
        public DataTable ThongTinXem()
        {
            return ThongTinXem();
        }

    }
}
