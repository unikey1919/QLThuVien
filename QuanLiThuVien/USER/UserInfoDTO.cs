using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.USER
{
    public class UserInfoDTO
    {

        public UserInfoDTO(string userName,string maThe,string tenSV,string gioiTinh,DateTime? ngaySinh,string dienThoaiSV,string type,byte[] pic)
        {
            this.UserName = userName;
            this.MaThe = maThe;
            this.TenSV = tenSV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DienThoaiSV = dienThoaiSV;
            this.Type = type;
            this.Pic = pic;
            
        }

        public UserInfoDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString(); ;
            this.MaThe = row["MaThe"].ToString();
            this.TenSV = row["TenSV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.DienThoaiSV = row["DienThoaiSV"].ToString();
            this.Type = row["ChucVu"].ToString();
            this.Pic = (byte[])row["Anh"];
        }


        private byte[] pic;
        private string userName;
        private string maThe;
        private string tenSV;
        private string gioiTinh;
        private DateTime? ngaySinh;
        private string dienThoaiSV;
        private string type;

        public string UserName { get => userName; set => userName = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DienThoaiSV { get => dienThoaiSV; set => dienThoaiSV = value; }
        public string Type { get => type; set => type = value; }
        public byte[] Pic { get => pic; set => pic = value; }
    }
}
