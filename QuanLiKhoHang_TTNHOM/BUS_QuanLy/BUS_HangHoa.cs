using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HangHoa
    {
        DAL_HangHoa dalHangHoa = new DAL_HangHoa();
        public DataTable GetHangHoa()
        {
            return dalHangHoa.GetHangHoa();
        }
        public DataTable AddHangHoa(DTO_HangHoa hh)
        {
            return dalHangHoa.AddHangHoa(hh);
        }
        public DataTable UpdateHangHoa(DTO_HangHoa hh)
        {
            return dalHangHoa.UpdateHangHoa(hh);
        }
        public DataTable DeleteHangHoa(int id)
        {
            return dalHangHoa.DeleteHangHoa(id);
        }
        public DataTable LayTTHang(string dk)
        {
            return dalHangHoa.LayTTHang(dk);
        }
    }
}
