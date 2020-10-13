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

namespace QuanLiThuVien.USER
{
    public partial class frmUserInfo : Form
    {
        Student student = new Student();
        private string maThe;
        public frmUserInfo(string mathe)
        {
            this.MaThe = mathe;
            InitializeComponent();
            LoadUserInfo(mathe);
        }

        public string MaThe { get => maThe; set => maThe = value; }

        void LoadUserInfo(string mathe)
        {


            txtMaThe.Text = mathe;

            List<UserInfoDTO> listUserInfo = student.GetUserInFo(mathe);
            foreach (UserInfoDTO item in listUserInfo)
            {
                txtUserName.Text = item.UserName;
                txtName.Text = item.TenSV;
                txtGender.Text = item.GioiTinh;
                txtBirthDate.Text = item.NgaySinh.ToString();
                txtPhone.Text = item.DienThoaiSV;
                txtType.Text = item.Type;
                byte[] pic = item.Pic;
                MemoryStream picture = new MemoryStream(pic);
                ptrImage.Image = Image.FromStream(picture);
                ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;

            }


            if (txtUserName.Text == "")
            {
                MessageBox.Show("User Chưa có tài khoản để tra cứu", "Thông tin user", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
