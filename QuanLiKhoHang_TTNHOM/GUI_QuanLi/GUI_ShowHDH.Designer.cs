namespace GUI_QuanLi
{
    partial class GUI_ShowHDH
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
            this.dtGrid_HDBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bttThem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_HDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid_HDBan
            // 
            this.dtGrid_HDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_HDBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtGrid_HDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_HDBan.Location = new System.Drawing.Point(12, 109);
            this.dtGrid_HDBan.Name = "dtGrid_HDBan";
            this.dtGrid_HDBan.Size = new System.Drawing.Size(756, 322);
            this.dtGrid_HDBan.TabIndex = 111;
            this.dtGrid_HDBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_HDBan_CellClick);
            this.dtGrid_HDBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtHDBanss);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(368, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(249, 454);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(79, 45);
            this.bttThem.TabIndex = 121;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(405, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 43);
            this.button4.TabIndex = 124;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // GUI_ShowHDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.dtGrid_HDBan);
            this.Controls.Add(this.label1);
            this.Name = "GUI_ShowHDH";
            this.Text = "GUI_ShowHDH";
            this.Load += new System.EventHandler(this.GUI_ShowHDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_HDBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrid_HDBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button button4;
    }
}