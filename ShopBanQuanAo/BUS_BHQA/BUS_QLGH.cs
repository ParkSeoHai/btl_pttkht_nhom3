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
        public bool ThemSPGioHang(GioHang GioHang)
        {
            if (quanLyGioHang.themSanPhamGioHang(GioHang)) {
                return true;
            }
            return false;
        }
    }
}
