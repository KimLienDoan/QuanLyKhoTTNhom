using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
   public class DTO_HangHoa
    {
        private int maHangHoa;
        private string TenHagHoa;
        private DateTime NgaySX;
        private int SoLuong;
        private float GiaHang;
   
        private float GiaBanRa;
        private string DVT;
        private int MaKhoHang;
        private string mota;

        public int MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHagHoa1 { get => TenHagHoa; set => TenHagHoa = value; }
        public DateTime NgaySX1 { get => NgaySX; set => NgaySX = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float GiaHang1 { get => GiaHang; set => GiaHang = value; }
        public string DVT1 { get => DVT; set => DVT = value; }
        public int MaKhoHang1 { get => MaKhoHang; set => MaKhoHang = value; }
        public string Mota { get => mota; set => mota = value; }
        public float GiaBanRa1 { get => GiaBanRa; set => GiaBanRa = value; }

        public DTO_HangHoa()
        {

        }
        public DTO_HangHoa(int _ma, string _Ten , DateTime _ngaysx, int _SoLuong,float giaHang ,float giaBanRa , string dvt , int MaKhoHang , string mota)
        {
            this.maHangHoa = _ma;
            this.TenHagHoa = _Ten;
            this.NgaySX = _ngaysx;
            this.SoLuong = _SoLuong;
            this.GiaHang = giaHang;
            this.DVT = dvt;
            this.MaKhoHang = MaKhoHang;
            this.mota = mota;
            this.GiaBanRa = giaBanRa;
        }

    }
}
