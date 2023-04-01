using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BHQA;

namespace DAL_BHQA
{
    public class DAL_QLKH : DBConnect
    {
        QuanLy QuanLy = new QuanLy();

        // Lấy dữ liệu từ bảng khách hàng
        public DataTable getData()
        {
            string query = "Select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connStringHai);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool ThemKH(KhachHang KH)
        {
            if(QuanLy.ThemKH(KH))
            {
                return true;
            }
            return false;
        }
    }
}
