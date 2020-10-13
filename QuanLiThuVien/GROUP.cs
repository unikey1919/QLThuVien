using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien
{
    public class GROUP
    {
        MY_DB db = new MY_DB();

        public DataTable GetListGroup() //lấy danh sách book theo datatable
        {
            string query = "SELECT * FROM dbo.NHOM";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public bool insertGroup(string id, string gname)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.NHOM (groupid, name) VALUES (@id, @gname)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@gname", SqlDbType.NVarChar).Value = gname;
            
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

        public bool groupExist(string name, string operation, string id )
        {
            string query = "";
            SqlCommand cmd = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM dbo.NHOM WHERE name=@name";
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
               
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM dbo.NHOM WHERE name=@name AND groupid <> @id";
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            }
            cmd.Connection = db.getConnection;
            cmd.CommandText = query;
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

        public bool updateGroup(string id, string gname)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.NHOM SET name=@gname WHERE groupid=@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@gname", SqlDbType.NVarChar).Value = gname;

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

        public bool deleteGroup(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.NHOM WHERE groupid=@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
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
    }
}
