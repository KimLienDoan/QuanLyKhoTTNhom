namespace GUI_QuanLi
{
    partial class GUI_KhachHang
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGrid_KhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtGtinh = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.lbquequan = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.txbTKKH = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_KhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbTKKH);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.bttSua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 496);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 111;
            this.label8.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGrid_KhachHang);
            this.groupBox2.Location = new System.Drawing.Point(2, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 282);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Khách Hàng";
            // 
            // dtGrid_KhachHang
            // 
            this.dtGrid_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtGrid_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_KhachHang.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtGrid_KhachHang.Location = new System.Drawing.Point(3, 16);
            this.dtGrid_KhachHang.Name = "dtGrid_KhachHang";
            this.dtGrid_KhachHang.Size = new System.Drawing.Size(1039, 263);
            this.dtGrid_KhachHang.TabIndex = 50;
            this.dtGrid_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_KhachHang_CellClick);
            this.dtGrid_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_KhachHang_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.dateTimeNgaysinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtGtinh);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.lbquequan);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 136);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(465, 82);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNgaysinh.TabIndex = 65;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(827, 88);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(194, 20);
            this.txtSDT.TabIndex = 64;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(827, 26);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(194, 20);
            this.txtQueQuan.TabIndex = 63;
            // 
            // txtGtinh
            // 
            this.txtGtinh.Location = new System.Drawing.Point(465, 33);
            this.txtGtinh.Name = "txtGtinh";
            this.txtGtinh.Size = new System.Drawing.Size(194, 20);
            this.txtGtinh.TabIndex = 62;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(123, 88);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(194, 20);
            this.txtTenKH.TabIndex = 61;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(123, 30);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(194, 20);
            this.txtMaKH.TabIndex = 60;
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(753, 88);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(29, 13);
            this.SDT.TabIndex = 59;
            this.SDT.Text = "SĐT";
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Location = new System.Drawing.Point(735, 40);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(56, 13);
            this.lbquequan.TabIndex = 58;
            this.lbquequan.Text = "Quê Quán";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(401, 88);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(56, 13);
            this.lbNgaysinh.TabIndex = 57;
            this.lbNgaysinh.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(81, 135);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 53;
            // 
            // txbTKKH
            // 
            this.txbTKKH.Location = new System.Drawing.Point(831, 176);
            this.txbTKKH.Name = "txbTKKH";
            this.txbTKKH.Size = new System.Drawing.Size(192, 20);
            this.txbTKKH.TabIndex = 85;
            this.txbTKKH.TextChanged += new System.EventHandler(this.txbTKKH_TextChanged);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(502, 162);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 46);
            this.btExit.TabIndex = 83;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(375, 162);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(79, 45);
            this.btXoa.TabIndex = 82;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(235, 162);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(75, 46);
            this.bttSua.TabIndex = 81;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click_1);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Black;
            this.btthem.Location = new System.Drawing.Point(107, 162);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 46);
            this.btthem.TabIndex = 80;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click_1);
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1055, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_KhachHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_KhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtGtinh;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.TextBox txbTKKH;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtGrid_KhachHang;
    }
}

