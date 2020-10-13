using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien
{
    public class DataProvider
    {
        private static DataProvider instance;

        MY_DB db = new MY_DB();
        //Design patern Singleton
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');//cat chuoi theo khoang trang
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(data);
            return data;

        }
        //khi Isert, ... sẽ trả ra số dòng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');//cat chuoi theo khoang trang
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            db.openConnection();
            data = cmd.ExecuteNonQuery();
            return data;

        }
        //Cần số lượng trả ra, thực hiện query và trả cột đầu tiên của dòng ở trong bảng kq
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');//cat chuoi theo khoang trang
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            db.openConnection();
            data = cmd.ExecuteScalar();
            return data;

        }
    }
}
