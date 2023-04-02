using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_BHQA
{
    public class BUS_QLKH
    {
        DAL_QLKH DAL_QLKH = new DAL_QLKH();

        // Lấy dữ liệu từ lớp DAL
        public DataTable getData()
        {
            return DAL_QLKH.getData();
        }
        // Thêm khách hàng
        public bool ThemKH(KhachHang KH)
        {
            if (DAL_QLKH.ThemKH(KH))
            {
                return true;
            }
            return false;
        }
        // Sửa khách hàng
        public bool SuaKH(KhachHang KH)
        {
            if(DAL_QLKH.SuaKH(KH))
            {
                return true;
            }
            return false;
        }
        // Xóa khách hàng
        public bool XoaKH(KhachHang KH)
        {
            if (DAL_QLKH.XoaKH(KH))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm theo mã KH
        public DataTable TimKiemKH_MaKH(string txtMaKH)
        {
            return DAL_QLKH.TimKiemKH_MaKH(txtMaKH);
        }
        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiemKH_TenKH(string txtMaKH)
        {
            return DAL_QLKH.TimKiemKH_TenKH(txtMaKH);
        }
        // Tìm kiếm theo loại khách hàng
        public DataTable TimKiemKH_LoaiKH(string txtMaKH)
        {
            return DAL_QLKH.TimKiemKH_LoaiKH(txtMaKH);
        }
    }
}
