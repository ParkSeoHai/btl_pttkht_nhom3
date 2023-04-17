using System.Data.SqlClient;

namespace DTO_BHQA
{
    interface IKhachHang
    {
        string LayLaiPass(string txtEmail);
        bool QuanLyGioHang(GioHang gioHang, string query);
        bool ThemSpVaoGioHang(GioHang gioHang);
    }
    public class KhachHang : Person, IKhachHang
    {
        private string _MaKH;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public KhachHang() { }
        public KhachHang(string MaKH, string ten, string gioiTinh, string ngaySinh, string diaChi, string sdt) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaKH = MaKH;
        }

        public bool QuanLyGioHang(GioHang gioHang, string query)
        {
            SqlConnection conn = new SqlConnection(DBConnect.connStringHai());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", gioHang.MaKH);
                cmd.Parameters.AddWithValue("MaSP", gioHang.MaSP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        public bool ThemSpVaoGioHang(GioHang gioHang)
        {
            string query = "Insert into GioHang values (@MaKH, @MaSP)";
            if(QuanLyGioHang(gioHang, query))
            {
                return true;
            }
            return false;
        }
        // Lấy lại mk cho khách hàng
        public string LayLaiPass(string txtEmail)
        {
            string Password = "";
            string query = "Select MatKhau from TaiKhoanDangNhap where Email = @Email";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", txtEmail);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                Password = reader.GetString(0);
            }
            conn.Close();
            return Password;
        }
    }
}
