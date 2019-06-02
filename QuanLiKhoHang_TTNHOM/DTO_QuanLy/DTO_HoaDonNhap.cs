using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDonNhap
    {
        private int maHoaDonNhap;
        private DateTime ngayThang;
        private int tongTien;
        private int maNV;

        public int MaHoaDonNhap { get => maHoaDonNhap; set => maHoaDonNhap = value; }
        public DateTime NgayThang { get => ngayThang; set => ngayThang = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DTO_HoaDonNhap()
        {

        }
        public DTO_HoaDonNhap( int MaHDNhap , DateTime NgayThang, int TongTien, int MaNV)
        {
            this.maHoaDonNhap = MaHDNhap;
            this.ngayThang = NgayThang;
            this.tongTien = TongTien;
            this.maNV = MaNV;
        }
    }
}
