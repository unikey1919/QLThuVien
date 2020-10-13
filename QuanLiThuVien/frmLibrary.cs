using QuanLiThuVien.ACCOUNT;
using QuanLiThuVien.ADMIN;
using QuanLiThuVien.BOOK;
using QuanLiThuVien.STUDENT;
using QuanLiThuVien.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmLibrary : Form
    {
        private AccountDTO loginAccount;

        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }

        public frmLibrary(AccountDTO acc)
        {
            this.LoginAccount = acc;
            InitializeComponent();
            changeAccount(loginAccount.Type);
            LoadListBook();
            getInfo();
        }

        void getInfo()
        {
            
            lblUserName.Text = loginAccount.UserName;
            Student student = new Student();
            List<UserInfoDTO> listUserInfo = student.GetUserInFo(loginAccount.MaThe);
            foreach (UserInfoDTO item in listUserInfo)
            {
                byte[] pic = item.Pic;
                MemoryStream picture = new MemoryStream(pic);
                ptrImageUser.Image = Image.FromStream(picture);
                ptrImageUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        void changeAccount(string type)
        {
            aDMINToolStripMenuItem.Enabled = (type == "Admin" || type == "admin");
            sTUDENTToolStripMenuItem.Enabled = (type == "Sinh Viên" || type == "Giáo Viên" || type=="sinh viên" || type == "giáo viên");
           cHOMƯỢNToolStripMenuItem.Enabled = (type == "Giáo Viên"|| type=="giáo viên");
          
        }

        void LoadListBook()
        {
            Books books = new Books();
            dtgvBook.DataSource = books.GetListBooks();
        }
        private void mANGESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStudent frmManageStudent = new frmManageStudent();
            frmManageStudent.Show(this);
        }

        private void mANAGEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBook frmManageBook = new frmManageBook();
            frmManageBook.Show(this);
        }

        

        private void mƯỢNSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmSachMuon frmSach = new frmSachMuon(loginAccount);
            frmSach.Show(this);
        }

        private void tạoPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon frmPhieu = new frmPhieuMuon();
            frmPhieu.Show(this);
        }

        private void tRẢSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSachTra frmSachTra = new frmSachTra(loginAccount);
            frmSachTra.Show(this);
        }

        private void cHOMƯỢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChoMuon frmChoMuon = new frmChoMuon(loginAccount);
            frmChoMuon.Show(this);
        }

        private void giáoViênChoMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTVMuon frmTV = new frmTVMuon();
            frmTV.Show(this);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.SACH WHERE CONCAT(MaSach,TenSach,TheLoai,NamXB,NXB,TG) LIKE N'%" + txtFind.Text + "%'";
            dtgvBook.DataSource = DataProvider.Instance.ExecuteQuery(query);
          
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadListBook();
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStudentUser frmManageStudentUser = new frmManageStudentUser();
            frmManageStudentUser.Show(this);
        }

        private void quảnLíGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTeacher frmManageTeacher = new frmManageTeacher();
            frmManageTeacher.Show(this);
        }

        private void tHỐNGKÊToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThongKeDauSach frmThongKeDauSach = new frmThongKeDauSach();
            frmThongKeDauSach.Show(this);
        }

        private void tẠONHÓMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGroup frmAddGroup = new frmAddGroup();
            frmAddGroup.Show(this);
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show(this);
        }

        private void cHOMƯỢNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmChoMuon frmChoMuon = new frmChoMuon(loginAccount);
            frmChoMuon.Show(this);
        }

        private void tHÔNGTINCÁNHÂNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mathe = loginAccount.MaThe;
            frmUserInfo frmUserInfo = new frmUserInfo(mathe);
            frmUserInfo.Show(this);
        }

        private void tHAYĐỔITHÔNGTINTÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = loginAccount.UserName;
            frmUpdateAccount frmUpdateAccount = new frmUpdateAccount(username);
            frmUpdateAccount.Show(this);
        }

       

        private void btnTra_Click(object sender, EventArgs e)
        {
            frmSachDaTra frmSachDaTra = new frmSachDaTra(loginAccount.MaThe);
            frmSachDaTra.Show(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Đăng suất khỏi hệ thống ?", "Đăng suất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(this);
        }
    }
}
