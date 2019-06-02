namespace GUI_QuanLi
{
    partial class GUI_NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combMaKho = new System.Windows.Forms.ComboBox();
            this.lbmaKhoHang = new System.Windows.Forms.Label();
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtGtinh = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.lbquequan = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.Label();
            this.IbIDNhanVien = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.bttSua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Location = new System.Drawing.Point(1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 454);
            this.panel1.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 46);
            this.button1.TabIndex = 110;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(497, 172);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 46);
            this.btExit.TabIndex = 106;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGrid_NhanVien);
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 235);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Nhân Viên";
            // 
            // dtGrid_NhanVien
            // 
            this.dtGrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_NhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtGrid_NhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_NhanVien.Location = new System.Drawing.Point(3, 16);
            this.dtGrid_NhanVien.Name = "dtGrid_NhanVien";
            this.dtGrid_NhanVien.Size = new System.Drawing.Size(956, 216);
            this.dtGrid_NhanVien.TabIndex = 69;
            this.dtGrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_NhanVien_CellClick);
            this.dtGrid_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_NhanVien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.combMaKho);
            this.groupBox1.Controls.Add(this.lbmaKhoHang);
            this.groupBox1.Controls.Add(this.dateTimeNgaysinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtGtinh);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.lbquequan);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.lbgioitinh);
            this.groupBox1.Controls.Add(this.TenNV);
            this.groupBox1.Controls.Add(this.IbIDNhanVien);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 158);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // combMaKho
            // 
            this.combMaKho.FormattingEnabled = true;
            this.combMaKho.Location = new System.Drawing.Point(777, 69);
            this.combMaKho.Name = "combMaKho";
            this.combMaKho.Size = new System.Drawing.Size(166, 21);
            this.combMaKho.TabIndex = 88;
            // 
            // lbmaKhoHang
            // 
            this.lbmaKhoHang.AutoSize = true;
            this.lbmaKhoHang.Location = new System.Drawing.Point(698, 76);
            this.lbmaKhoHang.Name = "lbmaKhoHang";
            this.lbmaKhoHang.Size = new System.Drawing.Size(73, 13);
            this.lbmaKhoHang.TabIndex = 87;
            this.lbmaKhoHang.Text = "Mã Kho Hàng";
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(430, 30);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(198, 20);
            this.dateTimeNgaysinh.TabIndex = 86;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(777, 33);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 20);
            this.txtSDT.TabIndex = 85;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress_1);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(430, 76);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(198, 20);
            this.txtQueQuan.TabIndex = 84;
            // 
            // txtGtinh
            // 
            this.txtGtinh.Location = new System.Drawing.Point(131, 112);
            this.txtGtinh.Name = "txtGtinh";
            this.txtGtinh.Size = new System.Drawing.Size(145, 20);
            this.txtGtinh.TabIndex = 83;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(131, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(145, 20);
            this.txtTenNV.TabIndex = 82;
            this.txtTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNV_KeyPress_1);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(145, 20);
            this.txtMaNV.TabIndex = 81;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress_1);
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(713, 37);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(29, 13);
            this.SDT.TabIndex = 80;
            this.SDT.Text = "SĐT";
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Location = new System.Drawing.Point(341, 76);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(56, 13);
            this.lbquequan.TabIndex = 79;
            this.lbquequan.Text = "Quê Quán";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(341, 33);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(56, 13);
            this.lbNgaysinh.TabIndex = 78;
            this.lbNgaysinh.Text = "Ngày Sinh";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(23, 119);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(51, 13);
            this.lbgioitinh.TabIndex = 77;
            this.lbgioitinh.Text = "Giới Tính";
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.Location = new System.Drawing.Point(19, 75);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(79, 13);
            this.TenNV.TabIndex = 76;
            this.TenNV.Text = "Tên Nhân Viên";
            // 
            // IbIDNhanVien
            // 
            this.IbIDNhanVien.AutoSize = true;
            this.IbIDNhanVien.Location = new System.Drawing.Point(23, 26);
            this.IbIDNhanVien.Name = "IbIDNhanVien";
            this.IbIDNhanVien.Size = new System.Drawing.Size(75, 13);
            this.IbIDNhanVien.TabIndex = 75;
            this.IbIDNhanVien.Text = "Mã Nhân Viên";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(89, 68);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 74;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(751, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 107;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(372, 172);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(64, 46);
            this.btXoa.TabIndex = 105;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(248, 172);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(73, 43);
            this.bttSua.TabIndex = 104;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click_1);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(131, 172);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(64, 43);
            this.btthem.TabIndex = 103;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // GUI_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(968, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_NhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGrid_NhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMaKho;
        private System.Windows.Forms.Label lbmaKhoHang;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtGtinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Label IbIDNhanVien;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button button1;
    }
}