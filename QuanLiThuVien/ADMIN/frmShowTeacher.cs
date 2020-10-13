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
    public partial class frmShowTeacher : Form
    {
        public frmShowTeacher()
        {
            InitializeComponent();
        }

        private void frmShowTeacher_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dtgvTeacher.RowTemplate.Height = 80;
            Student std = new Student();
            dtgvTeacher.DataSource = std.GetListTeacherUser();

            picol = (DataGridViewImageColumn)dtgvTeacher.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < dtgvTeacher.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dtgvTeacher.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dtgvTeacher_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
