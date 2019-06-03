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


namespace GUI_QuanLi
{
    public partial class NhaCungCap : Form
    {
        BUS_NCC ncc = new BUS_NCC();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            ncc.AddNhaCungCap(int.Parse(txtMaNV.Text.ToString()), (int)combMaHang.SelectedValue, txtTenNV.Text, txtSDT.Text);
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            ncc.UpdateNCC(int.Parse(txtMaNV.Text.ToString()), (int)combMaHang.SelectedValue, txtTenNV.Text, txtSDT.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ncc.DeleteNCC(int.Parse(txtMaNV.Text.ToString()));
        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select *from HangHoa");

            dtGrid_NhanVien.DataSource = ncc.GetNhaCungCap();

            //do dl len cbbox 
            combMaHang.DataSource = dt.Copy();
            combMaHang.DisplayMember = "tenHangHoa";
            combMaHang.ValueMember = "maHangHoa";

        }

        private void dtGrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNV.Text = dtGrid_NhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNV.Text = dtGrid_NhanVien.Rows[index].Cells[2].Value.ToString();
                combMaHang.Text = dtGrid_NhanVien.Rows[index].Cells[1].Value.ToString();
                txtSDT.Text = dtGrid_NhanVien.Rows[index].Cells[3].Value.ToString();
                

            }
        }
    }
}
