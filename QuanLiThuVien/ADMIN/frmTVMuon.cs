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

    public partial class frmTVMuon : Form
    {
        Books books = new Books();
        public frmTVMuon()
        {
            InitializeComponent();
            LoadListBookTVMuon();
            LoadListBookTVDaMuon();
        }

        void LoadListBookTVMuon()
        {
            dtgvChoMuon.DataSource = books.GetListSachChoMuonTV();

        }
        void LoadListBookTVDaMuon()
        {
            dtgvDaMuon.DataSource = books.GetListSachTVDaMuon();
        }
        bool verif()
        {
            if ((txtBookName.Text.Trim() == "")
                || (txtSL.Text.Trim() == "")
                || (txtNamXB.Text.Trim() == "")
                || (txtNXB.Text.Trim() == "")
                || (txtStatus.Text.Trim() == "")
                || (txtTGName.Text.Trim() == "")
                || (txtBookType.Text.Trim() == ""))

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
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách", "Thêm Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mathe = txtMaThe.Text;
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
                    try
                    {
                        if (books.InsertSachTVMuon(mathe, masach, tensach, theloai, tinhtrang, soluong, nxb, namXB, tacgia))
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
                LoadListBookTVDaMuon();
            }
        }

        private void dtgvChoMuon_Click(object sender, EventArgs e)
        {
            txtMaThe.Text = dtgvChoMuon.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dtgvChoMuon.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dtgvChoMuon.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
                MessageBox.Show("Vui lòng nhập mã sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string mathe = txtMaThe.Text;
                string masach = txtMaSach.Text;
                if ((MessageBox.Show("Bạn có chắc muốn xoá sách?", "Xóa Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (books.DeleteSachTvMuon(mathe, masach))
                    {
                        MessageBox.Show("Đã xóa sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai mã sách", "Xóa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
                LoadListBookTVDaMuon();
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
                string mathe = txtMaThe.Text;
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
                    if (books.EditSachTVMuon(mathe,masach, tensach, theloai, tinhtrang, soluong, nxb, namXB, tacgia))
                    {
                        MessageBox.Show("Đã thay đổi thông tin sách", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Sửa Sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadListBookTVDaMuon();
            }
        }

        private void dtgvDaMuon_Click(object sender, EventArgs e)
        {
            txtMaThe.Text = dtgvDaMuon.CurrentRow.Cells[0].Value.ToString();
            txtMaSach.Text = dtgvDaMuon.CurrentRow.Cells[1].Value.ToString();
            txtBookName.Text = dtgvDaMuon.CurrentRow.Cells[2].Value.ToString();
            txtBookType.Text = dtgvDaMuon.CurrentRow.Cells[3].Value.ToString();
            txtStatus.Text = dtgvDaMuon.CurrentRow.Cells[4].Value.ToString();
            txtSL.Text = dtgvDaMuon.CurrentRow.Cells[5].Value.ToString();
            txtNXB.Text = dtgvDaMuon.CurrentRow.Cells[6].Value.ToString();
            txtNamXB.Text = dtgvDaMuon.CurrentRow.Cells[7].Value.ToString();
            txtTGName.Text = dtgvDaMuon.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
