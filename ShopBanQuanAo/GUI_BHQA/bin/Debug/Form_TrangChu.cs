using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace GUI_BHQA
{
    public partial class Form_TrangChu : Form
    {
        BUS_SP_GioHang BUS_SP_GioHang = new BUS_SP_GioHang();
        string MaKH;
        public Form_TrangChu() {
            InitializeComponent();
        }
        public Form_TrangChu(string txt)
        {
            InitializeComponent();
            MaKH = txt;
        }
        // Hàm lấy mã khách hàng
        private string getMaKH()
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            string query = "SELECT KHACHHANG.MaKH FROM TaiKhoanDangNhap, KHACHHANG WHERE TaiKhoanDangNhap.MaKH = KHACHHANG.MaKH "
                + "AND KHACHHANG.MaKH IN (SELECT MaKH FROM TaiKhoanDangNhap WHERE TenTK = @TenDN)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("TenDN", MaKH);
            SqlDataReader reader = cmd.ExecuteReader();
            string txtMaKH = "";
            while (reader.Read())
            {
                txtMaKH = reader.GetString(0);
            }
            conn.Close();
            return txtMaKH;
        }
        // Thêm sản phẩm vào giỏ hàng
        private void ThemSanPham(string MaKH, string maSP)
        {
            GioHang gioHang = new GioHang(MaKH, maSP);
            if (BUS_SP_GioHang.ThemSP_GioHang(gioHang))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

    }
}
