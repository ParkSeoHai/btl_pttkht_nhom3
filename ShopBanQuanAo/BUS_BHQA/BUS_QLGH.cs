using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class BUS_QLGH
    {
        private DAL_QLGH quanLyGioHang;
        public bool ThemSPGioHang(SanPham sanPham)
        {
            if (quanLyGioHang.themSanPhamGioHang(sanPham)) {
                return true;
            }
            return false;
        }
    }
}
