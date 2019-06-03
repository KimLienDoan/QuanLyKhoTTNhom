using System;
using BUS_QuanLy;
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

namespace GUI_QuanLi
{
    public partial class GUI_NhanVien : Form
    {
        
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
      
        private void btthem_Click_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtGtinh.Text != "" && txtQueQuan.Text != "" && txtSDT.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(Int32.Parse(txtMaNV.Text), txtTenNV.Text, txtGtinh.Text, txtQueQuan.Text, txtSDT.Text, Int32.Parse(combMaKho.ToString()), dateTimeNgaysinh.Value);
                busNV.AddNhanVien(nv);
                dtGrid_NhanVien.DataSource = busNV.GetNhanVien();
            }
            else
            {
                MessageBox.Show("Yêu Cầu Nhập Lại");
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtKhoHang = DataProvider.Instance.ExecuteQuery("select *from LoaiHang");

            dtGrid_NhanVien.DataSource = busNV.GetNhanVien();

            //do dl len cbbox 
            combMaKho.DataSource = dtKhoHang.Copy();
            combMaKho.DisplayMember = "tenLoaiHang";
            combMaKho.ValueMember = "maLoaiHang";
            
        }
      
        private void label1_Click(object sender, EventArgs e) {  }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtGtinh.Text != "" && txtQueQuan.Text != ""  && txtSDT.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(Int32.Parse(txtMaNV.Text),txtTenNV.Text,txtGtinh.Text,txtQueQuan.Text, txtSDT.Text,(int)combMaKho.SelectedValue,dateTimeNgaysinh.Value);
                busNV.AddNhanVien(nv);
                dtGrid_NhanVien.DataSource = busNV.GetNhanVien();
            }
            else
            {
                MessageBox.Show("Yêu Cầu Nhập Lại");
            }
        }

        private void bttSua_Click_1(object sender, EventArgs e)
        {
            //if (dtGrid_NhanVien.SelectedRows.Count > 0)
            //{
                if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtGtinh.Text != "" && txtQueQuan.Text != "" && txtSDT.Text != "" && combMaKho.Text!="")
                {
                    DataGridViewRow  row = dtGrid_NhanVien.SelectedRows[0];
                    DTO_NhanVien nv = new DTO_NhanVien(Int32.Parse(txtMaNV.Text), txtTenNV.Text, txtGtinh.Text, txtQueQuan.Text, txtSDT.Text, (int)combMaKho.SelectedValue, dateTimeNgaysinh.Value);
                    busNV.UpDateNhanVien(nv);
                    MessageBox.Show("Bạn Sửa Thành Công");
                    dtGrid_NhanVien.DataSource = busNV.GetNhanVien();

                }
                else
                    MessageBox.Show("Yêu cầu bạn nhập lại");
            //}
        }

        private void dtGrid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaNV.Text = dtGrid_NhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNV.Text = dtGrid_NhanVien.Rows[index].Cells[1].Value.ToString();
                dateTimeNgaysinh.Text = dtGrid_NhanVien.Rows[index].Cells[2].Value.ToString();
                txtGtinh.Text = dtGrid_NhanVien.Rows[index].Cells[3].Value.ToString();
                txtQueQuan.Text = dtGrid_NhanVien.Rows[index].Cells[4].Value.ToString();
                txtSDT.Text = dtGrid_NhanVien.Rows[index].Cells[5].Value.ToString();
                combMaKho.Text = dtGrid_NhanVien.Rows[index].Cells[6].Value.ToString();

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dtGrid_NhanVien.SelectedRows.Count>0)
            {
                DataGridViewRow row = dtGrid_NhanVien.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                busNV.DeleteNhanVien(id);
                MessageBox.Show("Xóa Thành Công ! ");
                dtGrid_NhanVien.DataSource = busNV.GetNhanVien();
            }
        }

        private void dtGrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNV.Text = dtGrid_NhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNV.Text = dtGrid_NhanVien.Rows[index].Cells[1].Value.ToString();
                dateTimeNgaysinh.Text = dtGrid_NhanVien.Rows[index].Cells[2].Value.ToString();
                txtGtinh.Text = dtGrid_NhanVien.Rows[index].Cells[3].Value.ToString();
                txtQueQuan.Text = dtGrid_NhanVien.Rows[index].Cells[4].Value.ToString();
                txtSDT.Text = dtGrid_NhanVien.Rows[index].Cells[5].Value.ToString();
                combMaKho.Text = dtGrid_NhanVien.Rows[index].Cells[6].Value.ToString();

            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            GUI_frmChinh frm = new GUI_frmChinh();
            frm.ShowDialog();
        }

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    
        private void txtTenNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtMaNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string TK = txbTK.Text;
            dtGrid_NhanVien.DataSource = busNV.Timkiem(TK);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbmaKhoHang_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGtinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDT_Click(object sender, EventArgs e)
        {

        }

        private void lbquequan_Click(object sender, EventArgs e)
        {

        }

        private void lbNgaysinh_Click(object sender, EventArgs e)
        {

        }

        private void lbgioitinh_Click(object sender, EventArgs e)
        {

        }

        private void TenNV_Click(object sender, EventArgs e)
        {

        }

        private void IbIDNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void MaNV_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
