using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.PHIEUMUON
{
    public class PhieuMuonDTO
    {
        public PhieuMuonDTO(string maPm,string maSach,string maThe,DateTime ngayMuon)
        {
            this.MaPm = maPm;
            this.MaSach = maSach;
            this.MaThe = maThe;
            this.NgayMuon = ngayMuon;
        }

        public PhieuMuonDTO(DataRow row)
        {
            
            this.MaSach = row["MaSach"].ToString();
          
            
        }
        private string maPm;
        private string maSach;
        private string maThe;
        private DateTime ngayMuon;

        public string MaPm { get => maPm; set => maPm = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
    }
}
