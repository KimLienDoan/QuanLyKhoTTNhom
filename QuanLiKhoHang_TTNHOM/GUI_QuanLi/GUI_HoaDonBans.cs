using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DAL_QuanLy;
using DTO_QuanLy;
namespace GUI_QuanLi
{
    public partial class GUI_HoaDonBan : Form
    {

        public GUI_HoaDonBan()
        {
            InitializeComponent();

        }
        public GUI_HoaDonBan(int maHoaDon, int maNV , int maKH  )
        {
            InitializeComponent();
            txtMaHD.Text = maHoaDon.ToString();
            combMaNV.Text = maNV.ToString();
            combKH.Text = maKH.ToString();
            
            
        }
        BUS_HoaDonBan hd = new BUS_HoaDonBan();
        BUS_ChiTietHoaDonBan ct = new BUS_ChiTietHoaDonBan();
        DTO_ChiTietHDBan DTOct = new DTO_ChiTietHDBan();
        DTO_HoaDonBan DTOhd = new DTO_HoaDonBan();
        BUS_HangHoa hh = new BUS_HangHoa();
        BUS_NhanVien nv = new BUS_NhanVien();
        int dong = 0;
        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
            //DataTable dthoadn = DataProvider.Instance.ExecuteQuery("select maHangHoa, tenHangHoa  from HangHoa where soLuong > 0 ");

            //do dl len cbbox 
            cmboMa.DataSource = hh.LayTTHang(" where soLuong > 0 ");
            cmboMa.ValueMember = "maHangHoa";
            cmboMa.DisplayMember = "tenHangHoa";
            DataTable dta = DataProvider.Instance.ExecuteQuery("select MaKhachHang,hoTen from KhachHang");
            combKH.DataSource = dta.Copy();
            combKH.ValueMember = "MaKhachHang";
            combKH.DisplayMember = "hoTen";
            combMaNV.DataSource = nv.TTNhanVien();
            combMaNV.ValueMember = "maNV";
            combMaNV.DisplayMember = "tenNV";
        }
       
        private void dtCTHH_CellCLlick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dtHDHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtHDHang.Rows[dong].Cells[1].Value != "0" && dtHDHang.Rows[dong].Cells[2].Value != "0")
            {
                try
                {
                    dtHDHang.Rows[dong].Cells[3].Value = (double.Parse(dtHDHang.Rows[dong].Cells[1].Value.ToString()) * double.Parse(dtHDHang.Rows[dong].Cells[2].Value.ToString())).ToString();
                }
                catch { }
            }
            try
            {
                DataTable dt = new DataTable();
                dt = hh.LayTTHang("where maHangHoa ='" + dtHDHang.Rows[dong].Cells[0].Value.ToString() + "'");
                dtHDHang.Rows[dong].Cells[2].Value = double.Parse(dt.Rows[0]["GiaHang"].ToString()).ToString();
            }
            catch { }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            GUI_frmChinh frm = new GUI_frmChinh();
            frm.ShowDialog();
        }

        private void bttThongTin_Click(object sender, EventArgs e)
        {

            dtgrHDH.DataSource = hd.ThongTinXem1HD(Int32.Parse(txtMaHD.Text.ToString()));
        }

        private void bttThem_Click(object sender, EventArgs e)
        {

            DTOhd.MaKhachHang1 = (int)combKH.SelectedValue;
            DTOhd.MaNV1 = (int)combMaNV.SelectedValue;
            DTOhd.NgayThang1 = dateTimeNgayBan.Value;
            int tongtien = 0;
            try
            {
                DTOhd.MaHoaDon1 = Int32.Parse(txtMaHD.Text);
                hd.AddHoaDonBan(DTOhd);
                for (int i = 0; i < dtHDHang.Rows.Count - 1; i++)
                {
                    DTOct.MaHoaDon1 = Int32.Parse(txtMaHD.Text.ToString());
                    DTOct.MahangHoa1 = Int32.Parse(dtHDHang.Rows[i].Cells[0].Value.ToString());
                    DTOct.SoLuong1 = Int32.Parse(dtHDHang.Rows[i].Cells[1].Value.ToString());
                    DTOct.GiaBanRa1 = Int32.Parse(dtHDHang.Rows[i].Cells[2].Value.ToString());
                    tongtien += Int32.Parse(dtHDHang.Rows[i].Cells[3].Value.ToString());
                    ct.AddCTHoaDonBan(DTOct);
                }
                txtThanhToan.Text = tongtien.ToString();
                DTOhd.TongTien1 = Convert.ToInt32(tongtien);
                hd.UpdateHoaDonBan(DTOhd);
                MessageBox.Show("Đã Tạo Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
       
        }

        private void grBCTHoaDon_Enter(object sender, EventArgs e)
        {

        }

        private void dtHDHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void bttHD_Click(object sender, EventArgs e)
        {
            dtgrHDH.DataSource = hd.ThongTinXem();
        }
    }
}
