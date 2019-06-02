using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QuanLi;

namespace GUI_QuanLi
{
    public partial class GUI_frmChinh : Form
    {
        public GUI_frmChinh()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frm = new GUI_NhanVien();
            frm.ShowDialog();
        }

        private void bttNhanVien_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frmNV = new GUI_NhanVien();
            frmNV.ShowDialog();
            this.Close();
        }

        private void bttKhachHang_Click(object sender, EventArgs e)
        {
            GUI_KhachHang frmNV = new GUI_KhachHang();
            frmNV.ShowDialog();
            this.Close();
        }

        private void bttHangHoa_Click(object sender, EventArgs e)
        {
            GUI_HangHoa frmNV = new GUI_HangHoa();
            frmNV.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan frmNV = new GUI_HoaDonBan();
            frmNV.ShowDialog();
            this.Close();

        }

        private void bttHDN_Click(object sender, EventArgs e)
        {
            GUI_HoaDonNhap frmNV = new GUI_HoaDonNhap();
            frmNV.ShowDialog();
            this.Close();
        }

        private void bttNCC_Click(object sender, EventArgs e)
        {
            //GUI frmNV = new GUI_HoaDonNhap();
            //frmNV.ShowDialog();
        }
    }
}
