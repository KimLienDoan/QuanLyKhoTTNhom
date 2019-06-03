using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NCC 
    {
        DAL_NhaCungCap DAL_ncc = new DAL_NhaCungCap();

        public DataTable GetNhaCungCap()
        {
            return DAL_ncc.GetNhaCungCap();
        }

        public void AddNhaCungCap(int MaNhaCungCap, int maHangHoa, string TenNCC, string diachiNCC)
        {
            DAL_ncc.AddNhaCungCap(MaNhaCungCap, maHangHoa, TenNCC, diachiNCC);

        }

        public void DeleteNCC(int MaNhaCungCap)
        {

            DAL_ncc.DeleteNCC(MaNhaCungCap);


        }
        public void UpdateNCC(int MaNhaCungCap, int maHangHoa, string TenNCC, string diachiNCC)

        {
            DAL_ncc.UpdateNCC(MaNhaCungCap, maHangHoa, TenNCC, diachiNCC);



        }
        public DataTable TimKiem(string TenNCC)
        {

            return DAL_ncc.TimKiem(TenNCC);
        }
    }
}
