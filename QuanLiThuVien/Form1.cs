using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DoAnLTWINDataSet3.SACHTRATHANHCONG' table. You can move, or remove it, as needed.
            this.SACHTRATHANHCONGTableAdapter.Fill(this.DoAnLTWINDataSet3.SACHTRATHANHCONG);
            // TODO: This line of code loads data into the 'DoAnLTWINDataSet2.PHIEUMUON' table. You can move, or remove it, as needed.
            this.PHIEUMUONTableAdapter.Fill(this.DoAnLTWINDataSet2.PHIEUMUON);
            // TODO: This line of code loads data into the 'DoAnLTWINDataSet1.THETHUVIEN' table. You can move, or remove it, as needed.
            this.THETHUVIENTableAdapter.Fill(this.DoAnLTWINDataSet1.THETHUVIEN);
            // TODO: This line of code loads data into the 'DoAnLTWINDataSet.SACH' table. You can move, or remove it, as needed.
            this.SACHTableAdapter.Fill(this.DoAnLTWINDataSet.SACH);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
