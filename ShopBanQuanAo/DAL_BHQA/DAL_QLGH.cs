using DTO_BHQA;

namespace DAL_BHQA
{
    public class DAL_QLGH
    {
        KhachHang KH = new KhachHang();
        public bool themSanPhamGioHang(GioHang GioHang)
        {
            if (KH.ThemSpVaoGioHang(GioHang))
            {
                return true;
            }
            return false;
        }
    }
}
