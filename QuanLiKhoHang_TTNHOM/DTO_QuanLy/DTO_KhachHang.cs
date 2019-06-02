using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private int MaKhachHang;
        private string TenKhachHang;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        public int _MaKhachHang
        {
            get
            {
                return MaKhachHang;
            }
            set
            {
                MaKhachHang = value;
            }
        }
        public string _TenKhachHang
        {
            get
            {
                return TenKhachHang;
            }
            set
            {
                TenKhachHang = value;
            }
        }
        public DateTime _NgaySinh
        {
            get
            {
                return NgaySinh;
            }
            set
            {
                NgaySinh = value;
            }
        }
        public string _GioiTinh
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public string _DiaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string _SDT
        {
            get
            {
                return SDT;
            }
            set
            {
                SDT = value;
            }
        }
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(int id, string name, DateTime date, string gioiTinh , string address, string phone)
        {
            this.MaKhachHang = id;
            this.TenKhachHang = name;
            this.NgaySinh = date;
            this.GioiTinh = gioiTinh;
            this.DiaChi = address;
            this.SDT = phone;
        }

    }
}
