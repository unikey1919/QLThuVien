using QuanLiThuVien.ACCOUNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien
{
    public class Account
    {
        MY_DB db = new MY_DB();
        public bool Login(string userName, string passWord)
        {
            string query = " USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public AccountDTO GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public bool DeleteAccount(string mathe)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Account WHERE MaThe=@mathe", db.getConnection);
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool InsertAccount(string mathe,string username,string password,string chucvu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Account( UserName, PassWord, type, MaThe ) VALUES ( @uname, @pass, @type, @mathe)", db.getConnection);
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            cmd.Parameters.Add("@uname", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = chucvu;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool MaTheExist(string mathe)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Account WHERE MaThe = @mathe", db.getConnection);
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateAccount(string username,string password,string newpass,string chucvu)
        {
            SqlCommand cmd = new SqlCommand("USP_UpdateAccount", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucvu;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@newpass", SqlDbType.NVarChar).Value = newpass;
            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
