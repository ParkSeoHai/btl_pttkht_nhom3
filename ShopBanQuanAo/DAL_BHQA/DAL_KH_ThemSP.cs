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
        public bool khachHangThemSP(GioHang gioHang)
        {
            if (khachHang.ThemSpVaoGioHang(gioHang))
            {
                return true;
            }
            return false;
        }
    }
}
