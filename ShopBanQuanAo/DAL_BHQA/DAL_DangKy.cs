using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_DangKy
    {
        // Phương thức thêm tài khoản đăng nhập khi đăng ký
        public bool DangKyTK(TaiKhoanDangNhap TKDN)
        {
            string query = "Insert into TaiKhoanDangNhap values (@TenTK, @MatKhau, @Email, @MaKH)";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("TenTK", TKDN.TenTK);
                cmd.Parameters.AddWithValue("MatKhau", TKDN.MK);
                cmd.Parameters.AddWithValue("Email", TKDN.Email);
                cmd.Parameters.AddWithValue("MaKH", TKDN.MaKH);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Phương thức kiểm tra mã tài khoản random đã tồn tại hay chưa
        public bool Check_MaKH(string txtMaTK)
        {
            string query = "Select MaKH from TaiKhoanDangNhap where MaKH = @MaKH";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", txtMaTK);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) { 
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
    }
}
