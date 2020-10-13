using QuanLiThuVien.ACCOUNT;
using QuanLiThuVien.STUDENT;
using QuanLiThuVien.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BOOK
{
    public partial class frmSachTra : Form
    {
        Student student = new Student();
        PhieuMuon pm = new PhieuMuon();
        BindingSource SachTra = new BindingSource();
        private AccountDTO loginAccount;
        public frmSachTra(AccountDTO acc)
        {
            InitializeComponent();
            loginAccount = acc;
            LoadListSachMuon(loginAccount.MaThe);
 
        }

        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }

        
        private void frmSachTra_Load_1(object sender, EventArgs e)
        {
            dtgvListSM.DataSource = SachTra;
            AddBingdingSachTra();
            loadInfoUser();
            loadInfoSachMuon();
        }
        void LoadListSachMuon(string mathe)
        {

           SachTra.DataSource = pm.GetListSachMuonTheoMaThe(mathe);
            //dtpkNgayMuon.Enabled = false;
            //dtpkNgayTra.Enabled = false;

        }
        void loadInfoUser() //Lấy info của user từ mã thẻ khi login
        {
            try
            {
                string mathe = txtMaThe.Text;

                List<UserInfoDTO> listUserInfo = student.GetUserInFo(mathe);
                foreach (UserInfoDTO item in listUserInfo)
                {
                    txtName.Text = item.TenSV;
                    txtType.Text = item.Type;
                }

            }
            catch { }



        }

        void loadInfoSachMuon()
        {
            Books books = new Books();
            try
            {
                List<SachMuonDTO> sachMuonDTOs = books.GetListSachMuon();
                foreach (SachMuonDTO item in sachMuonDTOs)
                {
                    string masach = item.MaSach;
                    string tinhtrang = item.TinhTrang;
                    int sl = item.SLSachMuon1;
                    string mapm = item.MaPM;
                    DateTime ngaytra = item.NgayTra;

                }
            }
            catch { }
        }

        void AddBingdingSachTra()
        {
            txtMP.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "MaPM"));
            txtMaThe.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "MaThe"));
            txtTinhTrang.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "TinhTrang"));
            txtSL.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "SLSachMuon"));
            txtMaSach.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "MaSach"));
            txtNgayMuon.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "NgayMuon"));
            txtNgayTra.DataBindings.Add(new Binding("Text", dtgvListSM.DataSource, "NgayTra"));

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "")
            {
                MessageBox.Show("Bạn Đã trả hết sách", " Trả Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                if ((MessageBox.Show("Bạn có chắc muốn trả sách ?", "Trả Sách Mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string masach = txtMaSach.Text;
                    string mathe = txtMaThe.Text;
                    string tinhtrang = txtTinhTrang.Text;
                    int sl = Convert.ToInt32(txtSL.Text);
                    DateTime NgayTra = DateTime.Now;
                    DateTime NgayHan = DateTime.Parse(txtNgayTra.Text, new CultureInfo("en-US", true));
                    string mapm = txtMP.Text;
                    pm.InsertListSachTra(mathe, mapm, masach, tinhtrang, sl, NgayTra, NgayHan);
                    if (txtType.Text == "Sinh Viên" & (pm.CheckOut(mapm) > 0))
                    {
                        MessageBox.Show("Sinh viên vui lòng nộp sách đúng hạn vào lần  mượn tới, vui lòng nộp phạt cho quản lí", "Trả Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (txtType.Text == "Sinh Viên" & txtTinhTrang.Text == "Hư")
                    {
                        MessageBox.Show("Với tình trạng sách hư sinh viên vui lòng nộp phạt, nếu có khiếu nại vui lòng liên hệ cho quản lí", "Trả Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (txtType.Text == "Sinh Viên" & (pm.CheckOut(mapm) > 0) & txtTinhTrang.Text == "Hư")
                    {
                        MessageBox.Show("Với tình trạng sách hư và nộp quá hân sinh viên vui lòng nộp phạt, nếu có khiếu nại vui lòng liên hệ cho quản lí", "Trả Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (pm.DeleteSM(masach, mapm))
                    {
                        MessageBox.Show("Đã Trả Sách Về Kho", " Trả Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pm.DeletePM(mapm);
                        MessageBox.Show("Đã Xóa Phiếu Mượn", " Trả Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi !", "Trả Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txtMaThe.Text == "")
                    {

                        MessageBox.Show("Bạn Đã trả hết sách", " Trả Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    LoadListSachMuon(mathe);
                }


            }

        }

        private void btnStatusList_Click(object sender, EventArgs e)
        {
            string mathe = loginAccount.MaThe;
            frmSachDaTra frmSachDaTra = new frmSachDaTra(mathe);
            frmSachDaTra.Show(this);
        }
    }
}
