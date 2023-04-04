using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO_BHQA
{
    interface IQuanLy
    {
        void DangNhap();
        // Quản lý sản phẩm
        bool QuanLySP(SanPham SP, string query);
        // Thêm vào bảng QLSP
        bool ThemQLSP(QuanLySanPham QLSP, string query);
        // Xóa trong bảng QLSP
        bool XoaQLSP(QuanLySanPham QLSP, string query);
        bool ThemSp(SanPham SP, QuanLySanPham QLSP);
        bool SuaSp(SanPham SP);
        bool XoaSp(SanPham SP, QuanLySanPham QLSP);
        DataTable TimKiemSP_MaSP(string txtMaSP);
        DataTable TimKiemSP_GiaSP(string txtGiaSP);

        // Quản lý khách hàng
        bool QuanLyKH(KhachHang KH, string query);
        // Thêm vào bảng QLKH
        bool ThemQLKH(QuanLyKhachHang QLKH, string query);
        // Xóa trong bảng QLKH
        bool XoaQLKH(QuanLyKhachHang QLKH, string query);
        bool ThemKH(KhachHang KH, QuanLyKhachHang QLKH);
        bool SuaKH(KhachHang KH);
        bool XoaKH(KhachHang KH, QuanLyKhachHang QLKH);
        DataTable TimKiem(string query, string variable, string txtTimKiem);
        DataTable TimKiemKH_MaKH(string txtMaKH);
        DataTable TimKiemKH_TenKH(string txtTenKH);
        DataTable TimKiemKH_LoaiKH(string txtLoaiKH);

        // Quản lý hóa đơn
        bool QuanLyHD(HoaDon HD, string query);
        bool ThemHD(HoaDon HD);
        bool SuaHD(HoaDon HD);
        bool XoaHD(HoaDon HD);
        DataTable TimKiemHD(string fromDate, string toDate);

        // Thống kê
        void ThongKeSpBanChay();
        void ThongKeDonDatHang();
        void ThongKeSpMoi();
    }
    public class QuanLy : Person, IQuanLy
    {
        private string _MaQL;
        public string MaKH { get => _MaQL; set => _MaQL = value; }
        public QuanLy() { }
        public QuanLy(string MaQL, string ten, string ngaySinh, string diaChi, string sdt, string gioiTinh) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaQL = MaQL;
        }

        public void DangNhap() { }
        // Phương thức thêm bảng quản lý sản phẩm
        public bool ThemQLSP(QuanLySanPham QLSP, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaQL", QLSP.MaQL);
                cmd.Parameters.AddWithValue("MaSP", QLSP.MaSP);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa sp
        public bool XoaQLSP(QuanLySanPham QLSP, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaSP", QLSP.MaSP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Phương thức thêm, sửa, xóa sản phẩm chung
        public bool QuanLySP(SanPham SP, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaSP", SP.MaSp);
                cmd.Parameters.AddWithValue("TenSP", SP.TenSp);
                cmd.Parameters.AddWithValue("GiaSP", SP.GiaSp);
                cmd.Parameters.AddWithValue("DonViTinh", SP.DonViTinh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Phương thức thêm sản phẩm
        public bool ThemSp(SanPham SP, QuanLySanPham QLSP) {
            string queryInsert = "Insert into SanPham values (@MaSP, @TenSP, @GiaSP, @DonViTinh)";
            string queryInsertQLSP = "Insert into QuanLySanPham values (@MaQL, @MaSP)";
            if(QuanLySP(SP, queryInsert) && ThemQLSP(QLSP, queryInsertQLSP))
            {
                return true;
            }
            return false;
        }
        // Phương thức sửa sản phẩm
        public bool SuaSp(SanPham SP) {
            string queryUpdate = "Update SanPham set TenSP = @TenSP, GiaSP = @GiaSP, DonViTinh = @DonViTinh where MaSP = @MaSP";
            if(QuanLySP(SP, queryUpdate))
            {
                return true;
            }
            return false;
        }
        // Phương thức xóa sản phẩm
        public bool XoaSp(SanPham SP, QuanLySanPham QLSP) {
            string queryDelete = "Delete SanPham where MaSP = @MaSP";
            string queryDeleteQLSP = "Delete QuanLySanPham where MaSP = @MaSP";
            if (XoaQLSP(QLSP, queryDeleteQLSP) && QuanLySP(SP, queryDelete))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm sp
        public DataTable TimKiemSP_MaSP(string txtMaSP)
        {
            string querySelectMaKH = "Select * from SanPham where MaSP = @MaSP";
            return TimKiem(querySelectMaKH, "MaSP", txtMaSP);
        }
        public DataTable TimKiemSP_GiaSP(string txtGiaSP)
        {
            string querySelectGiaSP = "Select * from SanPham where GiaSP = @GiaSP";
            return TimKiem(querySelectGiaSP, "GiaSP", txtGiaSP);
        }

        // Thêm vào bảng QLKH
        public bool ThemQLKH(QuanLyKhachHang QLKH, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaQL", QLKH.MaQL);
                cmd.Parameters.AddWithValue("MaKH", QLKH.MaKH);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa trong bảng QLKH
        public bool XoaQLKH(QuanLyKhachHang QLKH, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", QLKH.MaKH);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Phương thức quản lý khách hàng chung
        public bool QuanLyKH(KhachHang KH, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", KH.MaKH);
                cmd.Parameters.AddWithValue("HoTen", KH.ten);
                cmd.Parameters.AddWithValue("GioiTinh", KH.gioiTinh);
                cmd.Parameters.AddWithValue("NgaySinh", KH.ngaySinh);
                cmd.Parameters.AddWithValue("DiaChi", KH.diaChi);
                cmd.Parameters.AddWithValue("SDT", KH.sdt);
                cmd.Parameters.AddWithValue("LoaiKH", KH.LoaiKH);
                cmd.Parameters.AddWithValue("SoTien", KH.SoTien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Thêm khách hàng
        public bool ThemKH(KhachHang KH, QuanLyKhachHang QLKH) {
            string queryInsert = "Insert into KhachHang values (@MaKH, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @LoaiKH, @SoTien)";
            string queryInsertQLKH = "Insert into QuanLyKhachHang values (@MaQL, @MaKH)";
            if(QuanLyKH(KH, queryInsert) && ThemQLKH(QLKH, queryInsertQLKH))
            {
                return true;
            }
            return false;
        }
        // Sửa khách hàng
        public bool SuaKH(KhachHang KH) {
            string queryUpdate = "Update KhachHang set HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, LoaiKH = @LoaiKH, SoTien = @SoTien WHERE MaKH = @MaKH";
            if(QuanLyKH(KH, queryUpdate))
            {
                return true;
            }
            return false;
        }
        // Xóa khách hàng
        public bool XoaKH(KhachHang KH, QuanLyKhachHang QLKH) {
            string queryDelete = "Delete KhachHang where MaKH = @MaKH";
            string queryDeleteQLKH = "Delete QuanLyKhachHang where MaKH = @MaKH";
            if(XoaQLKH(QLKH, queryDeleteQLKH) && QuanLyKH(KH, queryDelete))
            {
                return true;
            }
            return false;
        }
        // Hàm tìm kiếm chung(dùng cho tìm khách hàng, tìm sản phẩm):
        // Hàm nhận 3 tham số lần lượt là (Câu lệnh truy vấn, Biến trong lệnh điều kiện, giá trị cần tìm)
        public DataTable TimKiem(string query, string variable, string txtTimKiem)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue($"{variable}", txtTimKiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch { }
            finally { conn.Close(); }
            if (dt.Rows.Count <= 0)
            {
                dt = null;
            }
            return dt;
        }
        // Tìm kiếm Khách hàng theo mã kh
        public DataTable TimKiemKH_MaKH(string txtMaKH)
        {
            string querySelectMaKH = "Select * from KhachHang where MaKH = @MaKH";
            return TimKiem(querySelectMaKH, "MaKH", txtMaKH);
        }
        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiemKH_TenKH(string txtTenKH)
        {
            string queryTimKiemTenKH = "Select * from KhachHang where HoTen = @HoTen";
            return TimKiem(queryTimKiemTenKH, "HoTen", txtTenKH);
        }
        // Tìm kiếm theo loại khách hàng
        public DataTable TimKiemKH_LoaiKH(string txtLoaiKH)
        {
            string querySelectMaKH = "Select * from KhachHang where LoaiKH = @LoaiKH";
            return TimKiem(querySelectMaKH, "LoaiKH", txtLoaiKH);
        }

        // Quản lý hóa đơn
        public bool QuanLyHD(HoaDon HD, string query)
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", HD.MaKH);
                cmd.Parameters.AddWithValue("MaSP", HD.MaSP);
                cmd.Parameters.AddWithValue("NgayMua", HD.NgayMua);
                cmd.Parameters.AddWithValue("SoLuong", HD.SoLuong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        public bool ThemHD(HoaDon HD)
        {
            string queryInsert = "Insert into HoaDon values (@MaKH, @MaSP, @NgayMua, @SoLuong)";
            if(QuanLyHD(HD, queryInsert))
            {
                return true;
            }
            return false;
        }
        public bool SuaHD(HoaDon HD)
        {
            string queryUpdate = "Update HoaDon set NgayMua = @NgayMua, SoLuong = @SoLuong where MaKH = @MaKH and MaSP = @MaSP";
            if(QuanLyHD(HD,queryUpdate))
            {
                return true;
            }
            return false;
        }
        public bool XoaHD(HoaDon HD)
        {
            string queryDelete = "Delete HoaDon where MaKH = @MaKH and MaSP = @MaSP";
            if(QuanLyHD(HD, queryDelete))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm hóa đơn
        public DataTable TimKiemHD(string fromDate, string toDate)
        {
            string querySelectNgayMua = "Select * from HoaDon where NgayMua BETWEEN @fromDate AND @toDate";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querySelectNgayMua, conn);
                cmd.Parameters.AddWithValue("fromDate", fromDate);
                cmd.Parameters.AddWithValue("toDate", toDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public void ThongKeSpBanChay() { }
        public void ThongKeDonDatHang() { }
        public void ThongKeSpMoi() { }
    }
}
