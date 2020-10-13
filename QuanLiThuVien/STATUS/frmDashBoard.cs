using QuanLiThuVien.ADMIN;
using QuanLiThuVien.STATUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmDashBoard : Form
    {
        ThongKe thongKe = new ThongKe();
        public frmDashBoard()
        {
            InitializeComponent();
            loadListTSChucVu();
            loadListTSSach();
        }

        void loadListTSChucVu()
        {
            string query = "SELECT COUNT(*) FROM dbo.THETHUVIEN";
            int TongSoUser = thongKe.GetTongSo(query);
            label2.Text = "Tổng Số User - " + TongSoUser;

            DataTable data = new DataTable();
            data = thongKe.GetListChucVu();

            lsvChucVu.Items.Clear();
            lsvChucVu.FullRowSelect = true;

            int i = 0;
            foreach(DataRow row in data.Rows)
            {
                lsvChucVu.Items.Add(row["name"].ToString());
                lsvChucVu.Items[i].SubItems.Add(row["Nam"].ToString());
                lsvChucVu.Items[i].SubItems.Add(row["Nu"].ToString());
                lsvChucVu.Items[i].SubItems.Add(row["Tong"].ToString());
                i++;
            }


        }

        void loadListTSSach()
        {
            string query = "SELECT SUM(SoLuong) FROM dbo.SACH";
            string query1 = "SELECT COUNT(DISTINCT TheLoai) FROM dbo.SACH";
            string query2 = "SELECT SUM(SoLuong) FROM dbo.SACH WHERE TinhTrang=N'Cũ'";
            string query3 = "SELECT COUNT(DISTINCT NXB) FROM dbo.SACH";
            string query4 = "SELECT COUNT(DISTINCT TG) FROM dbo.SACH";
            string query5 = "SELECT SUM(SoLuong) FROM dbo.SACH WHERE TinhTrang=N'Mới'";

            int tongsach = thongKe.GetTongSo(query);
            int tongtheloai = thongKe.GetTongSo(query1);
            int tongSM = thongKe.GetTongSo(query5);
            int tongSC = thongKe.GetTongSo(query2);
            int tongNXB = thongKe.GetTongSo(query3);
            int tongTG = thongKe.GetTongSo(query4);

            label9.Text = "Tổng Số Sách - " + tongsach;
            btnTongTheLoai.Text = tongtheloai.ToString();
            btnTongSachCu.Text = tongSC.ToString();
            btnTongSachMoi.Text = tongSM.ToString();
            btnTongNXB.Text = tongNXB.ToString();
            btnTongTG.Text = tongTG.ToString();
            


        }

        private void btnShowSachChart_Click(object sender, EventArgs e)
        {
            frmThongKeDauSach frmThongKeDauSach = new frmThongKeDauSach();
            frmThongKeDauSach.ShowDialog();
        }

        private void btnUserchart_Click(object sender, EventArgs e)
        {
            frmThongKeUser frmThongKeUser = new frmThongKeUser();
            frmThongKeUser.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
