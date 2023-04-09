using DTO_BHQA;
using System.Data;
using System.Data.SqlClient;

namespace DAL_BHQA
{
    public class DAL_QLKH : DBConnect
    {
        QuanLy QuanLy = new QuanLy();

        // Lấy dữ liệu từ bảng khách hàng
        public DataTable getData()
        {
            string query = "Select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connStringHai());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Thêm khách hàng
        public bool ThemKH(KhachHang KH, QuanLyKhachHang QLKH)
        {
            if (QuanLy.ThemKH(KH, QLKH))
            {
                return true;
            }
            return false;
        }
        // Sửa khách hàng
        public bool SuaKH(KhachHang KH)
        {
            if (QuanLy.SuaKH(KH))
            {
                return true;
            }
            return false;
        }
        // Xóa khách hàng
        public bool XoaKH(KhachHang KH, QuanLyKhachHang QLKH)
        {
            if (QuanLy.XoaKH(KH, QLKH))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm khách hàng theo mã kh
        public DataTable TimKiemKH_MaKH(string txtMaKH)
        {
            return QuanLy.TimKiemKH_MaKH(txtMaKH);
        }
        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiemKH_TenKH(string txtMaKH)
        {
            return QuanLy.TimKiemKH_TenKH(txtMaKH);
        }
    }
}
