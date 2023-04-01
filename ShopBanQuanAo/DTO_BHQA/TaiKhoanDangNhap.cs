using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class TaiKhoanDangNhap
    {
        private string _MaKH;
        private string _TenTK;
        private string _MatKhau;
        private string _Email;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenTK { get => _TenTK; set => _TenTK = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string Email { get => _Email; set => _Email = value; }

        public TaiKhoanDangNhap() { }
        public TaiKhoanDangNhap(string tenTK, string matKhau, string email, string MaKH)
        {
            _TenTK = tenTK;
            _MatKhau = matKhau;
            _Email = email;
            _MaKH = MaKH;
        }
    }
}
