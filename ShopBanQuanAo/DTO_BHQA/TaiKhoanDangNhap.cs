namespace DTO_BHQA
{
    public class TaiKhoanDangNhap
    {
        private string _TenTK;
        private string _MK;
        private string _Email;
        private string _MaKH;

        public string TenTK { get => _TenTK; set => _TenTK = value; }
        public string MK { get => _MK; set => _MK = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }

        public TaiKhoanDangNhap() { }
        public TaiKhoanDangNhap(string tenTK, string mk, string email, string maKH)
        {
            _TenTK = tenTK;
            _MK = mk;
            _Email = email;
            _MaKH = maKH;
        }
    }
}
