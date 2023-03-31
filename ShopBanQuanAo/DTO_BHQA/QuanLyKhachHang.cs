using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class QuanLyKhachHang
    {
        private string _MaQL;
        private string _MaKH;

        public string MaQL { get => _MaQL; set => _MaQL = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }

        public QuanLyKhachHang() { }
        public QuanLyKhachHang(string maQL, string maKH)
        {
            _MaQL = maQL;
            _MaKH = maKH;
        }
    }
}
