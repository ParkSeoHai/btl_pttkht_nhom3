using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_DangKy
    {
        DAL_DangKy DAL_DangKy = new DAL_DangKy();
        // Thêm tài khoản đăng nhập mới
        public bool DangKyTK(TaiKhoanDangNhap TKDN)
        {
            if(DAL_DangKy.DangKyTK(TKDN))
            {
                return true;
            }
            return false;
        }
        // Kiểm tra random
        public bool Check_MaKH(string txtMaKH)
        {
            if(DAL_DangKy.Check_MaKH(txtMaKH))
            {
                return true;
            }
            return false;
        }
    }
}
