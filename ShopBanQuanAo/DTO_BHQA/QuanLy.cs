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
        KhachHang TimKiemKH_MaKH(string MaKH);
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
        // Tìm kiếm Khách hàng theo mã kh
        public KhachHang TimKiemKH_MaKH(string MaKH)
        {
            KhachHang KH = new KhachHang();
            string querySelectMaKH = $"Select * from KhachHang where MaKH = {MaKH}";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querySelectMaKH, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KH.MaKH = reader.GetString(0);
                    KH.ten = reader.GetString(1);
                    KH.gioiTinh = reader.GetString(2);
                    KH.ngaySinh = reader.GetString(3);
                    KH.diaChi = reader.GetString(4);
                    KH.sdt = reader.GetString(5);
                    KH.LoaiKH = reader.GetString(6);
                    KH.SoTien = reader.GetDouble(7);
                }
            }
            catch { }
            finally { conn.Close(); }
            return KH;
        }
        public void ThongKeSpBanChay() { }
        public void ThongKeDonDatHang() { }
        public void ThongKeSpMoi() { }
    }
}
