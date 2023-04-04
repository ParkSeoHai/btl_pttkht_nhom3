using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_QLHD
    {
        QuanLy QuanLy = new QuanLy();
        // Phương thức lấy dữ liệu từ csdl
        public DataTable getData()
        {
            string query = "Select * from HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DBConnect.chuoiKetNoiCua_Hai());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Phương thức thêm hóa đơn
        public bool ThemHD(HoaDon HD)
        {
            if(QuanLy.ThemHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức sửa hóa đơn
        public bool SuaHD(HoaDon HD)
        {
            if(QuanLy.SuaHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức xóa hóa đơn
        public bool XoaHD(HoaDon HD)
        {
            if (QuanLy.XoaHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức tìm kiếm hóa đơn
        public DataTable TimKiemHD(string fromDate, string toDate)
        {
            return QuanLy.TimKiemHD(fromDate, toDate);
        }
    }
}
