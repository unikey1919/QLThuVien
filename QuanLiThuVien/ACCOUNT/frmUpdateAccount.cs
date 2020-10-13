using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.ACCOUNT
{
    public partial class frmUpdateAccount : Form
    {
        private string username;
        Account acc = new Account();
        public frmUpdateAccount(string username)
        {
            this.Username = username;
            InitializeComponent();
            txtNewUser.Text = username;

        }

        public string Username { get => username; set => username = value; }



        private void btnUpDate_Click(object sender, EventArgs e)
        {
            
            string password = txtPass.Text;
            string newpass = txtNewPass.Text;
            string reenterpass = txtReEnterPass.Text;
            string chucvu = txtChucVu.Text;

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu trùng với mất khẩu mới");
            }
            else
            {
                if (acc.UpdateAccount(username, password, newpass, chucvu))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }
    }
}
