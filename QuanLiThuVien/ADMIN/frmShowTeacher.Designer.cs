namespace QuanLiThuVien.ADMIN
{
    partial class frmShowTeacher
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
            this.dtgvTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Giáo Viên";
            // 
            // dtgvTeacher
            // 
            this.dtgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTeacher.Location = new System.Drawing.Point(8, 95);
            this.dtgvTeacher.Name = "dtgvTeacher";
            this.dtgvTeacher.RowHeadersWidth = 51;
            this.dtgvTeacher.RowTemplate.Height = 24;
            this.dtgvTeacher.Size = new System.Drawing.Size(1006, 288);
            this.dtgvTeacher.TabIndex = 4;
            this.dtgvTeacher.DoubleClick += new System.EventHandler(this.dtgvTeacher_DoubleClick);
            // 
            // frmShowTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTeacher);
            this.Name = "frmShowTeacher";
            this.Text = "frmShowTeacher";
            this.Load += new System.EventHandler(this.frmShowTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtgvTeacher;
    }
}