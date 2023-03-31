using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class HoaDon
    {
        private string _MaKH;
        private string _MaSP;
        private string _NgayMua;
        private int _SoLuong;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string NgayMua { get => _NgayMua; set => _NgayMua = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }

        public HoaDon() { }
        public HoaDon(string maKH, string maSP, string ngayMua, int soLuong)
        {
            _MaKH = maKH;
            _MaSP = maSP;
            _NgayMua = ngayMua;
            _SoLuong = soLuong;
        }
    }
}
