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
    public partial class frmSachDaTra : Form
    {
        Books books = new Books();
        private string mathe;
        public frmSachDaTra(string mathe)
        {
            this.Mathe = mathe;
            InitializeComponent();
            LoadSachDaTraByMaThe(mathe);
        }

        public string Mathe { get => mathe; set => mathe = value; }

        void LoadSachDaTraByMaThe(string mathe)
        {
            dtgvListSachTra.DataSource = books.GetListSachDaTra(mathe);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
