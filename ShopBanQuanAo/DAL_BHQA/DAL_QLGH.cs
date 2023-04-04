using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BHQA
{
    public class DAL_QLGH
    {
        private KhachHang khachHang;
        public bool themSanPhamGioHang(SanPham sanPham)
        {
            if (khachHang.ThemSpVaoGioHang(sanPham))
            {
                return true;
            }
            return false;
        }
        
    }
}
