namespace QuanLiThuVien.ADMIN
{
    partial class frmPhieuMuon
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
            this.dtngaytra = new System.Windows.Forms.GroupBox();
            this.dtpkNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbMaPM = new System.Windows.Forms.ComboBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvSachMuon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFindPM = new System.Windows.Forms.TextBox();
            this.lblthongbaosm = new System.Windows.Forms.Label();
            this.btnFindPM = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvPM = new System.Windows.Forms.DataGridView();
            this.dtngaytra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lí Sách Mượn";
            // 
            // dtngaytra
            // 
            this.dtngaytra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtngaytra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dtngaytra.Controls.Add(this.dtpkNgayTra);
            this.dtngaytra.Controls.Add(this.cbMaPM);
            this.dtngaytra.Controls.Add(this.cbMaSach);
            this.dtngaytra.Controls.Add(this.txtTinhTrang);
            this.dtngaytra.Controls.Add(this.label6);
            this.dtngaytra.Controls.Add(this.label3);
            this.dtngaytra.Controls.Add(this.txtSoLuong);
            this.dtngaytra.Controls.Add(this.label7);
            this.dtngaytra.Controls.Add(this.label2);
            this.dtngaytra.Controls.Add(this.label4);
            this.dtngaytra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaytra.Location = new System.Drawing.Point(41, 105);
            this.dtngaytra.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaytra.Name = "dtngaytra";
            this.dtngaytra.Padding = new System.Windows.Forms.Padding(4);
            this.dtngaytra.Size = new System.Drawing.Size(471, 274);
            this.dtngaytra.TabIndex = 26;
            this.dtngaytra.TabStop = false;
            this.dtngaytra.Text = "Thông Tin Sách Mượn";
            // 
            // dtpkNgayTra
            // 
            this.dtpkNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayTra.Location = new System.Drawing.Point(153, 208);
            this.dtpkNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNgayTra.Name = "dtpkNgayTra";
            this.dtpkNgayTra.Size = new System.Drawing.Size(265, 27);
            this.dtpkNgayTra.TabIndex = 7;
            // 
            // cbMaPM
            // 
            this.cbMaPM.FormattingEnabled = true;
            this.cbMaPM.Location = new System.Drawing.Point(153, 76);
            this.cbMaPM.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaPM.Name = "cbMaPM";
            this.cbMaPM.Size = new System.Drawing.Size(276, 28);
            this.cbMaPM.TabIndex = 6;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(153, 31);
            this.cbMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(276, 28);
            this.cbMaSach.TabIndex = 6;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(153, 118);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(184, 27);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "NgayTra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng SM";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(153, 162);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(184, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.dtgvSachMuon);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(758, 274);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu mượn";
            // 
            // dtgvSachMuon
            // 
            this.dtgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachMuon.Location = new System.Drawing.Point(8, 23);
            this.dtgvSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvSachMuon.Name = "dtgvSachMuon";
            this.dtgvSachMuon.RowHeadersWidth = 51;
            this.dtgvSachMuon.Size = new System.Drawing.Size(734, 233);
            this.dtgvSachMuon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.txtFindPM);
            this.groupBox3.Controls.Add(this.lblthongbaosm);
            this.groupBox3.Controls.Add(this.btnFindPM);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(41, 387);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(471, 252);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử Lý";
            // 
            // txtFindPM
            // 
            this.txtFindPM.Location = new System.Drawing.Point(211, 192);
            this.txtFindPM.Multiline = true;
            this.txtFindPM.Name = "txtFindPM";
            this.txtFindPM.Size = new System.Drawing.Size(218, 44);
            this.txtFindPM.TabIndex = 30;
            this.txtFindPM.TextChanged += new System.EventHandler(this.txtFindPM_TextChanged);
            // 
            // lblthongbaosm
            // 
            this.lblthongbaosm.AutoSize = true;
            this.lblthongbaosm.Location = new System.Drawing.Point(125, 36);
            this.lblthongbaosm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthongbaosm.Name = "lblthongbaosm";
            this.lblthongbaosm.Size = new System.Drawing.Size(0, 17);
            this.lblthongbaosm.TabIndex = 2;
            // 
            // btnFindPM
            // 
            this.btnFindPM.BackColor = System.Drawing.SystemColors.Control;
            this.btnFindPM.BackgroundImage = global::QuanLiThuVien.Properties.Resources.Start_Menu_Search_icon;
            this.btnFindPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFindPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindPM.Location = new System.Drawing.Point(7, 192);
            this.btnFindPM.Name = "btnFindPM";
            this.btnFindPM.Size = new System.Drawing.Size(159, 44);
            this.btnFindPM.TabIndex = 29;
            this.btnFindPM.Text = "Tìm Kiếm PM";
            this.btnFindPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindPM.UseVisualStyleBackColor = false;
            this.btnFindPM.Click += new System.EventHandler(this.btnFindPM_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImage = global::QuanLiThuVien.Properties.Resources.delete_icon__2_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(310, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.BackgroundImage = global::QuanLiThuVien.Properties.Resources.application_form_edit_icon;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(9, 112);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 44);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.BackgroundImage = global::QuanLiThuVien.Properties.Resources.application_form_delete_icon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(153, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.BackgroundImage = global::QuanLiThuVien.Properties.Resources.p1;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(153, 112);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 44);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Xuất ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.BackgroundImage = global::QuanLiThuVien.Properties.Resources.application_form_add_icon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(9, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dtgvPM);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(532, 388);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(758, 274);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu phiếu đã đăng kí";
            // 
            // dtgvPM
            // 
            this.dtgvPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPM.Location = new System.Drawing.Point(8, 23);
            this.dtgvPM.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPM.Name = "dtgvPM";
            this.dtgvPM.RowHeadersWidth = 51;
            this.dtgvPM.Size = new System.Drawing.Size(734, 233);
            this.dtgvPM.TabIndex = 0;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtngaytra);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuMuon";
            this.Text = "frmPhieuMuon";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.dtngaytra.ResumeLayout(false);
            this.dtngaytra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dtngaytra;
        private System.Windows.Forms.DateTimePicker dtpkNgayTra;
        private System.Windows.Forms.ComboBox cbMaPM;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvSachMuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblthongbaosm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvPM;
        private System.Windows.Forms.TextBox txtFindPM;
        private System.Windows.Forms.Button btnFindPM;
    }
}