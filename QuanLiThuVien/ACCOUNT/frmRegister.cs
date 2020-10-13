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
    
    public partial class frmRegister : Form
    {
        Account acc = new Account();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtMaThe.Text==""|| txtNewUser.Text == ""|| txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string mathe = txtMaThe.Text;
                string username = txtNewUser.Text;
                string chucvu = txtChucVu.Text;
                string password = txtPass.Text;
                if(!acc.MaTheExist(mathe))
                {
                    try
                    {
                        if (acc.InsertAccount(mathe, username, password, chucvu))
                        {
                            MessageBox.Show("Tài khoản mới tạo thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Không Xác Định", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch { MessageBox.Show("Mã thẻ chưa tồn tại, vui lòng liên hệ admin để cấp mã thẻ  hoặc dữ liệu tài khoản đã có người sử dụng", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    MessageBox.Show("Mã thẻ đã có tài khoản, vui lòng nhập mã thẻ khác", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "" || txtNewUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string mathe = txtMaThe.Text;
                string username = txtNewUser.Text;
                string chucvu = txtChucVu.Text;
                string password = txtPass.Text;
                if (!acc.MaTheExist(mathe))
                {
                    try
                    {
                        if (acc.InsertAccount(mathe, username, password, chucvu))
                        {
                            MessageBox.Show("Tài khoản mới tạo thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi Không Xác Định", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch { MessageBox.Show("Mã thẻ chưa tồn tại, vui lòng liên hệ admin để cấp mã thẻ  hoặc dữ liệu tài khoản đã có người sử dụng", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    MessageBox.Show("Mã thẻ đã có tài khoản, vui lòng nhập mã thẻ khác", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
