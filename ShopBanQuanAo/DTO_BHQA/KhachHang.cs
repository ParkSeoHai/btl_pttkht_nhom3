using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    interface IKhachHang
    {
        void DangNhap();
        void DangKy();
        void ThemSpVaoGioHang();
        void SuaSpTrongGioHang();
        void XoaSpTrongGioHang();
        void TimKiemSp();
        void MuaHang();
        void DatHang();
        void ThanhToan();
    }
    public class KhachHang : Person, IKhachHang
    {
        private string _MaKH;
        private string _LoaiKH;
        private double _SoTien;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string LoaiKH { get => _LoaiKH; set => _LoaiKH = value; }
        public double SoTien { get => _SoTien; set => _SoTien = value; }
        public KhachHang() { }
        public KhachHang(string MaKH, string ten, string ngaySinh, string diaChi, string sdt, string gioiTinh, string LoaiKH, double SoTien) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaKH = MaKH;
            _LoaiKH = LoaiKH;
            _SoTien = SoTien;
        }

        public void DangNhap() { }
        public void DangKy() { }
        public void ThemSpVaoGioHang() { }
        public void SuaSpTrongGioHang() { }
        public void XoaSpTrongGioHang() { }
        public void TimKiemSp() { }
        public void MuaHang() { }
        public void DatHang() { }
        public void ThanhToan() { }
    }
}
