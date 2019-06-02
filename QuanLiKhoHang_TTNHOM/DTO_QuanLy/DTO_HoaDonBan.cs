using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDonBan
    {
        private int MaHoaDon;
        private int MaNV;
        private DateTime NgayThang;
        private int MaKhachHang;
        private int TongTien;

        public int MaHoaDon1 { get => MaHoaDon; set => MaHoaDon = value; }
        public DateTime NgayThang1 { get => NgayThang; set => NgayThang = value; }
        public int MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
        public int MaNV1 { get => MaNV; set => MaNV = value; }

        public DTO_HoaDonBan()
        {

        }
        public DTO_HoaDonBan (int MaHD,int MaNV, DateTime ngaythang, int MaKH, int TongTien )
       {
            this.MaHoaDon = MaHD;
            this.MaNV = MaNV;
            this.NgayThang = ngaythang;
            this.MaKhachHang = MaKH;
            this.TongTien = TongTien;
       }
    }
   
}
