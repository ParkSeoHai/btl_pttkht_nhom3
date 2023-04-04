using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_KH_ThemSP
    {
        KhachHang khachHang = new KhachHang();
        public bool khachHangThemSP(SanPham SanPham)
        {
            if (khachHang.ThemSpVaoGioHang(SanPham))
            {
                return true;
            }
            return false;
        }
    }
}
