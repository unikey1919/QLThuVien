using QuanLiThuVien.STUDENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.ADMIN
{
    public partial class frmShowStudent : Form
    {
        public frmShowStudent()
        {
            InitializeComponent();
        }

        private void frmShowStudent_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dtgvStudent.RowTemplate.Height = 80;
            Student std = new Student();
            dtgvStudent.DataSource = std.GetListStudnetUserSV();

            picol = (DataGridViewImageColumn)dtgvStudent.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < dtgvStudent.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dtgvStudent.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dtgvStudent_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
