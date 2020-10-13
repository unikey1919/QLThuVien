using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.ACCOUNT
{
    public class AccountDTO
    {
        public AccountDTO(string userName,string passWord,string type,string maThe)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Type = type;
            this.MaThe = MaThe;
            

        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.Type = row["Type"].ToString();
            this.MaThe = row["MaThe"].ToString();
            
        }
        private string userName;
        private string passWord;
        private string type;
        private string maThe;
        

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Type { get => type; set => type = value; }
        public string MaThe { get => maThe; set => maThe = value; }
      
    }
}
