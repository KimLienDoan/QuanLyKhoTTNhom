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
    public partial class GUI_KhachHang : Form
    {
        DataTable table = new DataTable();
        BUS_KhachHang BusKH = new BUS_KhachHang();
       
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) {}
        private void panel1_Paint(object sender, PaintEventArgs e) { }


        private void KhachHang_Load(object sender, EventArgs e)
        {
            dtGrid_KhachHang.DataSource = BusKH.GetKhachHang();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" || txtTenKH.Text != "" || txtGtinh.Text != "" || txtQueQuan.Text != "" || txtSDT.Text != "")
            {

                DTO_KhachHang khs = new DTO_KhachHang(Int32.Parse(txtMaKH.Text), txtTenKH.Text, dateTimeNgaysinh.Value, txtGtinh.Text, txtQueQuan.Text, txtSDT.Text);
                BusKH.AddKhachHang(khs);
                dtGrid_KhachHang.DataSource = BusKH.GetKhachHang();
              
            }

            else
            {
                MessageBox.Show("Xin hay nhap lai");
            }
        }

    

        private void bttSua_Click_1(object sender, EventArgs e)
        {
            if (dtGrid_KhachHang.SelectedRows.Count >= 0)
            {
                if (txtMaKH.Text != "" || txtTenKH.Text != "" || txtGtinh.Text != "" || txtQueQuan.Text != "" || txtSDT.Text != "")
                {
                    DataGridViewRow row = dtGrid_KhachHang.SelectedRows[0];
                    DTO_KhachHang khh = new DTO_KhachHang(Int32.Parse(txtMaKH.Text), txtTenKH.Text, dateTimeNgaysinh.Value, txtGtinh.Text, txtQueQuan.Text, txtSDT.Text);
                    BusKH.UpdateKhachHang(khh);
                    MessageBox.Show("Bạn có muốn sửa" ,"Thông báo", MessageBoxButtons.OK);
                    dtGrid_KhachHang.DataSource = BusKH.GetKhachHang();
                }
                else
                {
                    MessageBox.Show("Hãy Chọn Thành Viên Muốn Sửa");
                }

            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (dtGrid_KhachHang.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dtGrid_KhachHang.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                MessageBox.Show("Bạn Có đồng ý xóa", "Thông báo", MessageBoxButtons.OK);
                BusKH.DeleteKhachHang(id);
                MessageBox.Show("Xoa Thành Công");
                dtGrid_KhachHang.DataSource = BusKH.GetKhachHang();

            }
            else
            {
                MessageBox.Show("Hãy Chọn Thành Viên Muốn Xóa");
            }
        }

        private void dtGrid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            GUI_frmChinh frm = new GUI_frmChinh();
            frm.ShowDialog();
        }

        private void dtGrid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaKH.Text = dtGrid_KhachHang.Rows[index].Cells[0].Value.ToString();
                txtTenKH.Text = dtGrid_KhachHang.Rows[index].Cells[1].Value.ToString();
                dateTimeNgaysinh.Text = dtGrid_KhachHang.Rows[index].Cells[2].Value.ToString();
                txtGtinh.Text = dtGrid_KhachHang.Rows[index].Cells[3].Value.ToString();
                txtQueQuan.Text = dtGrid_KhachHang.Rows[index].Cells[4].Value.ToString();
                txtSDT.Text = dtGrid_KhachHang.Rows[index].Cells[5].Value.ToString();
            }
        }
    }
}
