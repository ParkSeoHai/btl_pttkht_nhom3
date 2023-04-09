using System.Drawing.Printing;

namespace DTO_BHQA
{
    public class SanPham
    {
        private string _MaSp;
        private string _TenSp;
        private double _GiaSp;
        private string _NgayThem;
        private int _GiamGia;
        private string _UrlImg;

        public string MaSp { get => _MaSp; set => _MaSp = value; }
        public string TenSp { get => _TenSp; set => _TenSp = value; }
        public double GiaSp { get => _GiaSp; set => _GiaSp = value; }
        public string NgayThem { get => _NgayThem; set => _NgayThem = value; }
        public int GiamGia { get => _GiamGia; set => _GiamGia = value; }
        public string UrlImg { get => _UrlImg; set => _UrlImg = value; }

        public SanPham() { }
        public SanPham(string maSp, string tenSp, double giaSp, string ngayThem, int giamGia, string urlImg)
        {
            _MaSp = maSp;
            _TenSp = tenSp;
            _GiaSp = giaSp;
            _NgayThem = ngayThem;
            _GiamGia = giamGia;
            _UrlImg = urlImg;
        }
    }
}
