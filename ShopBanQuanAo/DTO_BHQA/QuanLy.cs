using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BHQA
{
    interface IQuanLy
    {
        void DangNhap();
        void ThemSp();
        void SuaSp();
        void XoaSp();
        void ThemKH();
        void SuaKH();
        void XoaKH();
        void ThongKeSpBanChay();
        void ThongKeDonDatHang();
        void ThongKeSpMoi();
    }
    public class QuanLy : Person
    {
        private string _MaQL;

        public string MaKH { get => _MaQL; set => _MaQL = value; }
        public QuanLy() { }
        public QuanLy(string MaQL, string ten, string ngaySinh, string diaChi, string sdt, string gioiTinh) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaQL = MaQL;
        }

        public void DangNhap() { }
        public void ThemSp() { }
        public void SuaSp() { }
        public void XoaSp() { }
        public void ThemKH() { }
        public void SuaKH() { }
        public void XoaKH() { }
        public void ThongKeSpBanChay() { }
        public void ThongKeDonDatHang() { }
        public void ThongKeSpMoi() { }
    }
}
