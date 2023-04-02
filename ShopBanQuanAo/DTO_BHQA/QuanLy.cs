using System;
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
        void ThemSp();
        void SuaSp();
        void XoaSp();
        bool ThemKH(KhachHang KH);
        bool SuaKH(KhachHang KH);
        bool XoaKH(KhachHang KH);
        DataTable TimKiemKH(string query, string variable, string txtTimKiem);
        DataTable TimKiemKH_MaKH(string txtMaKH);
        DataTable TimKiemKH_TenKH(string txtTenKH);
        DataTable TimKiemKH_LoaiKH(string txtLoaiKH);
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
        public void ThemSp() { }
        public void SuaSp() { }
        public void XoaSp() { }
        // Thêm khách hàng
        public bool ThemKH(KhachHang KH) {
            string queryInsert = "Insert into KhachHang values (@MaKH, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @LoaiKH, @SoTien)";
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
        // Sửa khách hàng
        public bool SuaKH(KhachHang KH) {
            string queryUpdate = "Update KhachHang set HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, LoaiKH = @LoaiKH, SoTien = @SoTien WHERE MaKH = @MaKH";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
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
        // Xóa khách hàng
        public bool XoaKH(KhachHang KH) {
            string queryDelete = "Delete KhachHang where MaKH = @MaKH";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryDelete, conn);
                cmd.Parameters.AddWithValue("MaKH", KH.MaKH);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Hàm tìm kiếm khách hàng chung: Hàm nhận 3 tham số lần lượt là (Câu lệnh truy vấn, Biến trong lệnh điều kiện, giá trị cần tìm)
        public DataTable TimKiemKH(string query, string variable, string txtTimKiem)
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
            return TimKiemKH(querySelectMaKH, "MaKH", txtMaKH);
        }
        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiemKH_TenKH(string txtTenKH)
        {
            string queryTimKiemTenKH = "Select * from KhachHang where HoTen = @HoTen";
            return TimKiemKH(queryTimKiemTenKH, "HoTen", txtTenKH);
        }
        // Tìm kiếm theo loại khách hàng
        public DataTable TimKiemKH_LoaiKH(string txtLoaiKH)
        {
            string querySelectMaKH = "Select * from KhachHang where LoaiKH = @LoaiKH";
            return TimKiemKH(querySelectMaKH, "LoaiKH", txtLoaiKH);
        }
        public void ThongKeSpBanChay() { }
        public void ThongKeDonDatHang() { }
        public void ThongKeSpMoi() { }
    }
}
