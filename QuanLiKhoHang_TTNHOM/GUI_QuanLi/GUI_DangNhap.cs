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
using DTO_QuanLy;

namespace GUI_QuanLi
{
    public partial class GUI_DangNhap : Form
    {
        DTO_NhanVien dtonv = new DTO_NhanVien();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttDangNhap_Click(object sender, EventArgs e)
        {
            BUS_NhanVien nv = new BUS_NhanVien();
            DataTable dataTable = nv.GetNhanVien();
       
                if (txtTaiKhoan.Text!= Int32.Parse(dataTable.Rows[i]["Mã Nhân Viên"].ToString()).ToString() && txtMatKhau.Text!= dataTable.Rows[i]["Mật Khẩu"].ToString())
                {
                    MessageBox.Show(" Yêu Cầu Nhập Lại!");
                }
                else

                {
                    GUI_frmChinh frm = new GUI_frmChinh();
                    frm.ShowDialog();
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
