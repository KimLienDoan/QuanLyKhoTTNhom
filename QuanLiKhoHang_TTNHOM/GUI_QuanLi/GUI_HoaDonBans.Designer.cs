namespace GUI_QuanLi
{
    partial class GUI_HoaDonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttThongTin = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.bttThoat = new System.Windows.Forms.Button();
            this.grBCTHoaDon = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combMaNV = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_KHODataSet1 = new GUI_QuanLi.QUAN_LY_KHODataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.combKH = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_KHODataSet = new GUI_QuanLi.QUAN_LY_KHODataSet();
            this.lbquequan = new System.Windows.Forms.Label();
            this.dateTimeNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.khachHangTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSetTableAdapters.KhachHangTableAdapter();
            this.qUANLYKHODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSet1TableAdapters.LoaiHangTableAdapter();
            this.hangHoaTableAdapter = new GUI_QuanLi.QUAN_LY_KHODataSet1TableAdapters.HangHoaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtHDHang = new System.Windows.Forms.DataGridView();
            this.cmboMa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtsoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgiaBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtthanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTHD = new System.Windows.Forms.GroupBox();
            this.dtgrHDH = new System.Windows.Forms.DataGridView();
            this.bttHD = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.grBCTHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHDHang)).BeginInit();
            this.TTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(399, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.bttThongTin);
            this.panel2.Controls.Add(this.bttThem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtThanhToan);
            this.panel2.Location = new System.Drawing.Point(381, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 60);
            this.panel2.TabIndex = 82;
            // 
            // bttThongTin
            // 
            this.bttThongTin.BackColor = System.Drawing.Color.Silver;
            this.bttThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThongTin.Location = new System.Drawing.Point(412, 7);
            this.bttThongTin.Name = "bttThongTin";
            this.bttThongTin.Size = new System.Drawing.Size(98, 50);
            this.bttThongTin.TabIndex = 123;
            this.bttThongTin.Text = "Thông Tin";
            this.bttThongTin.UseVisualStyleBackColor = false;
            this.bttThongTin.Click += new System.EventHandler(this.bttThongTin_Click);
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.Color.Silver;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(516, 7);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(94, 50);
            this.bttThem.TabIndex = 122;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
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
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(133, 10);
            this.txtThanhToan.Multiline = true;
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(147, 43);
            this.txtThanhToan.TabIndex = 87;
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.Silver;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(897, 566);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(78, 68);
            this.bttThoat.TabIndex = 88;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // grBCTHoaDon
            // 
            this.grBCTHoaDon.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.grBCTHoaDon.ForeColor = System.Drawing.Color.Black;
            this.grBCTHoaDon.Location = new System.Drawing.Point(12, 65);
            this.grBCTHoaDon.Name = "grBCTHoaDon";
            this.grBCTHoaDon.Size = new System.Drawing.Size(363, 313);
            this.grBCTHoaDon.TabIndex = 79;
            this.grBCTHoaDon.TabStop = false;
            this.grBCTHoaDon.Text = "Chi Tiết Hóa Đơn";
            this.grBCTHoaDon.Enter += new System.EventHandler(this.grBCTHoaDon_Enter);
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
            this.combMaNV.Location = new System.Drawing.Point(112, 97);
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
            // qUAN_LY_KHODataSet1
            // 
            this.qUAN_LY_KHODataSet1.DataSetName = "QUAN_LY_KHODataSet1";
            this.qUAN_LY_KHODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.combKH.Location = new System.Drawing.Point(112, 148);
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
            // qUAN_LY_KHODataSet
            // 
            this.qUAN_LY_KHODataSet.DataSetName = "QUAN_LY_KHODataSet";
            this.qUAN_LY_KHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Location = new System.Drawing.Point(21, 105);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(57, 13);
            this.lbquequan.TabIndex = 83;
            this.lbquequan.Text = "Nhân Viên";
            // 
            // dateTimeNgayBan
            // 
            this.dateTimeNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBan.Location = new System.Drawing.Point(112, 203);
            this.dateTimeNgayBan.Name = "dateTimeNgayBan";
            this.dateTimeNgayBan.Size = new System.Drawing.Size(180, 20);
            this.dateTimeNgayBan.TabIndex = 90;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(112, 39);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(180, 20);
            this.txtMaHD.TabIndex = 85;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.ForeColor = System.Drawing.Color.Black;
            this.lbMaKH.Location = new System.Drawing.Point(14, 156);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(64, 13);
            this.lbMaKH.TabIndex = 84;
            this.lbMaKH.Text = "KháchHàng";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(14, 210);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaysinh.TabIndex = 82;
            this.lbNgaysinh.Text = "Ngày Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
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
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLYKHODataSetBindingSource
            // 
            this.qUANLYKHODataSetBindingSource.DataSource = this.qUAN_LY_KHODataSet;
            this.qUANLYKHODataSetBindingSource.Position = 0;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.qUAN_LY_KHODataSet1;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtHDHang);
            this.panel1.Location = new System.Drawing.Point(381, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 250);
            this.panel1.TabIndex = 81;
            // 
            // dtHDHang
            // 
            this.dtHDHang.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtHDHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHDHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmboMa,
            this.txtsoLuong1,
            this.txtgiaBanRa,
            this.txtthanhTien});
            this.dtHDHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHDHang.Location = new System.Drawing.Point(0, 0);
            this.dtHDHang.Name = "dtHDHang";
            this.dtHDHang.Size = new System.Drawing.Size(647, 250);
            this.dtHDHang.TabIndex = 0;
            this.dtHDHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCTHH_CellCLlick);
            this.dtHDHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHDHang_CellContentClick);
            this.dtHDHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHDHang_CellValueChanged);
            // 
            // cmboMa
            // 
            this.cmboMa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmboMa.DataPropertyName = "maHangHoa";
            this.cmboMa.HeaderText = "Mã Hàng";
            this.cmboMa.Name = "cmboMa";
            // 
            // txtsoLuong1
            // 
            this.txtsoLuong1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtsoLuong1.DataPropertyName = "soLuong";
            this.txtsoLuong1.HeaderText = "Số Lượng";
            this.txtsoLuong1.Name = "txtsoLuong1";
            // 
            // txtgiaBanRa
            // 
            this.txtgiaBanRa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtgiaBanRa.DataPropertyName = "GiaBanRa";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.txtgiaBanRa.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtgiaBanRa.HeaderText = "Đơn Giá Bán";
            this.txtgiaBanRa.Name = "txtgiaBanRa";
            // 
            // txtthanhTien
            // 
            this.txtthanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtthanhTien.DataPropertyName = "thanhTien";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.txtthanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtthanhTien.HeaderText = "Thành Tiền";
            this.txtthanhTien.Name = "txtthanhTien";
            this.txtthanhTien.ReadOnly = true;
            // 
            // TTHD
            // 
            this.TTHD.Controls.Add(this.dtgrHDH);
            this.TTHD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTHD.Location = new System.Drawing.Point(12, 398);
            this.TTHD.Name = "TTHD";
            this.TTHD.Size = new System.Drawing.Size(841, 313);
            this.TTHD.TabIndex = 89;
            this.TTHD.TabStop = false;
            this.TTHD.Text = "Thông Tin Hóa Đơn";
            // 
            // dtgrHDH
            // 
            this.dtgrHDH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrHDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrHDH.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgrHDH.Location = new System.Drawing.Point(3, 25);
            this.dtgrHDH.Name = "dtgrHDH";
            this.dtgrHDH.Size = new System.Drawing.Size(835, 285);
            this.dtgrHDH.TabIndex = 0;
            // 
            // bttHD
            // 
            this.bttHD.BackColor = System.Drawing.Color.Silver;
            this.bttHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHD.Location = new System.Drawing.Point(897, 423);
            this.bttHD.Name = "bttHD";
            this.bttHD.Size = new System.Drawing.Size(78, 68);
            this.bttHD.TabIndex = 90;
            this.bttHD.Text = "Danh Sách";
            this.bttHD.UseVisualStyleBackColor = false;
            this.bttHD.Click += new System.EventHandler(this.bttHD_Click);
            // 
            // GUI_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1027, 749);
            this.Controls.Add(this.bttHD);
            this.Controls.Add(this.TTHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.grBCTHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "GUI_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_HoaDonBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grBCTHoaDon.ResumeLayout(false);
            this.grBCTHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHDHang)).EndInit();
            this.TTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.GroupBox grBCTHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combKH;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaNV;
        private QUAN_LY_KHODataSet qUAN_LY_KHODataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QUAN_LY_KHODataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource qUANLYKHODataSetBindingSource;
        private QUAN_LY_KHODataSet1 qUAN_LY_KHODataSet1;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QUAN_LY_KHODataSet1TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QUAN_LY_KHODataSet1TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtHDHang;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmboMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgiaBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtthanhTien;
        private System.Windows.Forms.Button bttThongTin;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.GroupBox TTHD;
        private System.Windows.Forms.DataGridView dtgrHDH;
        private System.Windows.Forms.Button bttHD;
    }
}