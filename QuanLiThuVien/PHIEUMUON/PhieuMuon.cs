using QuanLiThuVien.PHIEUMUON;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.USER
{
    public class PhieuMuon
    {
        MY_DB db = new MY_DB();
        public DataTable GetListPM(string mathe)
        {
            string query = "SELECT MaPM,PHIEUMUON.MaThe,TenSV AS N'Tên',PHIEUMUON.MaSach,TenSach,NgayMuon FROM dbo.PHIEUMUON,dbo.SACH,dbo.THETHUVIEN WHERE PHIEUMUON.MaThe=THETHUVIEN.MaThe AND PHIEUMUON.MaSach=SACH.MaSach AND PHIEUMUON.MaThe = "+mathe;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }//Lay PM theo mã thẻ

        public DataTable GetPM()
        {
            string query = "SELECT*FROM dbo.PHIEUMUON";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        } //lấy danh sách phiếu mượn

        public DataTable GetMaTheByMaPM(string mapm)
        {

            string query = "SELECT Mathe FROM dbo.PHIEUMUON WHERE MaPM='"+mapm+"'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public List<PhieuMuonDTO> GetMaSach()
        {
            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();
            string query = "SELECT DISTINCT MaSach FROM dbo.PHIEUMUON ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuonDTO phieuMuon = new PhieuMuonDTO(item);
                list.Add(phieuMuon);
            }
            return list;
        } //Lấy danh sách mã sách
        public DataTable GetListSachMuon()
        {
            string query = "SELECT * FROM dbo.SACHMUON";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetListPMfromMaSach(string masach)
        {
            string query = "SELECT MaPM FROM dbo.PHIEUMUON WHERE MaSach = '" + masach +"'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetListSachMuonTheoMaThe(string mathe) //Lấy sách mượn thành công theo mã thẻ
        {
            string query = "SELECT PHIEUMUON.MaPM,PHIEUMUON.MaSach,TinhTrang,SLSachMuon,MaThe,NgayTra,NgayMuon FROM dbo.PHIEUMUON,dbo.SACHMUON WHERE PHIEUMUON.MaPM=SACHMUON.MaPM AND PHIEUMUON.MaSach=SACHMUON.MaSach AND MaThe = '" + mathe + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }


        public bool InsertListSachTra(string mathe,string mapm,string masach,string tinhtrang,int sl,DateTime NgayTra,DateTime NgayHan)
        {
            SqlCommand cmd = new SqlCommand("USP_InsertSACHTRA", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NChar).Value = tinhtrang;
            cmd.Parameters.Add("@SLSachMuon", SqlDbType.Int).Value = sl;
            cmd.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = NgayTra;
            cmd.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = NgayHan;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        
        public int CheckOut(string mapm)
        {
            
                return (int)DataProvider.Instance.ExecuteScalar("SELECT count(MaPM) FROM dbo.SACHTRATHANHCONG WHERE NgayTra>NgayHetHan AND MaPM = '" + mapm + "'");
     
           
        }



       public bool InsertPM(string mapm,string masach,string mathe,DateTime ngaymuon)
        {
            SqlCommand cmd = new SqlCommand("USP_InsertPM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = ngaymuon;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool DeletePM(string mapm)
        {
            SqlCommand cmd = new SqlCommand("USP_DeletePM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool EditPM(string mapm, string masach, string mathe, DateTime ngaymuon)
        {
            SqlCommand cmd = new SqlCommand("USP_EditPM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = ngaymuon;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        
        public bool InsertSM(string masach,string mapm,string tinhtrang,int soluong,DateTime ngaytra)
        {
            SqlCommand cmd = new SqlCommand("InsertSM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SLSachMuon", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NgayTra", SqlDbType.NChar).Value = ngaytra;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool DeleteSM(string masach,string mapm)
        {
            SqlCommand cmd = new SqlCommand("DeleteSM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool EditSM(string masach, string mapm, string tinhtrang, int soluong, DateTime ngaytra)
        {
            SqlCommand cmd = new SqlCommand("EditSM", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NChar).Value = masach;
            cmd.Parameters.Add("@MaPM", SqlDbType.NChar).Value = mapm;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@SLSachMuon", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@NgayTra", SqlDbType.NChar).Value = ngaytra;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }


    }
}
