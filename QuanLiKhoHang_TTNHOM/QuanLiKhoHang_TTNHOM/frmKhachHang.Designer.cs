namespace QuanLiKhoHang_TTNHOM
{
    partial class frmKhachHang
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.btXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGtinh = new System.Windows.Forms.TextBox();
            this.textTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.lbquequan = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colmaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_maKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang_sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(429, 182);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 67;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.Location = new System.Drawing.Point(304, 182);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(75, 23);
            this.bttSua.TabIndex = 66;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(184, 182);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 65;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(549, 135);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(122, 21);
            this.txtSDT.TabIndex = 64;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(549, 92);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(122, 21);
            this.txtQueQuan.TabIndex = 63;
            this.txtQueQuan.TextChanged += new System.EventHandler(this.txtQueQuan_TextChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(549, 57);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(122, 21);
            this.txtNgaySinh.TabIndex = 62;
            this.txtNgaySinh.TextChanged += new System.EventHandler(this.txtNgaySinh_TextChanged);
            // 
            // txtGtinh
            // 
            this.txtGtinh.Location = new System.Drawing.Point(184, 134);
            this.txtGtinh.Name = "txtGtinh";
            this.txtGtinh.Size = new System.Drawing.Size(130, 21);
            this.txtGtinh.TabIndex = 61;
            this.txtGtinh.TextChanged += new System.EventHandler(this.txtGtinh_TextChanged);
            // 
            // textTenKH
            // 
            this.textTenKH.Location = new System.Drawing.Point(184, 92);
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.Size = new System.Drawing.Size(130, 21);
            this.textTenKH.TabIndex = 60;
            this.textTenKH.TextChanged += new System.EventHandler(this.textTenKH_TextChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(184, 57);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(130, 21);
            this.txtMaKH.TabIndex = 59;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(449, 137);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(27, 13);
            this.SDT.TabIndex = 58;
            this.SDT.Text = "SĐT";
            this.SDT.Click += new System.EventHandler(this.SDT_Click);
            // 
            // lbquequan
            // 
            this.lbquequan.AutoSize = true;
            this.lbquequan.Location = new System.Drawing.Point(449, 95);
            this.lbquequan.Name = "lbquequan";
            this.lbquequan.Size = new System.Drawing.Size(56, 13);
            this.lbquequan.TabIndex = 57;
            this.lbquequan.Text = "Quê Quán";
            this.lbquequan.Click += new System.EventHandler(this.lbquequan_Click);
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(449, 60);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(55, 13);
            this.lbNgaysinh.TabIndex = 56;
            this.lbNgaysinh.Text = "Ngày Sinh";
            this.lbNgaysinh.Click += new System.EventHandler(this.lbNgaysinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Giới Tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tên Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã Khách Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(71, 92);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(0, 13);
            this.MaNV.TabIndex = 52;
            this.MaNV.Click += new System.EventHandler(this.MaNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(299, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "KhachHang";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(6, 223);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(730, 283);
            this.gridControl1.TabIndex = 68;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaKhachHang,
            this.colhoTen,
            this.colngaySinh,
            this.colgioiTinh,
            this.coldiaChi,
            this.colsdt,
            this.colKhachHang_maKhachHang,
            this.colKhachHang_hoTen,
            this.colKhachHang_ngaySinh,
            this.colKhachHang_gioiTinh,
            this.colKhachHang_diaChi,
            this.colKhachHang_sdt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "desktop-52rafdj\\sqlexpress.ChuanTTCSDL.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "maKhachHang";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"172\" />";
            table1.Name = "KhachHang";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "hoTen";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ngaySinh";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "gioiTinh";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "diaChi";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "sdt";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "KhachHang";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colmaKhachHang
            // 
            this.colmaKhachHang.FieldName = "maKhachHang";
            this.colmaKhachHang.Name = "colmaKhachHang";
            this.colmaKhachHang.Visible = true;
            this.colmaKhachHang.VisibleIndex = 0;
            // 
            // colhoTen
            // 
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 1;
            // 
            // colngaySinh
            // 
            this.colngaySinh.FieldName = "ngaySinh";
            this.colngaySinh.Name = "colngaySinh";
            this.colngaySinh.Visible = true;
            this.colngaySinh.VisibleIndex = 2;
            // 
            // colgioiTinh
            // 
            this.colgioiTinh.FieldName = "gioiTinh";
            this.colgioiTinh.Name = "colgioiTinh";
            this.colgioiTinh.Visible = true;
            this.colgioiTinh.VisibleIndex = 3;
            // 
            // coldiaChi
            // 
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 4;
            // 
            // colsdt
            // 
            this.colsdt.FieldName = "sdt";
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 5;
            // 
            // colKhachHang_maKhachHang
            // 
            this.colKhachHang_maKhachHang.FieldName = "KhachHang_maKhachHang";
            this.colKhachHang_maKhachHang.Name = "colKhachHang_maKhachHang";
            this.colKhachHang_maKhachHang.Visible = true;
            this.colKhachHang_maKhachHang.VisibleIndex = 6;
            // 
            // colKhachHang_hoTen
            // 
            this.colKhachHang_hoTen.FieldName = "KhachHang_hoTen";
            this.colKhachHang_hoTen.Name = "colKhachHang_hoTen";
            this.colKhachHang_hoTen.Visible = true;
            this.colKhachHang_hoTen.VisibleIndex = 7;
            // 
            // colKhachHang_ngaySinh
            // 
            this.colKhachHang_ngaySinh.FieldName = "KhachHang_ngaySinh";
            this.colKhachHang_ngaySinh.Name = "colKhachHang_ngaySinh";
            this.colKhachHang_ngaySinh.Visible = true;
            this.colKhachHang_ngaySinh.VisibleIndex = 8;
            // 
            // colKhachHang_gioiTinh
            // 
            this.colKhachHang_gioiTinh.FieldName = "KhachHang_gioiTinh";
            this.colKhachHang_gioiTinh.Name = "colKhachHang_gioiTinh";
            this.colKhachHang_gioiTinh.Visible = true;
            this.colKhachHang_gioiTinh.VisibleIndex = 9;
            // 
            // colKhachHang_diaChi
            // 
            this.colKhachHang_diaChi.FieldName = "KhachHang_diaChi";
            this.colKhachHang_diaChi.Name = "colKhachHang_diaChi";
            this.colKhachHang_diaChi.Visible = true;
            this.colKhachHang_diaChi.VisibleIndex = 10;
            // 
            // colKhachHang_sdt
            // 
            this.colKhachHang_sdt.FieldName = "KhachHang_sdt";
            this.colKhachHang_sdt.Name = "colKhachHang_sdt";
            this.colKhachHang_sdt.Visible = true;
            this.colKhachHang_sdt.VisibleIndex = 11;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 518);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtGtinh);
            this.Controls.Add(this.textTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.lbquequan);
            this.Controls.Add(this.lbNgaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGtinh;
        private System.Windows.Forms.TextBox textTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label lbquequan;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colgioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_maKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_hoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_ngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang_sdt;
    }
}