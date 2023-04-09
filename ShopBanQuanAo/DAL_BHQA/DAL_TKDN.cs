using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_TKDN
    {
        // Phương thức kiểm tra tài khoản
        public bool Check_TKDN(string txtTenTK, string txtMK)
        {
            string query = "Select TenTK, MatKhau from TaiKhoanDangNhap";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if(txtTenTK == reader.GetString(0) && txtMK == reader.GetString(1))
                    {
                        return true;
                    }
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Phương thức lấy MaKH
        public string Get_MaKH(string txtTenTK)
        {
            string MaKH = "";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                string query = "SELECT K.MaKH FROM TaiKhoanDangNhap AS T, KHACHHANG AS K "
                + "WHERE T.MaKH = K.MaKH AND K.MaKH IN (SELECT MaKH FROM TaiKhoanDangNhap WHERE TenTK = @TenTK)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("TenTK", txtTenTK);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    MaKH = reader.GetString(0);
                    return MaKH;
                }
            }
            catch { }
            finally { conn.Close() ; }
            return MaKH;
        }
    }
}
