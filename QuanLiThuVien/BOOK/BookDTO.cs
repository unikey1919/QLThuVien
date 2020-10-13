using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.BOOK
{
    public class BookDTO
    {

        public BookDTO(string maSach,string tenSach,string theLoai,string tinhTrang,int soLuong,string nXB,string namXB,string tG)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.TheLoai = theLoai;
            this.TinhTrang = tinhTrang;
            this.SoLuong = soLuong;
            this.NXB = nXB;
            this.NamXB = namXB;
            this.TG = tG;
        }

        public BookDTO(DataRow row)
        {
            this.MaSach = row["MaSach"].ToString(); ;
            this.TenSach = row["TenSach"].ToString() ;
            this.TheLoai = row["TheLoai"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.NXB = row["NXB"].ToString();
            this.NamXB = row["NamXB"].ToString();
            this.TG = row["TG"].ToString();
        }

        private string maSach;
        private string tenSach;
        private string theLoai;
        private string tinhTrang;
        private int soLuong;
        private string nXB;
        private string namXB;
        private string tG;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string NXB { get => nXB; set => nXB = value; }
        public string NamXB { get => namXB; set => namXB = value; }
        public string TG { get => tG; set => tG = value; }
    }
}
