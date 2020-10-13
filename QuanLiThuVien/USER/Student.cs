using QuanLiThuVien.USER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLiThuVien.STUDENT
{
    public class Student
    {
        MY_DB db = new MY_DB();
        public DataTable GetListStudnetUser()
        {
            string query = "SELECT MaThe AS N'Mã Thẻ', TenSV AS N'Tên', Gioitinh AS N'Giới Tính', NgaySinh AS N'Ngày Sinh', DiaChiSV AS N'Địa chỉ', DienThoaiSV AS N'Điện Thoại', NgayTao AS N'Ngày Tạo', NgayHetHan AS N'Ngày Hết Hạn', ChucVu AS N'Chức Vụ', Anh AS N'Ảnh' FROM dbo.THETHUVIEN";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetListTeacherUser()
        {
            string query = "SELECT MaThe AS N'Mã Thẻ', TenSV AS N'Tên', Gioitinh AS N'Giới Tính', NgaySinh AS N'Ngày Sinh', DiaChiSV AS N'Địa chỉ', DienThoaiSV AS N'Điện Thoại', NgayTao AS N'Ngày Tạo', NgayHetHan AS N'Ngày Hết Hạn', ChucVu AS N'Chức Vụ', Anh AS N'Ảnh' FROM dbo.THETHUVIEN WHERE ChucVu=N'Giáo Viên'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetListStudnetUserByID(string Mathe)
        {
            string query = "SELECT * FROM dbo.THETHUVIEN WHERE MaThe='"+Mathe+"'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetListStudnetUserSV()
        {
            string query = "SELECT * FROM dbo.THETHUVIEN WHERE ChucVu=N'Sinh Viên'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertStudentUser(string mathe, string tensv,string gioitinh, DateTime ngaysinh, string diachi,string dienthoai,DateTime ngaytao,DateTime ngayhethan,string chucvu, MemoryStream pic)
        {
           
            SqlCommand cmd = new SqlCommand("exec USP_InsertStudentUser @MaThe, @TenSV, @Gioitinh, @NgaySinh, @DiaChiSV, @DienThoai, @NgayTao, @NgayHetHan, @ChucVu, @Anh",db.getConnection);
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = tensv;
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = gioitinh;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@DiaChiSV", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = dienthoai;
            cmd.Parameters.Add("@NgayTao", SqlDbType.Date).Value = ngaytao;
            cmd.Parameters.Add("@NgayHetHan", SqlDbType.Date).Value = ngayhethan;
            cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = chucvu;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool DeleteStudentUser(string mathe)
        {
            SqlCommand cmd = new SqlCommand("exec USP_DeleteStudentUSer @mathe", db.getConnection);
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool EditStudentUser(string mathe, string tensv, string gioitinh, DateTime ngaysinh, string diachi, string dienthoai, DateTime ngaytao, DateTime ngayhethan,string chucvu,MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("exec USP_UpdateStudentUser @MaThe, @TenSV, @Gioitinh, @NgaySinh, @DiaChiSV, @DienThoai, @NgayTao, @NgayHetHan, @ChucVu,  @Anh", db.getConnection);
            cmd.Parameters.Add("@MaThe", SqlDbType.NChar).Value = mathe;
            cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = tensv;
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = gioitinh;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@DiaChiSV", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = dienthoai;
            cmd.Parameters.Add("@NgayTao", SqlDbType.Date).Value = ngaytao;
            cmd.Parameters.Add("@NgayHetHan", SqlDbType.Date).Value = ngayhethan;
            cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = chucvu;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public List<UserInfoDTO> GetUserInFo(string mathe)
        {
            List<UserInfoDTO> listUserInfo = new List<UserInfoDTO>();
            string query = "SELECT UserName, THETHUVIEN.MaThe, TenSV, Gioitinh, NgaySinh, DienThoaiSV, dbo.THETHUVIEN.ChucVu, dbo.THETHUVIEN.Anh FROM dbo.Account, dbo.THETHUVIEN WHERE THETHUVIEN.MaThe = Account.MaThe AND THETHUVIEN.MaThe = '" + mathe + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dataTable.Rows)
            {
                UserInfoDTO info = new UserInfoDTO(item);
                listUserInfo.Add(info);

            }
            return listUserInfo;
        }

    }
}
