namespace GUI_QuanLi
{
    partial class NhaCungCap
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
            this.txbTK = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.dtGrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaNV = new System.Windows.Forms.Label();
            this.IbIDNhanVien = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbmaKhoHang = new System.Windows.Forms.Label();
            this.combMaHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_NhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(751, 181);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(192, 20);
            this.txbTK.TabIndex = 107;
            this.txbTK.TextChanged += new System.EventHandler(this.txbTK_TextChanged);
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
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(436, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbTK);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.bttSua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Location = new System.Drawing.Point(59, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 454);
            this.panel1.TabIndex = 56;
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(89, 68);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 74;
            // 
            // IbIDNhanVien
            // 
            this.IbIDNhanVien.AutoSize = true;
            this.IbIDNhanVien.Location = new System.Drawing.Point(23, 26);
            this.IbIDNhanVien.Name = "IbIDNhanVien";
            this.IbIDNhanVien.Size = new System.Drawing.Size(95, 13);
            this.IbIDNhanVien.TabIndex = 75;
            this.IbIDNhanVien.Text = "Mã Nhà Cung Cấp";
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.Location = new System.Drawing.Point(19, 75);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(102, 13);
            this.TenNV.TabIndex = 76;
            this.TenNV.Text = "Tên Nhà Cung  Cấp";
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(713, 37);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(41, 13);
            this.SDT.TabIndex = 80;
            this.SDT.Text = "Địa Chỉ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(131, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(145, 20);
            this.txtMaNV.TabIndex = 81;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(131, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(145, 20);
            this.txtTenNV.TabIndex = 82;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(777, 33);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 20);
            this.txtSDT.TabIndex = 85;
            // 
            // lbmaKhoHang
            // 
            this.lbmaKhoHang.AutoSize = true;
            this.lbmaKhoHang.Location = new System.Drawing.Point(698, 76);
            this.lbmaKhoHang.Name = "lbmaKhoHang";
            this.lbmaKhoHang.Size = new System.Drawing.Size(74, 13);
            this.lbmaKhoHang.TabIndex = 87;
            this.lbmaKhoHang.Text = "Mã Hàng Hóa";
            // 
            // combMaHang
            // 
            this.combMaHang.FormattingEnabled = true;
            this.combMaHang.Location = new System.Drawing.Point(777, 69);
            this.combMaHang.Name = "combMaHang";
            this.combMaHang.Size = new System.Drawing.Size(166, 21);
            this.combMaHang.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.combMaHang);
            this.groupBox1.Controls.Add(this.lbmaKhoHang);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.TenNV);
            this.groupBox1.Controls.Add(this.IbIDNhanVien);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 158);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_NhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dtGrid_NhanVien;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMaHang;
        private System.Windows.Forms.Label lbmaKhoHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Label IbIDNhanVien;
        private System.Windows.Forms.Label MaNV;
    }
}