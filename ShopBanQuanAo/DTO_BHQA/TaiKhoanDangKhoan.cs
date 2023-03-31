using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    public class TaiKhoanDangKhoan
    {
        private string _IDTK;
        private string _MaKH;
        private string _TenTK;
        private string _MatKhau;

        public string IDTK { get => _IDTK; set => _IDTK = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenTK { get => _TenTK; set => _TenTK = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }

        public TaiKhoanDangKhoan() { }
        public TaiKhoanDangKhoan(string iDTK, string maKH, string tenTK, string matKhau)
        {
            _IDTK = iDTK;
            _MaKH = maKH;
            _TenTK = tenTK;
            _MatKhau = matKhau;
        }
    }
}
