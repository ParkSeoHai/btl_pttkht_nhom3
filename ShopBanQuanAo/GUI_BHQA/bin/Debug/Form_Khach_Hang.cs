using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace GUI_BHQA
{
    public partial class Form_Khach_Hang : Form
    {
        BUS_SP_GioHang BUS_SP_GioHang = new BUS_SP_GioHang();
        string MaKH;
        public Form_Khach_Hang() {
            InitializeComponent();
        }
        public Form_Khach_Hang(string txt)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Sự kiện click vào giỏ hàng
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            Form_GioHang smallForm = new Form_GioHang(getMaKH());
            smallForm.TopMost = true;
            smallForm.StartPosition = FormStartPosition.Manual;
            smallForm.Location = new Point(this.Width - smallForm.Width + 100, 100);
            smallForm.ShowDialog();
        }

        private void btnVeChungToi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }
    }
}
