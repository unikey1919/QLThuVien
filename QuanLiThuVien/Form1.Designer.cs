namespace QuanLiThuVien
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoAnLTWINDataSet = new QuanLiThuVien.DoAnLTWINDataSet();
            this.SACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SACHTableAdapter = new QuanLiThuVien.DoAnLTWINDataSetTableAdapters.SACHTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoAnLTWINDataSet1 = new QuanLiThuVien.DoAnLTWINDataSet1();
            this.THETHUVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THETHUVIENTableAdapter = new QuanLiThuVien.DoAnLTWINDataSet1TableAdapters.THETHUVIENTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoAnLTWINDataSet2 = new QuanLiThuVien.DoAnLTWINDataSet2();
            this.PHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUMUONTableAdapter = new QuanLiThuVien.DoAnLTWINDataSet2TableAdapters.PHIEUMUONTableAdapter();
            this.DoAnLTWINDataSet3 = new QuanLiThuVien.DoAnLTWINDataSet3();
            this.SACHTRATHANHCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SACHTRATHANHCONGTableAdapter = new QuanLiThuVien.DoAnLTWINDataSet3TableAdapters.SACHTRATHANHCONGTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THETHUVIENBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHTRATHANHCONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thẻ Thư Viện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SACHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiThuVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(977, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // DoAnLTWINDataSet
            // 
            this.DoAnLTWINDataSet.DataSetName = "DoAnLTWINDataSet";
            this.DoAnLTWINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SACHBindingSource
            // 
            this.SACHBindingSource.DataMember = "SACH";
            this.SACHBindingSource.DataSource = this.DoAnLTWINDataSet;
            // 
            // SACHTableAdapter
            // 
            this.SACHTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.THETHUVIENBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLiThuVien.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(977, 491);
            this.reportViewer2.TabIndex = 0;
            // 
            // DoAnLTWINDataSet1
            // 
            this.DoAnLTWINDataSet1.DataSetName = "DoAnLTWINDataSet1";
            this.DoAnLTWINDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THETHUVIENBindingSource
            // 
            this.THETHUVIENBindingSource.DataMember = "THETHUVIEN";
            this.THETHUVIENBindingSource.DataSource = this.DoAnLTWINDataSet1;
            // 
            // THETHUVIENTableAdapter
            // 
            this.THETHUVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phiếu Mượn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(983, 497);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dữ liệu đã trả";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PHIEUMUONBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QuanLiThuVien.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(983, 497);
            this.reportViewer3.TabIndex = 0;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.SACHTRATHANHCONGBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "QuanLiThuVien.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(983, 497);
            this.reportViewer4.TabIndex = 0;
            // 
            // DoAnLTWINDataSet2
            // 
            this.DoAnLTWINDataSet2.DataSetName = "DoAnLTWINDataSet2";
            this.DoAnLTWINDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PHIEUMUONBindingSource
            // 
            this.PHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.PHIEUMUONBindingSource.DataSource = this.DoAnLTWINDataSet2;
            // 
            // PHIEUMUONTableAdapter
            // 
            this.PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // DoAnLTWINDataSet3
            // 
            this.DoAnLTWINDataSet3.DataSetName = "DoAnLTWINDataSet3";
            this.DoAnLTWINDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SACHTRATHANHCONGBindingSource
            // 
            this.SACHTRATHANHCONGBindingSource.DataMember = "SACHTRATHANHCONG";
            this.SACHTRATHANHCONGBindingSource.DataSource = this.DoAnLTWINDataSet3;
            // 
            // SACHTRATHANHCONGTableAdapter
            // 
            this.SACHTRATHANHCONGTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THETHUVIENBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoAnLTWINDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHTRATHANHCONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource SACHBindingSource;
        private DoAnLTWINDataSet DoAnLTWINDataSet;
        private DoAnLTWINDataSetTableAdapters.SACHTableAdapter SACHTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource THETHUVIENBindingSource;
        private DoAnLTWINDataSet1 DoAnLTWINDataSet1;
        private DoAnLTWINDataSet1TableAdapters.THETHUVIENTableAdapter THETHUVIENTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource PHIEUMUONBindingSource;
        private DoAnLTWINDataSet2 DoAnLTWINDataSet2;
        private DoAnLTWINDataSet2TableAdapters.PHIEUMUONTableAdapter PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource SACHTRATHANHCONGBindingSource;
        private DoAnLTWINDataSet3 DoAnLTWINDataSet3;
        private DoAnLTWINDataSet3TableAdapters.SACHTRATHANHCONGTableAdapter SACHTRATHANHCONGTableAdapter;
    }
}