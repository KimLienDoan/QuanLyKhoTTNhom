using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_LoaiHang
    {
        private int MaLoaiHang;
        private string TenLoaiHang;

        public int MaLoaiHang1 { get => MaLoaiHang; set => MaLoaiHang = value; }
        public string TenLoaiHang1 { get => TenLoaiHang; set => TenLoaiHang = value; }
        public DTO_LoaiHang()
        {

        }
        public DTO_LoaiHang(int maLH, string TenLH)
        {
            this.MaLoaiHang = maLH;
            this.TenLoaiHang = TenLH;
        }
    }
}
