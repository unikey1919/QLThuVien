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

namespace QuanLiThuVien.ADMIN
{
    public partial class frmManageBook : Form
    {
        Books books = new Books();
        BindingSource bookList = new BindingSource();
        public frmManageBook()
        {
            InitializeComponent();
 
        }
        private void frmManageBook_Load(object sender, EventArgs e)
        {
            dtgvBook.DataSource = bookList;
            LoadBookList();
            AddBindingBook();
        }
        void LoadBookList()
        {
            bookList.DataSource = books.GetListBooks();
        }



        void AddBindingBook()
        {
            txtMaSach.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "MaSach"));
            txtSL.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "SoLuong"));
            txtNamXB.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "NamXB"));
            txtNXB.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "NXB"));
            txtStatus.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "TinhTrang"));
            txtBookType.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "TheLoai"));
            txtTGName.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "TG"));
            txtBookName.DataBindings.Add(new Binding("Text", dtgvBook.DataSource, "TenSach"));
        }
        bool verif()
        {
            if ((txtBookName.Text.Trim() == "")
                || (txtSL.Text.Trim() == "")
                ||(txtNamXB.Text.Trim() == "")
                ||(txtNXB.Text.Trim()=="")
                ||(txtStatus.Text.Trim()=="")
                ||(txtTGName.Text.Trim() == "")
                ||(txtBookType.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã sách", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string masach =txtMaSach.Text;
                int soluong= Convert.ToInt32(txtSL.Text);
                string namXB = txtNamXB.Text;
                string nxb = txtNXB.Text;
                string tinhtrang = txtStatus.Text;
                string theloai = txtBookType.Text;
                string tensach = txtBookName.Text;
                string tacgia = txtTGName.Text;

                if(verif())
                {
                    try {
                        if (books.InsertBook(masach, tensach, theloai, tinhtrang, soluong, nxb, namXB, tacgia))
                        {
                            MessageBox.Show("Đã thêm thông tin sách", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Lỗi Không Xác Định", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    catch { MessageBox.Show("Mã sách đã tồn tại hoặc dữ liệu nhập vào không phù hợp", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                   
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadBookList();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
                MessageBox.Show("Vui lòng nhập mã sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string masach = txtMaSach.Text;
                if ((MessageBox.Show("Bạn có chắc muốn xoá sách?", "Xóa Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (books.DeleteBook(masach))
                    {
                        MessageBox.Show("Đã xóa sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai mã sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadBookList();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string masach = txtMaSach.Text;
                int soluong = Convert.ToInt32(txtSL.Text);
                string namXB = txtNamXB.Text;
                string nxb = txtNXB.Text;
                string tinhtrang = txtStatus.Text;
                string theloai = txtBookType.Text;
                string tensach = txtBookName.Text;
                string tacgia = txtTGName.Text;

                if (verif())
                {
                    if (books.EditBook(masach, tensach, theloai, tinhtrang, soluong, nxb, namXB, tacgia))
                    {
                        MessageBox.Show("Đã thay đổi thông tin sách", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadBookList();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.SACH WHERE CONCAT(MaSach,TenSach,TheLoai,TinhTrang,SoLuong,NamXB,NXB,TG) LIKE N'%" + txtFind.Text + "%'";

            dtgvBook.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dtgvBook.DataSource = books.GetBookList();
            
          if(dtgvBook.Rows.Count>0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for(int i=1;i<dtgvBook.Columns.Count+1;i++)
                {
                    xcelApp.Cells[1, i] = dtgvBook.Columns[i - 1].HeaderText;

                }
                for(int i=0;i<dtgvBook.Rows.Count;i++)
                {
                    for (int j = 0; j < dtgvBook.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dtgvBook.Rows[i].Cells[j].Value.ToString();
                    }
                            
                }

                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

                dtgvBook.DataSource = bookList;
               
            }
            
        }
    }
}
