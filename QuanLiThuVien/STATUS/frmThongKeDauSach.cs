using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.ADMIN
{
    public partial class frmThongKeDauSach : Form
    {
        Books books = new Books();
        ThongKe thongKe = new ThongKe();
        public frmThongKeDauSach()
        {
            InitializeComponent();
        }

        private void frmThongKeDauSach_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = books.GetListSlSachMuon();
                CrtSachMuon.ChartAreas["ChartArea1"].AxisX.Title = "Mã Sách";
                CrtSachMuon.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng mượn";
                CrtSachMuon.Series["Số người mượn"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    CrtSachMuon.Series["Số người mượn"].Points.AddXY(data.Rows[i]["MaSach"], data.Rows[i]["Số Lượng Sách Mượn"]);
                }
            }
            catch { }
           
            string query= "SELECT MAX(MaSach),MIN(MaSach) FROM dbo.PHIEUMUON";
            DataTable table = new DataTable();
            table = thongKe.GetMaxMin(query);

            lblMax.Text = table.Rows[0][0].ToString();
            lblMin.Text = table.Rows[0][1].ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
