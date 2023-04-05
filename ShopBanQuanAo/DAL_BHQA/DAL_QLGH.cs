using DTO_BHQA;

namespace DAL_BHQA
{
    public class DAL_QLGH
    {
        KhachHang khachHang = new KhachHang();
        public bool themSanPhamGioHang(GioHang GioHang)
        {
            if (khachHang.ThemSpVaoGioHang(GioHang))
            {
                return true;
            }
            return false;
        }

    }
}
