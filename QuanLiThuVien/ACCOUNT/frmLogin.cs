using QuanLiThuVien.ACCOUNT;
using QuanLiThuVien.BOOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmLogin : Form
    {
        Account acc = new Account();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            
            if(acc.Login(userName,passWord))
            {
                AccountDTO loginAccount = acc.GetAccountByUserName(userName);
                frmLibrary frmLibrary = new frmLibrary(loginAccount);
                this.Hide();
                frmLibrary.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }                
        }





        #region KEYPRESS
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToUpper(e.KeyChar);
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show(this);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show(this);
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
            else
                txtPassWord.UseSystemPasswordChar = false;
        }
    }
}
