using QuanLiThuVien.STUDENT;
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

namespace QuanLiThuVien.ADMIN
{
    public partial class frmManageTeacher : Form
    {
        Student student = new Student();
        Account acc = new Account();
        public frmManageTeacher()
        {
            InitializeComponent();
            ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        bool verif()
        {
            if ((txtName.Text.Trim() == "")
                || (rtAdress.Text.Trim() == "")
                || (ptrImage.Image == null))


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
            if (txtMaThe.Text == "")
                MessageBox.Show("Vui lòng nhập mã thẻ", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string mathe = txtMaThe.Text;
                string tensv = txtName.Text;

                string gioitinh = "Nam";
                if (rbFemale.Checked)
                {
                    gioitinh = "Nữ";
                }

                DateTime ngaysinh = dtpkBirthDate.Value;

                string diachiSV = rtAdress.Text;
                string dienthoai = txtPhone.Text;
                DateTime ngaytao = dtpkDateCreate.Value;
                DateTime ngayhethan = dtpkTimeExpires.Value;
                string chucvu = "Giáo Viên";

                MemoryStream pic = new MemoryStream();




                int born_year = dtpkBirthDate.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10 || (this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi phải từ 10 đến 100", "Tuổi Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    ptrImage.Image.Save(pic, ptrImage.Image.RawFormat);
                    try
                    {
                        if (student.InsertStudentUser(mathe, tensv, gioitinh, ngaysinh, diachiSV, dienthoai, ngaytao, ngayhethan, chucvu, pic))
                        {
                            MessageBox.Show("Đã thêm thông tin thẻ", "Thêm Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Lỗi Không Xác Định", "Thêm Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch { MessageBox.Show("Mã thẻ đã tồn tại", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "")
                MessageBox.Show("Vui lòng nhập mã thẻ", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                string mathe = txtMaThe.Text;
                if ((MessageBox.Show("Bạn có chắc muốn xoá thông tin thẻ ?", "Xóa Thẻ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    try
                    {
                        acc.DeleteAccount(mathe);
                        if (student.DeleteStudentUser(mathe))
                        {
                            MessageBox.Show("Đã xóa thẻ", "Xóa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nhập sai mã thẻ", "Xóa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (mathe == null)
                        {
                            dtpkDateCreate.Value = DateTime.Now;
                            dtpkTimeExpires.Value = DateTime.Now;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Xóa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "")
                MessageBox.Show("Vui lòng nhập mã thẻ", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string mathe = txtMaThe.Text;
                string tensv = txtName.Text;

                string gioitinh = "Nam";
                if (rbFemale.Checked)
                {
                    gioitinh = "Nữ";
                }

                DateTime ngaysinh = dtpkBirthDate.Value;

                string diachiSV = rtAdress.Text;
                string dienthoai = txtPhone.Text;
                DateTime ngaytao = dtpkDateCreate.Value;
                DateTime ngayhethan = dtpkTimeExpires.Value;

                string chucvu = "Giáo Viên";

                MemoryStream pic = new MemoryStream();


                int born_year = dtpkBirthDate.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10 || (this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi phải từ 10 đến 100", "Tuổi Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    ptrImage.Image.Save(pic, ptrImage.Image.RawFormat);
                    if (student.EditStudentUser(mathe, tensv, gioitinh, ngaysinh, diachiSV, dienthoai, ngaytao, ngayhethan, chucvu, pic))
                    {
                        MessageBox.Show("Sửa Thành Công", "Sửa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi ", "Sửa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            frmShowTeacher frmShowTeacher = new frmShowTeacher();
            frmShowTeacher.ShowDialog();

            try
            {
                Student std = new Student();
                string Mathe = frmShowTeacher.dtgvTeacher.CurrentRow.Cells[0].Value.ToString();
                DataTable table = std.GetListStudnetUserByID(Mathe);
                txtMaThe.Text = table.Rows[0]["MaThe"].ToString();
                txtName.Text = table.Rows[0]["TenSV"].ToString();
                dtpkBirthDate.Value = (DateTime)table.Rows[0]["NgaySinh"];
                rtAdress.Text = table.Rows[0]["DiaChiSV"].ToString();
                txtPhone.Text = table.Rows[0]["DienThoaiSV"].ToString();
                dtpkDateCreate.Value = (DateTime)table.Rows[0]["NgayTao"];
                dtpkTimeExpires.Value = (DateTime)table.Rows[0]["NgayHetHan"];
                byte[] pic = (byte[])table.Rows[0]["Anh"];
                MemoryStream picture = new MemoryStream(pic);
                ptrImage.Image = Image.FromStream(picture);

            }
            catch
            {

            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                ptrImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            frmCam frm = new frmCam();
            frm.Show(this);
        }
    }
}
