using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BHQA;
using DTO_BHQA;

namespace BUS_BHQA
{
    public class BUS_QLSP
    {
        DAL_QLSP DAL_QLSP = new DAL_QLSP();
        public DataTable GetData()
        {
            return DAL_QLSP.GetData();
        }
        // Thêm sp
        public bool ThemSP(SanPham SP, QuanLySanPham QLSP)
        {
            if(DAL_QLSP.ThemSP(SP, QLSP))
            {
                return true;
            }
            return false;
        }
        // Sửa sp
        public bool SuaSP(SanPham SP)
        {
            if (DAL_QLSP.SuaSP(SP))
            {
                return true;
            }
            return false;
        }
        // Xóa sp
        public bool XoaSP(SanPham SP, QuanLySanPham QLSP)
        {
            if (DAL_QLSP.XoaSP(SP, QLSP))
            {
                return true;
            }
            return false;
        }
        // Tìm kiếm sp
        public DataTable TimKiemSP_MaSP(string txtMaSP)
        {
            DataTable dt = DAL_QLSP.TimKiemSP_MaSP(txtMaSP);
            if(dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable TimKiemSP_GiaSP(string txtGiaSP)
        {
            DataTable dt = DAL_QLSP.TimKiemSP_GiaSP(txtGiaSP);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
