using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietHDBan
    {
        private int MaHoaDon;
        private int MahangHoa;
        private int SoLuong;
        private float ThanhTien;
        private float GiaBanRa;

        public int MaHoaDon1 { get => MaHoaDon; set => MaHoaDon = value; }
        public int MahangHoa1 { get => MahangHoa; set => MahangHoa = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public float GiaBanRa1 { get => GiaBanRa; set => GiaBanRa = value; }

        public DTO_ChiTietHDBan()
        {

        }
        public DTO_ChiTietHDBan(int MaHD, int MaHH , int SoLuong,float giaBanRa, float ThanhTien)
        {
            this.MaHoaDon = MaHD;
            this.MahangHoa = MaHH;
            this.SoLuong = SoLuong;
            this.GiaBanRa = giaBanRa;
            this.ThanhTien = ThanhTien;
        }

    }


}
