using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.STATUS
{
    public partial class frmThongKeUser : Form
    {
        ThongKe thongKe = new ThongKe();
        public frmThongKeUser()
        {
            InitializeComponent();
            loadChartUser();
            loadChartChucVu();
        }

        void loadChartUser()
        {

            double total = Convert.ToDouble(thongKe.GetTongSo("SELECT COUNT(*) FROM dbo.THETHUVIEN"));
            double totalMale= Convert.ToDouble(thongKe.GetTongSo("SELECT COUNT(*) FROM dbo.THETHUVIEN WHERE Gioitinh=N'Nam'"));
            double totalFeMale= Convert.ToDouble(thongKe.GetTongSo("SELECT COUNT(*) FROM dbo.THETHUVIEN WHERE Gioitinh=N'Nữ'"));

            double maleStudentsPercentage = (totalMale * (100 / total));
            double fmaleStudentsPercentage = (totalFeMale * (100 / total));


            crtUser.Titles.Add("Tổng Số User - " + total+" - 100 %"+"("+"Đơn Vị %"+")");
            crtUser.Series["s1"].IsValueShownAsLabel = true;
            crtUser.Series["s1"].Points.AddXY("Nam", maleStudentsPercentage.ToString("0.00"));
            crtUser.Series["s1"].Points.AddXY("Nữ", fmaleStudentsPercentage.ToString("0.00"));
        }

        void loadChartChucVu()
        {
            try
            {
                DataTable data = new DataTable();
                data = thongKe.GetListSLChucVu();
                crtChucVu.ChartAreas["ChartArea1"].AxisX.Title = "Chức Vụ";
                crtChucVu.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng User";
                crtChucVu.Series["Số Lượng User"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    crtChucVu.Series["Số Lượng User"].Points.AddXY(data.Rows[i]["ChucVu"], data.Rows[i]["Số Lượng User"]);
                }
            }
            catch { }
        }
    }
}
