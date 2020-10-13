using QuanLiThuVien.ACCOUNT;
using QuanLiThuVien.STUDENT;
using QuanLiThuVien.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BOOK
{
    public partial class frmSachMuon : Form
    {
        private AccountDTO loginAccount; //Truyền mã thẻ từ khi đăng nhập vào
        Student student = new Student();
        Books books = new Books();
        PhieuMuon PhieuMuon = new PhieuMuon();
        BindingSource PMlist = new BindingSource();
        
        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }

        public frmSachMuon(AccountDTO acc)
        {
            InitializeComponent();
            loginAccount = acc;
            txtMaThe.Text = loginAccount.MaThe;     //Lấy mã thẻ từ khi login
            loadInfoUser();
        }

        private void frmSachMuon_Load(object sender, EventArgs e)
        {
            this.cbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dtgvPM.DataSource = PMlist;
            dtpkNgayMuon.Enabled = false;
            LoadBookInfo();
            loadMaSach();
            loadPM();
            AddPMBiding();
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

        void LoadBookInfo()
        {
           dtgvBook.DataSource = books.GetListBooks();
           
        } 

        void loadPM()
        {
            try
            {
                string mathe = txtMaThe.Text;
                PMlist.DataSource = PhieuMuon.GetListPM(mathe);
            }
            catch { }
        }

        void loadMaSach()
        {
            cbMaSach.DataSource = books.GetListBooks();
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DisplayMember = "MaSach";

        }
   


        void AddPMBiding()
        {
            txtMapm.DataBindings.Add(new Binding("Text", dtgvPM.DataSource, "MaPM"));
            cbMaSach.DataBindings.Add(new Binding("Selectedvalue", dtgvPM.DataSource, "MaSach"));
            dtpkNgayMuon.DataBindings.Add(new Binding("Value", dtgvPM.DataSource, "NgayMuon"));

            
        }

        private string taoMaPM()
        {
            string mapm;
            Random r = new Random();
            mapm = "PM" + r.Next(50, 999).ToString();
            return mapm;
        }

       

        private void btnReNew_Click(object sender, EventArgs e)
        {
            txtMapm.Clear();
            txtMapm.Text = taoMaPM();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMapm.Text == "")
            {
                MessageBox.Show("Vui lòng tạo Mã PM", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mapm = txtMapm.Text;
                string masach = cbMaSach.SelectedValue.ToString();
                string mathe = txtMaThe.Text;
                DateTime ngaymuon = dtpkNgayMuon.Value;
                try
                {
                    if (PhieuMuon.InsertPM(mapm,masach,mathe,ngaymuon))
                    {
                        MessageBox.Show("Đã thêm thông tin Phiếu Mượn", "Thêm Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi Không Xác Định", "Thêm Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch 
                { 
                    MessageBox.Show("Mã Phiếu Mượn đã tồn tại hoặc dữ liệu nhập vào không phù hợp, ", "Thêm Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Vui lòng nhấn tạo mã phiếu để lấy mã phiếu mới");
                }
                loadPM();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMapm.Text == "")
            {
                MessageBox.Show("Vui lòng tạo Mã PM", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mapm = txtMapm.Text;
                string masach = cbMaSach.SelectedValue.ToString();
                string mathe = txtMaThe.Text;
                DateTime ngaymuon = dtpkNgayMuon.Value;
                try
                {
                    if (PhieuMuon.EditPM(mapm, masach, mathe, ngaymuon))
                    {
                        MessageBox.Show("Đã sửa thông tin Phiếu Mượn", "Sửa Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi Không Xác Định", "Sửa Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { MessageBox.Show("Sai mã phiếu mượn hoặc dữ liệu nhập vào không phù hợp", "Thêm Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                loadPM();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMapm.Text == "")
                MessageBox.Show("Mã Phiếu Trống", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                string maphieu = txtMapm.Text;
                if ((MessageBox.Show("Bạn có chắc muốn xoá thông tin Mã Phiếu ?", "Xóa Phiếu Mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (PhieuMuon.DeletePM(maphieu))
                    {
                        MessageBox.Show("Đã xóa Phiếu Mượn", "Xóa Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   else
                    {
                        MessageBox.Show("Sai Phiếu Mượn", "Xóa Phiếu Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    loadPM();
                }
               
            }
        }

        private void dtgvBook_Click(object sender, EventArgs e)
        {
            cbMaSach.SelectedValue = dtgvBook.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.SACH WHERE CONCAT(MaSach,TenSach,TheLoai,NamXB,NXB,TG) LIKE N'%" + txtFind.Text + "%'";
            dtgvBook.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadBookInfo();
        }

        private void btnFindPM_Click(object sender, EventArgs e)
        {
            string mathe = loginAccount.MaThe;
            string query = "SELECT MaPM,PHIEUMUON.MaThe,TenSV AS N'Tên',PHIEUMUON.MaSach,TenSach,NgayMuon FROM dbo.PHIEUMUON,dbo.SACH,dbo.THETHUVIEN WHERE PHIEUMUON.MaThe=THETHUVIEN.MaThe AND PHIEUMUON.MaSach=SACH.MaSach AND PHIEUMUON.MaThe="+mathe+" AND CONCAT(MaPM,PHIEUMUON.MaSach)  LIKE N'%" + txtFindPM.Text + "%'";
            dtgvPM.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txtFindPM_TextChanged(object sender, EventArgs e)
        {
            if (txtFindPM.Text == "")
            {
                dtgvPM.DataSource = PMlist;
            }
                
        }
    }
}
