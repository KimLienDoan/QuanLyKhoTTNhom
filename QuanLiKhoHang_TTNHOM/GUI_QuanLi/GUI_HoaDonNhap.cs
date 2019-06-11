using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using DAL_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLi
{
    public partial class GUI_HoaDonNhap : Form
    {
        BUS_HoaDonNhap hdNhap = new BUS_HoaDonNhap(); 
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void dtHDHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //     private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        ////     {
        ////         string query = "select hd.maHoaDonNhap,hd.ngayThang,hh.tenHangHoa,ct.soLuong, ct.thanhTien,hd.maNV, hd.tongTien " +
        //// "from HoaDonNhap hd , ChiTietHoaDonNhap ct, HangHoa hh " +
        ////" where hd.maHoaDonNhap = ct.maHoaDonNhap and hh.maHangHoa = ct.maHangHoa";
        ////         DataTable dtHoaDonNhap = DataProvider.Instance.ExecuteQuery(query);

        ////         var test = hdNhap.GetHoaDonNhap();
        ////         dtGrid_HDNhap.DataSource = hdNhap.GetHoaDonNhap();

        ////         //do dl len cbbox 
        ////         combMaHH.DataSource = dtHoaDonNhap.Copy();
        ////         combMaHH.DisplayMember = "tenHangHoa";


        //     }

        //     private void combMaHH_TextChanged(object sender, EventArgs e)
        //     {
        //       // Lay hang hoa day ra --------------- >>> Select wher -----> DataTable ->>>> Lay row ->>>> Cell nao

        //       // lay value song luong input
        //       //int thanhtien = 0;
        //       // txtThanhTien.Text = thanhtien.ToString();
        //     }

        //     private void button1_Click(object sender, EventArgs e)
        //     {
        //         GUI_frmChinh frm = new GUI_frmChinh();
        //         frm.ShowDialog();
        //     }
    }
}
