using DAL_BHQA;
using DTO_BHQA;

namespace BUS_BHQA
{
    public class BUS_QLGH
    {
        DAL_QLGH quanLyGioHang = new DAL_QLGH();
        public bool ThemSPGioHang(GioHang GioHang)
        {
            if (quanLyGioHang.themSanPhamGioHang(GioHang))
            {
                return true;
            }
            return false;
        }
    }
}
