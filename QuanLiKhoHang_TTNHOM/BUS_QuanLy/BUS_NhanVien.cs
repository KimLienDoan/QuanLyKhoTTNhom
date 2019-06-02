using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DalNhanVien = new DAL_NhanVien();
        public DataTable GetNhanVien()
        {
            return DalNhanVien.GetNhanVien();
        }
        public DataTable AddNhanVien(DTO_NhanVien nv)
        {
            return DalNhanVien.AddNhanVien(nv);
        }
        public DataTable UpDateNhanVien(DTO_NhanVien nv)
        {
            return DalNhanVien.UpDateNhanVien(nv);
        }
        public DataTable DeleteNhanVien(int id)
        {
            return DalNhanVien.DeleteNhanVien(id);
        }
        public DataTable TTNhanVien()
        {
            return DalNhanVien.TTNhanVien();
        }
    }
}
