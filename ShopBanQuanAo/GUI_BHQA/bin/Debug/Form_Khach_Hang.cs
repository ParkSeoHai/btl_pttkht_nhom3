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
        _KH_Them_San_Pham bus_nhan = new _KH_Them_San_Pham();
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
            string query = "SELECT KHACHHANG.MaKH FROM TaiKhoanDangNhap, KHACHHANG WHERE TaiKhoanDangNhap.MaKH = KHACHHANG.MaKH AND KHACHHANG.MaKH IN (SELECT MaKH FROM TaiKhoanDangNhap WHERE TenTK = @TenDN)";
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
        private void ThemSanPham(string MaKH, string maSP)
        {
            GioHang gioHang = new GioHang(MaKH, maSP);
            if (bus_nhan.Bus_Nhan_Data(gioHang))
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

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GioHang smallForm = new Form_GioHang(getMaKH());
            smallForm.TopMost = true;
            smallForm.StartPosition = FormStartPosition.Manual;
            smallForm.Location = new Point(this.Width - smallForm.Width + 100, 100);
            smallForm.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn hãy gọi đường giây nóng: 0352593469 để được hỗ trợ sớm nhất.",
            "Thông Báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang Cập Nhật...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP001.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP002.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP003.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP004.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP005.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemSanPham(getMaKH(), lblMaSP006.Text);
        }
    }
}
