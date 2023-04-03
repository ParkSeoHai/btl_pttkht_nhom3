using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_QLHD
    {
        DAL_QLHD DAL_QLHD = new DAL_QLHD();
        // Phương thức lấy dữ liệu csdl
        public DataTable getData()
        {
            return DAL_QLHD.getData();
        }
        // Phương thức thêm vào hóa đơn
        public bool ThemHD(HoaDon HD)
        {
            if(DAL_QLHD.ThemHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức sửa hóa đơn
        public bool SuaHD(HoaDon HD)
        {
            if(DAL_QLHD.SuaHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức xóa hóa đơn
        public bool XoaHD(HoaDon HD)
        {
            if (DAL_QLHD.XoaHD(HD))
            {
                return true;
            }
            return false;
        }
        // Phương thức tìm kiếm hóa đơn
        public DataTable TimKiemHD(string fromDate, string toDate)
        {
            return DAL_QLHD.TimKiemHD(fromDate, toDate);
        }
    }
}
