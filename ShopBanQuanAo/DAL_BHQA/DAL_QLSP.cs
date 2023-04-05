using DTO_BHQA;
using System.Data;
using System.Data.SqlClient;

namespace DAL_BHQA
{
    public class DAL_QLSP
    {
        QuanLy QuanLy = new QuanLy();
        public DataTable GetData()
        {
            string querySelect = "Select * from SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, DBConnect.chuoiKetNoiCua_Hai());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Thêm sp
        public bool ThemSP(SanPham SP, QuanLySanPham QLSP)
        {
            if (QuanLy.ThemSp(SP, QLSP))
            {
                return true;
            }
            return false;
        }
        // Sửa sp
        public bool SuaSP(SanPham SP)
        {
            if (QuanLy.SuaSp(SP))
            {
                return true;
            }
            return false;
        }
        // Xóa sp
        public bool XoaSP(SanPham SP, QuanLySanPham QLSP)
        {
            if (QuanLy.XoaSp(SP, QLSP))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm
        public DataTable TimKiemSP_MaSP(string txtMaSP)
        {
            return QuanLy.TimKiemSP_MaSP(txtMaSP);
        }
        public DataTable TimKiemSP_GiaSP(string txtGiaSP)
        {
            return QuanLy.TimKiemSP_GiaSP(txtGiaSP);
        }
    }
}
