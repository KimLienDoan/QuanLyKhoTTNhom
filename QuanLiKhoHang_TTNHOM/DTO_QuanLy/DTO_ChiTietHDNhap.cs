using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    class DTO_ChiTietHDNhap
    {
        private int maHangHoa;
        private int maHoaDonNhap;
        private int soLuong;
        private int thanhTien;

        public int MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public int MaHoaDonNhap { get => maHoaDonNhap; set => maHoaDonNhap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public DTO_ChiTietHDNhap()
        {
           
        }
        public DTO_ChiTietHDNhap(int MaHH, int MaDN, int SoLuong, int ThanhTien)
        {
            this.maHangHoa = MaHH;
            this.maHoaDonNhap = MaDN;
            this.soLuong = SoLuong;
            this.thanhTien = ThanhTien;

        }
    }
}
