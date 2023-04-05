using DTO_BHQA;

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
