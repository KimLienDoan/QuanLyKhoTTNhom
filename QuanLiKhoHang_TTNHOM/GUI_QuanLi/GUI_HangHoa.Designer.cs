namespace GUI_QuanLi
{
    partial class GUI_HangHoa
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
            this.btXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combMaKhoHang = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtGiaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHHoa = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGrid_HangHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labMaHang = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_HangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.Location = new System.Drawing.Point(411, 201);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 46);
            this.btXoa.TabIndex = 107;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(254, 201);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(79, 46);
            this.bttSua.TabIndex = 106;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(104, 201);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 46);
            this.btthem.TabIndex = 105;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(823, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 110;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 109;
            this.label8.Text = "Tìm Kiếm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // combMaKhoHang
            // 
            this.combMaKhoHang.FormattingEnabled = true;
            this.combMaKhoHang.Location = new System.Drawing.Point(834, 30);
            this.combMaKhoHang.Name = "combMaKhoHang";
            this.combMaKhoHang.Size = new System.Drawing.Size(180, 21);
            this.combMaKhoHang.TabIndex = 97;
            this.combMaKhoHang.SelectedIndexChanged += new System.EventHandler(this.combMaKhoHang_SelectedIndexChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(834, 72);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(180, 20);
            this.txtGiaBan.TabIndex = 96;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Mã Loại Hàng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(834, 113);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(180, 20);
            this.txtMoTa.TabIndex = 79;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Giá Bán Ra";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Mô Tả";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(496, 113);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(203, 20);
            this.txtDVT.TabIndex = 93;
            this.txtDVT.TextChanged += new System.EventHandler(this.txtDVT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "DVT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DTimeNgaysinh
            // 
            this.DTimeNgaysinh.Location = new System.Drawing.Point(496, 33);
            this.DTimeNgaysinh.Name = "DTimeNgaysinh";
            this.DTimeNgaysinh.Size = new System.Drawing.Size(203, 20);
            this.DTimeNgaysinh.TabIndex = 91;
            this.DTimeNgaysinh.ValueChanged += new System.EventHandler(this.DTimeNgaysinh_ValueChanged);
            // 
            // txtGiaHang
            // 
            this.txtGiaHang.Location = new System.Drawing.Point(103, 100);
            this.txtGiaHang.Name = "txtGiaHang";
            this.txtGiaHang.Size = new System.Drawing.Size(203, 20);
            this.txtGiaHang.TabIndex = 90;
            this.txtGiaHang.TextChanged += new System.EventHandler(this.txtGiaHang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(474, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Hàng Hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(496, 72);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(203, 20);
            this.txtSoLuong.TabIndex = 88;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(103, 68);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(203, 20);
            this.txtTenHH.TabIndex = 87;
            this.txtTenHH.TextChanged += new System.EventHandler(this.txtTenHH_TextChanged);
            // 
            // txtMaHHoa
            // 
            this.txtMaHHoa.Location = new System.Drawing.Point(103, 29);
            this.txtMaHHoa.Name = "txtMaHHoa";
            this.txtMaHHoa.Size = new System.Drawing.Size(203, 20);
            this.txtMaHHoa.TabIndex = 86;
            this.txtMaHHoa.TextChanged += new System.EventHandler(this.txtMaHHoa_TextChanged);
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(7, 100);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(75, 13);
            this.SDT.TabIndex = 85;
            this.SDT.Text = "Giá Hàng Hóa";
            this.SDT.Click += new System.EventHandler(this.SDT_Click);
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(407, 36);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(49, 13);
            this.lbNgaysinh.TabIndex = 83;
            this.lbNgaysinh.Text = "Ngày SX";
            this.lbNgaysinh.Click += new System.EventHandler(this.lbNgaysinh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.bttSua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(4, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 476);
            this.panel1.TabIndex = 56;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(543, 203);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 46);
            this.btExit.TabIndex = 112;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGrid_HangHoa);
            this.groupBox2.Location = new System.Drawing.Point(1, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 229);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hàng Hóa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtGrid_HangHoa
            // 
            this.dtGrid_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_HangHoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtGrid_HangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_HangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_HangHoa.Location = new System.Drawing.Point(3, 16);
            this.dtGrid_HangHoa.Name = "dtGrid_HangHoa";
            this.dtGrid_HangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_HangHoa.Size = new System.Drawing.Size(1034, 210);
            this.dtGrid_HangHoa.TabIndex = 69;
            this.dtGrid_HangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_HangHoa_CellClick);
            this.dtGrid_HangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_HangHoa_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.combMaKhoHang);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTimeNgaysinh);
            this.groupBox1.Controls.Add(this.txtGiaHang);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.txtMaHHoa);
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labMaHang);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 192);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hàng Hóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Số Lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tên Hàng ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labMaHang
            // 
            this.labMaHang.AutoSize = true;
            this.labMaHang.Location = new System.Drawing.Point(18, 32);
            this.labMaHang.Name = "labMaHang";
            this.labMaHang.Size = new System.Drawing.Size(54, 13);
            this.labMaHang.TabIndex = 80;
            this.labMaHang.Text = "Mã Hàng ";
            this.labMaHang.Click += new System.EventHandler(this.labMaHang_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(105, 103);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 79;
            this.MaNV.Click += new System.EventHandler(this.MaNV_Click);
            // 
            // GUI_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "GUI_HangHoa";
            this.Text = "GUI_HangHoa";
            this.Load += new System.EventHandler(this.GUI_HangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_HangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combMaKhoHang;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTimeNgaysinh;
        private System.Windows.Forms.TextBox txtGiaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHHoa;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGrid_HangHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labMaHang;
        private System.Windows.Forms.Label MaNV;
    }
}