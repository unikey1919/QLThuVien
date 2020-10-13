using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien
{
    public class ThongKe
    {
        public DataTable GetListChucVu() //lấy danh sách book theo datatable
        {
            string query = "USP_ChucVu";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetListSLChucVu() //lấy danh sách book theo datatable
        {
            string query = "SELECT ChucVu, COUNT(MaThe) AS N'Số Lượng User' FROM dbo.THETHUVIEN  GROUP BY ChucVu";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetMaxMin(string query) //lấy danh sách book theo datatable
        {
            
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }



        public int GetTongSo(string query)
        {
            try
            {
                
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                return 1;
            }

        }

     





    }


}
