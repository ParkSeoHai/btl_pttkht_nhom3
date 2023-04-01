using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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
        public bool ThemKH(KhachHang KH) {
            string queryInsert = "Insert into KhachHang values (@MaKH, @Ten, @NgaySinh, @DiaChi, @SDT, @GioiTinh, @LoaiKH, @SoTien)";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("MaKH", KH.MaKH);
                cmd.Parameters.AddWithValue("Ten", KH.ten);
                cmd.Parameters.AddWithValue("NgaySinh", KH.ngaySinh);
                cmd.Parameters.AddWithValue("DiaChi", KH.diaChi);
                cmd.Parameters.AddWithValue("SDT", KH.sdt);
                cmd.Parameters.AddWithValue("GioiTinh", KH.gioiTinh);
                cmd.Parameters.AddWithValue("LoaiKH", KH.LoaiKH);
                cmd.Parameters.AddWithValue("SoTien", KH.SoTien);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        public void SuaKH() { }
        public void XoaKH() { }
        public void ThongKeSpBanChay() { }
        public void ThongKeDonDatHang() { }
        public void ThongKeSpMoi() { }
    }
}
