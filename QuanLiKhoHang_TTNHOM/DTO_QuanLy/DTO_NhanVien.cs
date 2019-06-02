using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private int MaNhanVien;
        private string TenNhanVien;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string QueQuan;
        private string SDT;
        private int MaKhoHang;
        private string matkhau;

        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public int MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public int MaKhoHang1 { get => MaKhoHang; set => MaKhoHang = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        public DTO_NhanVien()
        {
        }
        public DTO_NhanVien(int MaNV,string tenNV, string gioitinh, string quequan ,string sdt, int MaKhoHang , DateTime ngaysinh )
        {
            this.MaNhanVien = MaNV;
            this.TenNhanVien = tenNV;
            this.NgaySinh = ngaysinh;
            this.QueQuan = quequan;
            this.SDT = sdt;
            this.GioiTinh = gioitinh;
            this.MaKhoHang = MaKhoHang;
            
        }
    }
}
