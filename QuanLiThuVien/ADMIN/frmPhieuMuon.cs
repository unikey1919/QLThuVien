using QuanLiThuVien.BOOK;
using QuanLiThuVien.PHIEUMUON;
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

namespace QuanLiThuVien.ADMIN
{
    public partial class frmPhieuMuon : Form
    {
        PhieuMuon pm = new PhieuMuon();
        Books book = new Books();
        public frmPhieuMuon()
        {
            InitializeComponent();
        }


        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            this.cbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            loadSachMuon();
            loadMaSach();
            loadPM();
        }

        void loadPM()
        {
            dtgvPM.DataSource = pm.GetPM();
        }
        void loadMaSach()
        {
            List<PhieuMuonDTO> listPM = pm.GetMaSach();
            cbMaSach.DataSource = listPM;
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DisplayMember = "MaSach";
        }

        void loadPMTheoMaSach(string masach) //chọn số phiếu mượn theo mã sách
        {
            cbMaPM.DataSource = pm.GetListPMfromMaSach(masach);
            cbMaPM.ValueMember = "MaPM";
            cbMaPM.DisplayMember ="MaPM";
        }
      
        void loadSachMuon()
        {
            dtgvSachMuon.DataSource = pm.GetListSachMuon();
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id ;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem is null)
                return;
                
            PhieuMuonDTO selected = cb.SelectedItem as PhieuMuonDTO;
            id = selected.MaSach;
            loadPMTheoMaSach(id);
            
            
        }


        bool verif()
        {
            if ((txtSoLuong.Text.Trim() == "")
                || (txtTinhTrang.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if(verif())
            {
                try
                {
                    string masach = cbMaSach.SelectedValue.ToString();
                    string mapm = cbMaPM.SelectedValue.ToString();
                    string tinhtrang = txtTinhTrang.Text;
                    int soluong = Convert.ToInt32(txtSoLuong.Text);
                    DateTime ngaytra = dtpkNgayTra.Value;
                    if (pm.InsertSM(masach, mapm, tinhtrang, soluong, ngaytra))
                    {
                        MessageBox.Show("Đã thêm thông tin Sách Mượn", "Thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập", "thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch { MessageBox.Show("Mã Phiếu Mượn đã tồn tại hoặc dữ liệu nhập vào không hợp lệ !", "thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                

                loadSachMuon();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn xóa thông tin thẻ ?", "Xóa Thẻ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string masach = cbMaSach.SelectedValue.ToString();
                string mapm = cbMaPM.SelectedValue.ToString();
              
                if (pm.DeleteSM(masach, mapm))
                {
                    MessageBox.Show("Đã xóa thông tin Sách Mượn", " Xóa Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dữ liệu không có để xóa !", "Xóa Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }





            loadSachMuon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                try
                {
                    string masach = cbMaSach.SelectedValue.ToString();
                    string mapm = cbMaPM.SelectedValue.ToString();
                    string tinhtrang = txtTinhTrang.Text;
                    int soluong = Convert.ToInt32(txtSoLuong.Text);
                    DateTime ngaytra = dtpkNgayTra.Value;
                    if (pm.EditSM(masach, mapm, tinhtrang, soluong, ngaytra))
                    {
                        MessageBox.Show("Đã Sửa Sách Mượn", "Sửa Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập", "Sửa Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
               catch { MessageBox.Show("Mã Phiếu Mượn đã không tồn tại hoặc dữ liệu nhập vào không hợp lệ !", "thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                loadSachMuon();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thêm Sách Mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindPM_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.PHIEUMUON where CONCAT(MaPM,PHIEUMUON.MaSach)  LIKE N'%" + txtFindPM.Text + "%'";
            dtgvPM.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txtFindPM_TextChanged(object sender, EventArgs e)
        {
            if (txtFindPM.Text == "")
                loadPM();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
