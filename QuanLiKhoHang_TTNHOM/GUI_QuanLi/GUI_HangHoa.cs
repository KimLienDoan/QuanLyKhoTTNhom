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
    public partial class GUI_HangHoa : Form
    {
        BUS_HangHoa BusHH = new BUS_HangHoa();
        public GUI_HangHoa()
        {
            InitializeComponent();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (dtGrid_HangHoa.SelectedRows.Count >= 0)
            {
                if (txtMaHHoa.Text == " " || txtTenHH.Text == "" || txtSoLuong.Text == "" || txtGiaHang.Text == "")
                {
                    MessageBox.Show("Yêu Cầu Bạn Nhập Lại");
                }
                else
                {
                    DataGridViewRow row = dtGrid_HangHoa.SelectedRows[0];
                    DTO_HangHoa hh = new DTO_HangHoa(Int32.Parse(txtMaHHoa.Text), txtTenHH.Text, DTimeNgaysinh.Value, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaHang.Text), Int32.Parse(txtGiaBan.Text), txtDVT.Text,  (int)combMaKhoHang.SelectedValue, txtMoTa.Text );
                    BusHH.AddHangHoa(hh);
                    MessageBox.Show("Thêm Thành Công");
                    dtGrid_HangHoa.DataSource = BusHH.GetHangHoa();
                }
            }
        }
        private void GUI_HangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtKhoHang = DataProvider.Instance.ExecuteQuery("select *from LoaiHang");

            dtGrid_HangHoa.DataSource = BusHH.GetHangHoa();

            //do dl len cbbox 
            combMaKhoHang.DataSource = dtKhoHang.Copy();
            combMaKhoHang.DisplayMember = "tenLoaiHang";
            combMaKhoHang.ValueMember = "maLoaiHang";

        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            if (dtGrid_HangHoa.SelectedRows.Count > 0)
            {
                if (txtMaHHoa.Text == "" || txtTenHH.Text == "" || txtSoLuong.Text == "" || txtGiaHang.Text == "" )
                {
                    MessageBox.Show("Yêu Cầu Bạn Nhập Lại");
                }
                else
                {
                    DataGridViewRow row = dtGrid_HangHoa.SelectedRows[0];
                    DTO_HangHoa hh = new DTO_HangHoa(Int32.Parse(txtMaHHoa.Text), txtTenHH.Text, DTimeNgaysinh.Value, Int32.Parse(txtSoLuong.Text), Int32.Parse(txtGiaHang.Text), Int32.Parse(txtGiaBan.Text), txtDVT.Text, (int)combMaKhoHang.SelectedValue, txtMoTa.Text);
                    BusHH.UpdateHangHoa(hh);
                    MessageBox.Show("Sửa Thành Công");
                    dtGrid_HangHoa.DataSource = BusHH.GetHangHoa();
                }

            }
            else MessageBox.Show("Yêu Cầu Bạn Nhập Lại");
        }

  

        private void dtGrid_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaHHoa.Text = dtGrid_HangHoa.Rows[index].Cells[0].Value.ToString();
                txtTenHH.Text = dtGrid_HangHoa.Rows[index].Cells[1].Value.ToString();
                DTimeNgaysinh.Text = dtGrid_HangHoa.Rows[index].Cells[2].Value.ToString();
                txtSoLuong.Text = dtGrid_HangHoa.Rows[index].Cells[3].Value.ToString();
                txtGiaHang.Text = dtGrid_HangHoa.Rows[index].Cells[4].Value.ToString();
                txtDVT.Text = dtGrid_HangHoa.Rows[index].Cells[5].Value.ToString();
                txtGiaBan.Text = dtGrid_HangHoa.Rows[index].Cells[6].Value.ToString();
                combMaKhoHang.Text = dtGrid_HangHoa.Rows[index].Cells[7].Value.ToString();
                txtMoTa.Text = dtGrid_HangHoa.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtGrid_HangHoa.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dtGrid_HangHoa.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                MessageBox.Show("Bạn Có đồng ý xóa", "Thông báo", MessageBoxButtons.OK);
                BusHH.DeleteHangHoa(id);
                MessageBox.Show("Xoa Thành Công");
                dtGrid_HangHoa.DataSource = BusHH.GetHangHoa();

            }
            else
            {
                MessageBox.Show("Hãy Chọn Hàng Hóa Muốn Xóa");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frm = new GUI_NhanVien();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void combMaKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DTimeNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHHoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDT_Click(object sender, EventArgs e)
        {

        }

        private void lbNgaysinh_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtGrid_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labMaHang_Click(object sender, EventArgs e)
        {

        }

        private void MaNV_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
