namespace QuanLiThuVien
{
    partial class frmLibrary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANGESTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênChoMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tẠONHÓMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mƯỢNSÁCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRẢSÁCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHOMƯỢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINCÁNHÂNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.ptrImageUser = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvBook);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu Sách";
            // 
            // dtgvBook
            // 
            this.dtgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBook.Location = new System.Drawing.Point(6, 26);
            this.dtgvBook.Name = "dtgvBook";
            this.dtgvBook.RowHeadersWidth = 51;
            this.dtgvBook.RowTemplate.Height = 24;
            this.dtgvBook.Size = new System.Drawing.Size(1055, 316);
            this.dtgvBook.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Cứu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLiThuVien.Properties.Resources.Books_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vui lòng nhập dữ liệu, mã sách, tên sách, tình trạng, tên tác giả,năm xuất bản,th" +
    "ể loại để tìm kiếm thông tin sách";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.BackgroundImage = global::QuanLiThuVien.Properties.Resources.Start_Menu_Search_icon;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFind.Location = new System.Drawing.Point(739, 57);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 48);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm Kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(175, 65);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(538, 31);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(681, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(122, 23);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Xin Chào User:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.tHỐNGKÊToolStripMenuItem,
            this.sTUDENTToolStripMenuItem,
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANGESTUDENTToolStripMenuItem,
            this.quảnLíSinhViênToolStripMenuItem,
            this.quảnLíGiáoViênToolStripMenuItem,
            this.mANAGEBOOKToolStripMenuItem,
            this.tạoPhiếuMượnToolStripMenuItem,
            this.giáoViênChoMượnToolStripMenuItem,
            this.tẠONHÓMToolStripMenuItem});
            this.aDMINToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aDMINToolStripMenuItem.Image = global::QuanLiThuVien.Properties.Resources.admin_icon;
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            // 
            // mANGESTUDENTToolStripMenuItem
            // 
            this.mANGESTUDENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mANGESTUDENTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mANGESTUDENTToolStripMenuItem.Name = "mANGESTUDENTToolStripMenuItem";
            this.mANGESTUDENTToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.mANGESTUDENTToolStripMenuItem.Text = "Quản Lí User";
            this.mANGESTUDENTToolStripMenuItem.Click += new System.EventHandler(this.mANGESTUDENTToolStripMenuItem_Click);
            // 
            // quảnLíSinhViênToolStripMenuItem
            // 
            this.quảnLíSinhViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quảnLíSinhViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quảnLíSinhViênToolStripMenuItem.Name = "quảnLíSinhViênToolStripMenuItem";
            this.quảnLíSinhViênToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.quảnLíSinhViênToolStripMenuItem.Text = "Quản Lí Sinh Viên";
            this.quảnLíSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíSinhViênToolStripMenuItem_Click);
            // 
            // quảnLíGiáoViênToolStripMenuItem
            // 
            this.quảnLíGiáoViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quảnLíGiáoViênToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quảnLíGiáoViênToolStripMenuItem.Name = "quảnLíGiáoViênToolStripMenuItem";
            this.quảnLíGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.quảnLíGiáoViênToolStripMenuItem.Text = "Quản Lí Giáo Viên";
            this.quảnLíGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíGiáoViênToolStripMenuItem_Click);
            // 
            // mANAGEBOOKToolStripMenuItem
            // 
            this.mANAGEBOOKToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mANAGEBOOKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mANAGEBOOKToolStripMenuItem.Name = "mANAGEBOOKToolStripMenuItem";
            this.mANAGEBOOKToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.mANAGEBOOKToolStripMenuItem.Text = "Quản Lí Sách";
            this.mANAGEBOOKToolStripMenuItem.Click += new System.EventHandler(this.mANAGEBOOKToolStripMenuItem_Click);
            // 
            // tạoPhiếuMượnToolStripMenuItem
            // 
            this.tạoPhiếuMượnToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tạoPhiếuMượnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tạoPhiếuMượnToolStripMenuItem.Name = "tạoPhiếuMượnToolStripMenuItem";
            this.tạoPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.tạoPhiếuMượnToolStripMenuItem.Text = "Tạo Phiếu Mượn";
            this.tạoPhiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.tạoPhiếuMượnToolStripMenuItem_Click);
            // 
            // giáoViênChoMượnToolStripMenuItem
            // 
            this.giáoViênChoMượnToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.giáoViênChoMượnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.giáoViênChoMượnToolStripMenuItem.Name = "giáoViênChoMượnToolStripMenuItem";
            this.giáoViênChoMượnToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.giáoViênChoMượnToolStripMenuItem.Text = "Giáo Viên Cho Mượn";
            this.giáoViênChoMượnToolStripMenuItem.Click += new System.EventHandler(this.giáoViênChoMượnToolStripMenuItem_Click);
            // 
            // tẠONHÓMToolStripMenuItem
            // 
            this.tẠONHÓMToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tẠONHÓMToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tẠONHÓMToolStripMenuItem.Name = "tẠONHÓMToolStripMenuItem";
            this.tẠONHÓMToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.tẠONHÓMToolStripMenuItem.Text = "Tạo Nhóm";
            this.tẠONHÓMToolStripMenuItem.Click += new System.EventHandler(this.tẠONHÓMToolStripMenuItem_Click);
            // 
            // tHỐNGKÊToolStripMenuItem
            // 
            this.tHỐNGKÊToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tHỐNGKÊToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHỐNGKÊToolStripMenuItem1,
            this.dASHBOARDToolStripMenuItem,
            this.Report});
            this.tHỐNGKÊToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tHỐNGKÊToolStripMenuItem.Image = global::QuanLiThuVien.Properties.Resources.Bar_chart_icon;
            this.tHỐNGKÊToolStripMenuItem.Name = "tHỐNGKÊToolStripMenuItem";
            this.tHỐNGKÊToolStripMenuItem.Size = new System.Drawing.Size(130, 27);
            this.tHỐNGKÊToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // tHỐNGKÊToolStripMenuItem1
            // 
            this.tHỐNGKÊToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.tHỐNGKÊToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tHỐNGKÊToolStripMenuItem1.Name = "tHỐNGKÊToolStripMenuItem1";
            this.tHỐNGKÊToolStripMenuItem1.Size = new System.Drawing.Size(273, 28);
            this.tHỐNGKÊToolStripMenuItem1.Text = "THỐNG KÊ ĐẦU SÁCH";
            this.tHỐNGKÊToolStripMenuItem1.Click += new System.EventHandler(this.tHỐNGKÊToolStripMenuItem1_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.dASHBOARDToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.Report.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(273, 28);
            this.Report.Text = "REPORT";
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mƯỢNSÁCHToolStripMenuItem,
            this.tRẢSÁCHToolStripMenuItem,
            this.cHOMƯỢNToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sTUDENTToolStripMenuItem.Image = global::QuanLiThuVien.Properties.Resources.Books_icon;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(200, 27);
            this.sTUDENTToolStripMenuItem.Text = "MƯỢN - TRẢ SÁCH";
            // 
            // mƯỢNSÁCHToolStripMenuItem
            // 
            this.mƯỢNSÁCHToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mƯỢNSÁCHToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mƯỢNSÁCHToolStripMenuItem.Name = "mƯỢNSÁCHToolStripMenuItem";
            this.mƯỢNSÁCHToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.mƯỢNSÁCHToolStripMenuItem.Text = "MƯỢN SÁCH";
            this.mƯỢNSÁCHToolStripMenuItem.Click += new System.EventHandler(this.mƯỢNSÁCHToolStripMenuItem_Click);
            // 
            // tRẢSÁCHToolStripMenuItem
            // 
            this.tRẢSÁCHToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tRẢSÁCHToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tRẢSÁCHToolStripMenuItem.Name = "tRẢSÁCHToolStripMenuItem";
            this.tRẢSÁCHToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.tRẢSÁCHToolStripMenuItem.Text = "TRẢ SÁCH";
            this.tRẢSÁCHToolStripMenuItem.Click += new System.EventHandler(this.tRẢSÁCHToolStripMenuItem_Click);
            // 
            // cHOMƯỢNToolStripMenuItem
            // 
            this.cHOMƯỢNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cHOMƯỢNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cHOMƯỢNToolStripMenuItem.Name = "cHOMƯỢNToolStripMenuItem";
            this.cHOMƯỢNToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.cHOMƯỢNToolStripMenuItem.Text = "CHO THƯ VIỆN MƯỢN";
            this.cHOMƯỢNToolStripMenuItem.Click += new System.EventHandler(this.cHOMƯỢNToolStripMenuItem_Click_1);
            // 
            // tHÔNGTINTÀIKHOẢNToolStripMenuItem
            // 
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHÔNGTINCÁNHÂNToolStripMenuItem,
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem});
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.Image = global::QuanLiThuVien.Properties.Resources.Keys_icon;
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.Name = "tHÔNGTINTÀIKHOẢNToolStripMenuItem";
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.tHÔNGTINTÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // tHÔNGTINCÁNHÂNToolStripMenuItem
            // 
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Name = "tHÔNGTINCÁNHÂNToolStripMenuItem";
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Text = "THÔNG TIN ";
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Click += new System.EventHandler(this.tHÔNGTINCÁNHÂNToolStripMenuItem_Click);
            // 
            // tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem
            // 
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.Name = "tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem";
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.Text = "THAY ĐỔI ";
            this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem.Click += new System.EventHandler(this.tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(809, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 22);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Xin Chào:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.BackgroundImage = global::QuanLiThuVien.Properties.Resources.Log_Out_icon__1_;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Location = new System.Drawing.Point(210, 53);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(161, 52);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Đăng Suất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTra.BackgroundImage = global::QuanLiThuVien.Properties.Resources.rules_icon;
            this.btnTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTra.Location = new System.Drawing.Point(19, 53);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(166, 52);
            this.btnTra.TabIndex = 8;
            this.btnTra.Text = "Sách đã trả";
            this.btnTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // ptrImageUser
            // 
            this.ptrImageUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ptrImageUser.Location = new System.Drawing.Point(908, 0);
            this.ptrImageUser.Name = "ptrImageUser";
            this.ptrImageUser.Size = new System.Drawing.Size(166, 105);
            this.ptrImageUser.TabIndex = 6;
            this.ptrImageUser.TabStop = false;
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.ptrImageUser);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvBook;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox ptrImageUser;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANGESTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáoViênChoMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tẠONHÓMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mƯỢNSÁCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRẢSÁCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHOMƯỢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINTÀIKHOẢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINCÁNHÂNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Report;
    }
}