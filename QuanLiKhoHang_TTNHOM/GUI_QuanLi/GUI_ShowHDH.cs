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
using BUS_QuanLy;

namespace GUI_QuanLi
{
    public partial class GUI_ShowHDH : Form
    {
        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        public GUI_ShowHDH()
        {
            InitializeComponent();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtHDBanss(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }

        private void GUI_ShowHDH_Load(object sender, EventArgs e)
        {
            dtGrid_HDBan.DataSource = busHDB.GetHoaDonBan();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan frm = new GUI_HoaDonBan();
            frm.ShowDialog();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
          
        }

        private void dtGrid_HDBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GUI_HoaDonBan frmHD = new GUI_HoaDonBan();
            int index = e.RowIndex  ;
            if (index >= 0)
            {
                string maHD = dtGrid_HDBan.Rows[index].Cells[0].Value.ToString();
                string egd = dtGrid_HDBan.Rows[index].Cells[1].Value.ToString();
                string vtmass = dtGrid_HDBan.Rows[index].Cells[2].Value.ToString();

                var frmTemp = new GUI_HoaDonBan(Int32.Parse(maHD.ToString()),Int32.Parse(egd.ToString()),Int32.Parse( vtmass.ToString()));
                frmTemp.ShowDialog();
                //frmHD..Text = dtGrid_KhachHang.Rows[index].Cells[0].Value.ToString();
                //txtTenKH.Text = dtGrid_KhachHang.Rows[index].Cells[1].Value.ToString();
                //dateTimeNgaysinh.Text = dtGrid_KhachHang.Rows[index].Cells[2].Value.ToString();
                //txtGtinh.Text = dtGrid_KhachHang.Rows[index].Cells[3].Value.ToString();
                //txtQueQuan.Text = dtGrid_KhachHang.Rows[index].Cells[4].Value.ToString();
                //txtSDT.Text = dtGrid_KhachHang.Rows[index].Cells[5].Value.ToString();
            }
        }
    }
}
