namespace QuanLiThuVien.STATUS
{
    partial class frmThongKeUser
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtChucVu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // crtUser
            // 
            this.crtUser.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.crtUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtUser.Legends.Add(legend1);
            this.crtUser.Location = new System.Drawing.Point(19, 180);
            this.crtUser.Name = "crtUser";
            this.crtUser.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.crtUser.Series.Add(series1);
            this.crtUser.Size = new System.Drawing.Size(420, 350);
            this.crtUser.TabIndex = 1;
            this.crtUser.Text = "chart1";
            // 
            // crtChucVu
            // 
            this.crtChucVu.BackColor = System.Drawing.Color.MistyRose;
            chartArea2.Name = "ChartArea1";
            this.crtChucVu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtChucVu.Legends.Add(legend2);
            this.crtChucVu.Location = new System.Drawing.Point(534, 180);
            this.crtChucVu.Name = "crtChucVu";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBorderWidth = 3;
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng User";
            this.crtChucVu.Series.Add(series2);
            this.crtChucVu.Size = new System.Drawing.Size(623, 350);
            this.crtChucVu.TabIndex = 1;
            this.crtChucVu.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê theo User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Biểu Đồ User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biểu Đồ Lượng Chức Vụ";
            // 
            // frmThongKeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtChucVu);
            this.Controls.Add(this.crtUser);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKeUser";
            ((System.ComponentModel.ISupportInitialize)(this.crtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtUser;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}