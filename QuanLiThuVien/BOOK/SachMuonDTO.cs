using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.BOOK
{
    public class SachMuonDTO
    {
        public SachMuonDTO(string maPM,string maSach,string tinhTrang,int sLSachMuon,DateTime ngayTra)
        {
            this.MaPM = maPM;
            this.MaSach = maSach;
            this.TinhTrang = tinhTrang;
            this.SLSachMuon1 = sLSachMuon;
            this.NgayTra = ngayTra;

        }

        public SachMuonDTO(DataRow row)
        {
            this.MaPM = row["MaPM"].ToString();
            this.MaSach = row["MaSach"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
            this.SLSachMuon1 =(int)row["SLSachMuon"];
            this.NgayTra = (DateTime)row["NgayTra"];
        }

        private string maPM;
        private string maSach;
        private string tinhTrang;
        private int sLSachMuon;
        private DateTime ngayTra;

        public string MaPM { get => maPM; set => maPM = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
       
        public int SLSachMuon1 { get => sLSachMuon; set => sLSachMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
