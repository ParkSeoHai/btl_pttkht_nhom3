namespace DTO_BHQA
{
    public class GioHang
    {
        private string _MaKH;
        private string _MaSP;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }

        public GioHang() { }
        public GioHang(string maKH, string maSP)
        {
            _MaKH = maKH;
            _MaSP = maSP;
        }
    }
}
