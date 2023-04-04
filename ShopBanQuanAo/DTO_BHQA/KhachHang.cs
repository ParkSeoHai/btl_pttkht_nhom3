using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DTO_BHQA
{
    interface IKhachHang
    {
        void DangNhap();
        void DangKy();
        bool ThemSpVaoGioHang(SanPham sanPham);
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
        public KhachHang(string MaKH, string ten, string gioiTinh, string ngaySinh, string diaChi, string sdt, string LoaiKH, double SoTien) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaKH = MaKH;
            _LoaiKH = LoaiKH;
            _SoTien = SoTien;
        }

        public void DangNhap() { }
        public void DangKy() { }
        public bool ThemSpVaoGioHang(SanPham sanPham) {
            string s = $"insert into SANPHAM values('{sanPham.MaSp}', N'{sanPham.TenSp}', {sanPham.GiaSp}, N'{sanPham.DonViTinh}')";
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = s;
            sqlCMD.Connection = DBConnect.chuoiKetNoiCua_XuanManh();
            int check = sqlCMD.ExecuteNonQuery();
            if (check > 0)
            {
                return true;
            }
            return false;
        }
        public void SuaSpTrongGioHang() { }
        public void XoaSpTrongGioHang() { }
        public void TimKiemSp() { }
        public void MuaHang() { }
        public void DatHang() { }
        public void ThanhToan() { }
    }
}
