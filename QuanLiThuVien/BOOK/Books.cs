using QuanLiThuVien.BOOK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien
{
    public class Books
    {
        MY_DB db = new MY_DB();

        #region SACH
        public DataTable GetListBooks() //lấy danh sách book theo datatable
        {
            string query = "SELECT * FROM dbo.SACH";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public List<BookDTO> GetBookList() // lấy danh sách book theo list để dễ quản lí
        {
            List<BookDTO> list = new List<BookDTO>();
            string query = "SELECT * FROM dbo.SACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BookDTO bookDTO = new BookDTO(item);
                list.Add(bookDTO);
            }
            return list;
        }
        public bool InsertBook(string masach, string tensach, string theloai, string tinhtrang, int soluong, string nxb, string namXB, string tacgia)
        {
            SqlCommand cmd = new SqlCommand("USP_InsertBook", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = theloai;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = nxb;
            cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = namXB;
            cmd.Parameters.Add("@TG", SqlDbType.NVarChar).Value = tacgia;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool DeleteBook(string masach)
        {
            SqlCommand cmd = new SqlCommand("USP_DeleteBook", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool EditBook(string masach, string tensach, string theloai, string tinhtrang, int soluong, string nxb, string namXB, string tacgia)
        {
            SqlCommand cmd = new SqlCommand("USP_EditBook", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = theloai;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SoLuong ", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = nxb;
            cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = namXB;
            cmd.Parameters.Add("@TG", SqlDbType.NVarChar).Value = tacgia;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetListSlSachMuon() //lấy danh sách book theo datatable
        {
            string query = "SELECT MaSach,COUNT(MaThe) AS N'Số Lượng Sách Mượn' FROM dbo.PHIEUMUON GROUP BY MaSach";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        #endregion

        #region SACH_CHO_MUON
        public DataTable GetListSachChoMuon(string mathe) //lấy danh sách book theo datatable cua tung SV
        {
            string query = "SELECT * FROM dbo.TVMUON WHERE MaThe='" + mathe + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetListSachChoMuonTV() //lấy danh sách book theo datatable
        {
            string query = "SELECT * FROM dbo.TVMUON";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertSachChoMuon(string mathe, string tensach, int soluong, DateTime ngaychomuon)
        {
            SqlCommand cmd = new SqlCommand("USP_InsertChoMuonSach", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NgayChoMuon", SqlDbType.Date).Value = ngaychomuon;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }


        public bool DeleteSachChoMuon(string mathe, string tensach)
        {
            SqlCommand cmd = new SqlCommand("USP_DeleteGVchoMuon", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool UpdateSachChoMuon(string mathe, string tensach, int soluong, DateTime ngaychomuon)
        {
            SqlCommand cmd = new SqlCommand("USP_UpdateGVchoMuon", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NgayChoMuon", SqlDbType.Date).Value = ngaychomuon;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        #endregion


        #region SACH_TV_MUON
        public DataTable GetListSachTVDaMuon() //lấy danh sách book theo datatable
        {
            string query = "SELECT * FROM dbo.SACHTVMUON";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertSachTVMuon(string mathe, string masach, string tensach, string theloai, string tinhtrang, int soluong, string nxb, string namXB, string tacgia)
        {
            SqlCommand cmd = new SqlCommand("USP_InsertSACHCHOMUON", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = theloai;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = nxb;
            cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = namXB;
            cmd.Parameters.Add("@TG", SqlDbType.NVarChar).Value = tacgia;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool DeleteSachTvMuon(string mathe, string masach)
        {
            SqlCommand cmd = new SqlCommand("USP_DeleteChoMuonSach", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool EditSachTVMuon(string mathe, string masach, string tensach, string theloai, string tinhtrang, int soluong, string nxb, string namXB, string tacgia)
        {
            SqlCommand cmd = new SqlCommand("USP_EditChoMuonSach", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Mathe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tensach;
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar).Value = theloai;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SoLuong ", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = nxb;
            cmd.Parameters.Add("@NamXB", SqlDbType.NVarChar).Value = namXB;
            cmd.Parameters.Add("@TG", SqlDbType.NVarChar).Value = tacgia;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        #endregion

        #region MUON_TRa
        public DataTable GetListSachDaTra(string mathe)
        {
            string query = "SELECT * FROM dbo.SACHTRATHANHCONG WHERE MaThe= '"+mathe+"'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
      

        public List<SachMuonDTO> GetListSachMuon()
        {
            List<SachMuonDTO> list = new List<SachMuonDTO>();
            string query = "SELECT * FROM dbo.SACHMUON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SachMuonDTO sachMuonDTO = new SachMuonDTO(item);
                list.Add(sachMuonDTO);
            }
            return list;
        }

        #endregion





    }
}
