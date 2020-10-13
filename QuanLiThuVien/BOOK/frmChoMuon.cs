using QuanLiThuVien.ACCOUNT;
using QuanLiThuVien.STUDENT;
using QuanLiThuVien.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BOOK
{
    public partial class frmChoMuon : Form
    {
        Student std = new Student();
        Books books = new Books();
        private AccountDTO loginAccount;
        public frmChoMuon(AccountDTO acc)
        {
            InitializeComponent();
            loginAccount = acc;
            txtMaThe.Text = loginAccount.MaThe;
            loadInfoUser();
            LoadListSachChoMuon(loginAccount.MaThe);
        }

        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }

        void loadInfoUser() //Lấy info của user từ mã thẻ khi login
        {
            try
            {
                string mathe = txtMaThe.Text;

                List<UserInfoDTO> listUserInfo = std.GetUserInFo(mathe);
                foreach (UserInfoDTO item in listUserInfo)
                {
                    txtName.Text = item.TenSV;
                    txtType.Text = item.Type;
                }
            }
            catch { }

        }

        void LoadListSachChoMuon(string mathe)
        {
            dtgvChoMuon.DataSource = books.GetListSachChoMuon(mathe);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if ((MessageBox.Show("Bạn muốn cho thư viện mượn ?", "Cho Mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    string mathe = txtMaThe.Text;
                    string tensach = txtBookName.Text;
                    int soluong = Convert.ToInt32(txtSL.Text);
                    DateTime ngaychomuon = DateTime.Now;
                    if (books.InsertSachChoMuon(mathe, tensach, soluong, ngaychomuon))
                    {
                        MessageBox.Show("Đã thêm thông tin sách cho mượn, cảm ơn đã đóng góp cho thư viện", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadListSachChoMuon(mathe);
                }
                catch { MessageBox.Show("Dữ liệu nhập vào chưa đúng", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information); }
               

                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn xóa dữ liệu ?", "Cho Mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    string mathe = txtMaThe.Text;
                    string tensach = txtBookName.Text;
                    if(books.DeleteSachChoMuon(mathe,tensach))
                    {
                        MessageBox.Show("Đã xóa thông tin sách cho mượn, cảm ơn đã đóng góp cho thư viện", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sách không tồn tại để xóa", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa đúng", " Cho Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;

            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        
    }
}
