using System.Data.SqlClient;

namespace DTO_BHQA
{
    interface IKhachHang
    {
        void DangNhap();
        void DangKy();
        bool ThemSpVaoGioHang(GioHang gioHang);
        void SuaSpTrongGioHang();
        void XoaSpTrongGioHang();
        void TimKiemSp();
        void MuaHang();
        void DatHang();
        void ThanhToan();
    }
    public class KhachHang : Person, IKhachHang
    {
        private string _MaKH;
        private string _LoaiKH;
        private double _SoTien;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string LoaiKH { get => _LoaiKH; set => _LoaiKH = value; }
        public double SoTien { get => _SoTien; set => _SoTien = value; }
        public KhachHang() { }
        public KhachHang(string MaKH, string ten, string gioiTinh, string ngaySinh, string diaChi, string sdt, string LoaiKH, double SoTien) : base(ten, ngaySinh, diaChi, sdt, gioiTinh)
        {
            _MaKH = MaKH;
            _LoaiKH = LoaiKH;
            _SoTien = SoTien;
        }

        public void DangNhap() { }
        public void DangKy() { }
        public bool ThemSpVaoGioHang(GioHang gioHang)
        {
            string query = "Insert into GioHang values (@MaKH, @MaSP)";
            SqlConnection conn = new SqlConnection(DBConnect.connStringHai());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", gioHang.MaKH);
                cmd.Parameters.AddWithValue("MaSP", gioHang.MaSP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        public void SuaSpTrongGioHang() { }
        public void XoaSpTrongGioHang() { }
        public void TimKiemSp() { }
        public void MuaHang() { }
        public void DatHang() { }
        public void ThanhToan() { }
    }
}
