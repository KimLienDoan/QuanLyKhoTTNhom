namespace GUI_QuanLi
{
    partial class GUI_HoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtthanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmboMa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtHDHang = new System.Windows.Forms.DataGridView();
            this.txtgiaBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hangHoaTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSet1TableAdapters.HangHoaTableAdapter();
            this.loaiHangTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSet1TableAdapters.LoaiHangTableAdapter();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_KHODataSet1 = new GUI_QuanLi.QUAN_LY_KHODataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combMaNV = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKHODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_KHODataSet = new GUI_QuanLi.QUAN_LY_KHODataSet();
            this.khachHangTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSetTableAdapters.KhachHangTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.combKH = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbquequan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttXemTT = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttThoat = new System.Windows.Forms.Button();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grBCTHoaDon = new System.Windows.Forms.GroupBox();
            this.dateTimeNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtHDHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.grBCTHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtthanhTien
            // 
            this.txtthanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtthanhTien.DataPropertyName = "thanhTien";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.txtthanhTien.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtthanhTien.HeaderText = "Thành Tiền";
            this.txtthanhTien.Name = "txtthanhTien";
            this.txtthanhTien.ReadOnly = true;
            // 
            // txtsoLuong1
            // 
            this.txtsoLuong1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtsoLuong1.DataPropertyName = "soLuong";
            this.txtsoLuong1.HeaderText = "Số Lượng";
            this.txtsoLuong1.Name = "txtsoLuong1";
            // 
            // cmboMa
            // 
            this.cmboMa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmboMa.DataPropertyName = "maHangHoa";
            this.cmboMa.HeaderText = "Mã Hàng";
            this.cmboMa.Name = "cmboMa";
            // 
            // dtHDHang
            // 
            this.dtHDHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtHDHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHDHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmboMa,
            this.txtsoLuong1,
            this.txtgiaBanRa,
            this.txtthanhTien});
            this.dtHDHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHDHang.Location = new System.Drawing.Point(0, 0);
            this.dtHDHang.Name = "dtHDHang";
            this.dtHDHang.Size = new System.Drawing.Size(887, 265);
            this.dtHDHang.TabIndex = 0;
            // 
            // txtgiaBanRa
            // 
            this.txtgiaBanRa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtgiaBanRa.DataPropertyName = "GiaBanRa";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.txtgiaBanRa.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtgiaBanRa.HeaderText = "Đơn Giá Bán";
            this.txtgiaBanRa.Name = "txtgiaBanRa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtHDHang);
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 265);
            this.panel1.TabIndex = 85;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.qUAN_LY_KHODataSet1;
            // 
            // qUAN_LY_KHODataSet1
            // 
            this.qUAN_LY_KHODataSet1.DataSetName = "QUAN_LY_KHODataSet1";
            this.qUAN_LY_KHODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(345, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 8);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // combMaNV
            // 
            this.combMaNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hangHoaBindingSource, "tenHangHoa", true));
            this.combMaNV.DataSource = this.hangHoaBindingSource;
            this.combMaNV.DisplayMember = "tenHangHoa";
            this.combMaNV.FormattingEnabled = true;
            this.combMaNV.Location = new System.Drawing.Point(112, 69);
            this.combMaNV.Name = "combMaNV";
            this.combMaNV.Size = new System.Drawing.Size(180, 21);
            this.combMaNV.TabIndex = 92;
            this.combMaNV.ValueMember = "maHangHoa";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.qUAN_LY_KHODataSet1;
            // 
            // qUANLYKHODataSetBindingSource
            // 
            this.qUANLYKHODataSetBindingSource.DataSource = this.qUAN_LY_KHODataSet;
            this.qUANLYKHODataSetBindingSource.Position = 0;
            // 
            // qUAN_LY_KHODataSet
            // 
            this.qUAN_LY_KHODataSet.DataSetName = "QUAN_LY_KHODataSet";
            this.qUAN_LY_KHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 97;
            // 
            // combKH
            // 
            this.combKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource, "hoTen", true));
            this.combKH.DataSource = this.khachHangBindingSource;
            this.combKH.DisplayMember = "hoTen";
            this.combKH.FormattingEnabled = true;
            this.combKH.Location = new System.Drawing.Point(635, 19);
            this.combKH.Name = "combKH";
            this.combKH.Size = new System.Drawing.Size(180, 21);
            this.combKH.TabIndex = 91;
            this.combKH.ValueMember = "maKhachHang";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qUAN_LY_KHODataSet;
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Location = new System.Drawing.Point(5, 69);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(57, 13);
            this.lbquequan.TabIndex = 83;
            this.lbquequan.Text = "Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.bttXemTT);
            this.panel2.Controls.Add(this.bttThem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bttThoat);
            this.panel2.Controls.Add(this.txtThanhToan);
            this.panel2.Location = new System.Drawing.Point(12, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 60);
            this.panel2.TabIndex = 86;
            // 
            // bttXemTT
            // 
            this.bttXemTT.BackColor = System.Drawing.Color.Aquamarine;
            this.bttXemTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXemTT.Location = new System.Drawing.Point(476, 11);
            this.bttXemTT.Name = "bttXemTT";
            this.bttXemTT.Size = new System.Drawing.Size(90, 36);
            this.bttXemTT.TabIndex = 123;
            this.bttXemTT.Text = "Xem";
            this.bttXemTT.UseVisualStyleBackColor = false;
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(624, 11);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(92, 38);
            this.bttThem.TabIndex = 122;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Tổng Tiền";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.Aqua;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(770, 11);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(78, 36);
            this.bttThoat.TabIndex = 88;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(170, 11);
            this.txtThanhToan.Multiline = true;
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(147, 43);
            this.txtThanhToan.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(393, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Hóa Đơn Nhập";
            // 
            // grBCTHoaDon
            // 
            this.grBCTHoaDon.BackColor = System.Drawing.Color.White;
            this.grBCTHoaDon.Controls.Add(this.groupBox1);
            this.grBCTHoaDon.Controls.Add(this.combMaNV);
            this.grBCTHoaDon.Controls.Add(this.label5);
            this.grBCTHoaDon.Controls.Add(this.combKH);
            this.grBCTHoaDon.Controls.Add(this.lbquequan);
            this.grBCTHoaDon.Controls.Add(this.dateTimeNgayBan);
            this.grBCTHoaDon.Controls.Add(this.txtMaHD);
            this.grBCTHoaDon.Controls.Add(this.lbMaKH);
            this.grBCTHoaDon.Controls.Add(this.lbNgaysinh);
            this.grBCTHoaDon.Controls.Add(this.label2);
            this.grBCTHoaDon.Controls.Add(this.MaNV);
            this.grBCTHoaDon.Location = new System.Drawing.Point(12, 46);
            this.grBCTHoaDon.Name = "grBCTHoaDon";
            this.grBCTHoaDon.Size = new System.Drawing.Size(896, 131);
            this.grBCTHoaDon.TabIndex = 84;
            this.grBCTHoaDon.TabStop = false;
            this.grBCTHoaDon.Text = "Chi Tiết Hóa Đơn";
            // 
            // dateTimeNgayBan
            // 
            this.dateTimeNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBan.Location = new System.Drawing.Point(635, 63);
            this.dateTimeNgayBan.Name = "dateTimeNgayBan";
            this.dateTimeNgayBan.Size = new System.Drawing.Size(180, 20);
            this.dateTimeNgayBan.TabIndex = 90;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(112, 27);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(180, 20);
            this.txtMaHD.TabIndex = 85;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(493, 22);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(77, 13);
            this.lbMaKH.TabIndex = 84;
            this.lbMaKH.Text = "Nhà Cung Cấp";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(512, 69);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaysinh.TabIndex = 82;
            this.lbNgaysinh.Text = "Ngày Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(71, 69);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 79;
            // 
            // GUI_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBCTHoaDon);
            this.Name = "GUI_HoaDonNhap";
            this.Text = "GUI_HoaDonNhap";
    //        this.Load += new System.EventHandler(this.GUI_HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHDHang)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grBCTHoaDon.ResumeLayout(false);
            this.grBCTHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn txtthanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsoLuong1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmboMa;
        private System.Windows.Forms.DataGridView dtHDHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgiaBanRa;
        private System.Windows.Forms.Panel panel1;
        private QUAN_LY_KHODataSet1TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QUAN_LY_KHODataSet1TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QUAN_LY_KHODataSet1 qUAN_LY_KHODataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMaNV;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingSource qUANLYKHODataSetBindingSource;
        private QUAN_LY_KHODataSet qUAN_LY_KHODataSet;
        private QUAN_LY_KHODataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combKH;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttXemTT;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBCTHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaNV;
    }
}