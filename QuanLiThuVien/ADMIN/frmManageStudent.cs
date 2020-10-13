using QuanLiThuVien.ACCOUNT;
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


namespace QuanLiThuVien.ADMIN
{
    public partial class frmManageStudent : Form
    {
        
        Student student = new Student();

        BindingSource userList = new BindingSource();
        public frmManageStudent()
        {
            InitializeComponent();
           
        }
        private void frmManageStudent_Load(object sender, EventArgs e)
        {
            
            dtgvStudent.DataSource = userList;
            ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;
            loadStudentUserList();
            
            AddUserBinding();
            
        }

        void clearInfo()
        {
            txtMaThe.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            rtAdress.Text = "";
            ptrImage.Image = default;
           
            
        }
        void loadStudentUserList()
        {
            
            loadChucVu();
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            userList.DataSource = student.GetListStudnetUser();
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dtgvStudent.RowTemplate.Height = 80;
            picol = (DataGridViewImageColumn)dtgvStudent.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
          //doi tuong lam viec voi dang picture cua dtgv
            dtgvStudent.RowTemplate.Height = 40;// co gian de pic dep, dam tim auto size
            dtgvStudent.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((txtName.Text.Trim() == "")
                || (rtAdress.Text.Trim() == "")
                || (ptrImage.Image == null))
                //|| (txtType.Text.Trim()==""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void AddUserBinding()
        {
            txtMaThe.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Mã Thẻ"));
            txtName.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Tên"));    
            dtpkBirthDate.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Ngày Sinh"));
            rtAdress.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Địa chỉ"));
            txtPhone.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Điện Thoại"));
            dtpkTimeExpires.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Ngày Hết Hạn"));
            dtpkDateCreate.DataBindings.Add(new Binding("Text", dtgvStudent.DataSource, "Ngày Tạo"));
            ptrImage.DataBindings.Add(new Binding("Image", dtgvStudent.DataSource, "Ảnh",true));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMaThe.Text=="")
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

                DateTime ngaysinh=dtpkBirthDate.Value;
                
                string diachiSV = rtAdress.Text;
                string dienthoai = txtPhone.Text;
                DateTime ngaytao = dtpkDateCreate.Value;
                DateTime ngayhethan = dtpkTimeExpires.Value;
                string chucvu = cbChucVu.SelectedValue.ToString();

                MemoryStream pic = new MemoryStream();
               

                int born_year = dtpkBirthDate.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10 || (this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi phải từ 10 đến 100", "Tuổi Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(verif())
                {
                    ptrImage.Image.Save(pic, ptrImage.Image.RawFormat);
                    try
                    {
                        if (student.InsertStudentUser(mathe, tensv, gioitinh, ngaysinh, diachiSV, dienthoai, ngaytao, ngayhethan,chucvu,pic))
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
                loadStudentUserList();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
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

                loadStudentUserList();
       
            }
        }

        private void txtMaThe_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

                string chucvu = cbChucVu.SelectedValue.ToString();

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
                    if (student.EditStudentUser(mathe, tensv, gioitinh, ngaysinh, diachiSV, dienthoai, ngaytao, ngayhethan,chucvu,pic))
                    {
                        MessageBox.Show("Sửa Thành Công", "Sửa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lỗi ", "Sửa Thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thêm thẻ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadStudentUserList();
            }
        }

        private void dtgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mathe=dtgvStudent.CurrentRow.Cells[0].Value.ToString();
            frmUserInfo frmUserInfo = new frmUserInfo(mathe);
            frmUserInfo.Show(this);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.THETHUVIEN WHERE CONCAT(MaThe,TenSV) LIKE N'%" + txtFind.Text + "%'";
            dtgvStudent.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                loadStudentUserList();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        void loadChucVu()
        {
            GROUP gr = new GROUP();
            cbChucVu.DataSource = gr.GetListGroup();
            cbChucVu.DisplayMember = "name";
            cbChucVu.ValueMember = "name";
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            frmCam frm = new frmCam();
            frm.Show(this);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show(this);
        }
    }
}
