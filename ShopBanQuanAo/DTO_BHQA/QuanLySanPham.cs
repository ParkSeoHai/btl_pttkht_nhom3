namespace DTO_BHQA
{
    public class QuanLySanPham
    {
        private string _MaQL;
        private string _MaSP;

        public string MaQL { get => _MaQL; set => _MaQL = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }

        public QuanLySanPham() { }
        public QuanLySanPham(string maQL, string maSP)
        {
            _MaQL = maQL;
            _MaSP = maSP;
        }
    }
}
