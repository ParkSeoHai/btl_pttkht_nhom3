using BUS_BHQA;
using DTO_BHQA;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmMain : Form
    {
        BUS_QLGH bus_qlgh = new BUS_QLGH();

        // Biến lưu tên kh nhận từ form đăng nhập, mã khách hàng đang đăng nhập
        string tenTK, maKH;
        public frmMain(string tbTenTK)
        {
            InitializeComponent();
            tenTK = tbTenTK;
            maKH = Get_MaKH(tenTK);
        }
        public frmMain()
        {
            InitializeComponent();
        }

        // Form load
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = tenTK;
            if(tenTK == "Admin")
            {
                txtQuyen.Text = "Admin";
            } else
            {
                txtQuyen.Text = "Người dùng";
            }
            getSP();
        }
        // Lưu list MaSP
        List<string> listMaSP = new List<string>();
        // Lưu list button buy
        List<Button> listBtn = new List<Button>(); 
        // Hàm tạo item sản phẩm
        private void Create_Item(string tenSP, string urlImg, string giaSP, string MaSP)
        {
            #region
            // Tạo item chứa sản phẩm
            Guna2GroupBox item = new Guna2GroupBox();
            item.Width = 197;
            item.Height = 258;
            item.Parent = layout_SP;
            item.Text = $"{tenSP}";
            item.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            item.ForeColor = Color.Black;
            #endregion

            #region
            // Tạo picture box hiển thị ảnh sản phẩm
            PictureBox picture = new PictureBox();
            picture.Parent = item;
            picture.Image = Image.FromFile($"{urlImg}");
            picture.Width = 191;
            picture.Height = 159;
            picture.Location = new Point(3, 43);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            #endregion

            #region
            // Tạo label lưu title
            Label titleGia = new Label();
            titleGia.Parent = item;
            titleGia.Text = "Giá:";
            titleGia.Location = new Point(5, 219);
            titleGia.BackColor = Color.White;
            titleGia.ForeColor = Color.Black;
            titleGia.Size = new Size(45, 28);
            titleGia.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            #endregion

            #region
            // Tạo label lưu giá trị của giá sản phẩm
            Label lbGia = new Label();
            lbGia.Parent = item;
            lbGia.Text = $"{giaSP}";
            lbGia.Location = new Point(50, 219);
            lbGia.BackColor = Color.White;
            lbGia.ForeColor = Color.Black;
            lbGia.Size = new Size(62, 28);
            lbGia.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            #endregion

            #region
            // Tạo button mua hàng
            Button btnBuy = new Button();
            btnBuy.Parent = item;
            btnBuy.Location = new Point(120, 215);
            btnBuy.Text = "Buy";
            btnBuy.Name = $"{MaSP}";
            btnBuy.BackColor = Color.OrangeRed;
            btnBuy.ForeColor = Color.White;
            btnBuy.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            btnBuy.Cursor = Cursors.Hand;
            btnBuy.Size = new Size(70, 28);
            btnBuy.Click += new EventHandler(btnBuy_click);
            listBtn.Add(btnBuy);
            #endregion
        }
        // Hàm lấy sản phẩm
        private void getSP()
        {
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            string query = "Select * from SanPham";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) 
                {
                    string maSP = reader.GetString(0);
                    string tenSP = reader.GetString(1);
                    string giaSp = reader.GetDouble(2).ToString();
                    string url = reader.GetString(5);

                    listMaSP.Add(maSP);
                    Create_Item(tenSP, url, giaSp, maSP);
                }
            }
            catch { }
            finally { conn.Close(); }
        }

        // Hàm lấy mã khách hàng đang đăng nhập
        private string Get_MaKH(string txtTenTK)
        {
            string MaKH;
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                string query = "SELECT K.MaKH FROM TaiKhoanDangNhap AS T, KHACHHANG AS K "
                + "WHERE T.MaKH = K.MaKH AND K.MaKH IN (SELECT MaKH FROM TaiKhoanDangNhap WHERE TenTK = @TenTK)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("TenTK", txtTenTK);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MaKH = reader.GetString(0);
                    return MaKH;
                }
            }
            catch { }
            finally { conn.Close(); }
            return null;
        }

        // Hàm tạo đối tượng giỏ hàng
        private GioHang Create_GH(string MaSP)
        {
            if (maKH != null)
            {
                GioHang gh = new GioHang(maKH, MaSP);
                return gh;
            }
            return null;
        }

        // Hàm xử lý sự kiện click btn buy
        private void btnBuy_click(object sender, EventArgs e)
        {
            if(!Check_TTKH(maKH))
            {
                DialogResult result = MessageBox.Show("Trước khi mua hàng chúng tôi cần thêm thông tin của bạn, Bạn có đồng ý?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    frmThongTinKhachHang frmTTKH = new frmThongTinKhachHang(maKH);
                    frmTTKH.ShowDialog();
                    
                }
            } else
            {
                // Lưu button người dùng click
                var btnClick = (Button)sender;
                foreach (string maSP in listMaSP)
                {
                    if (btnClick.Name == maSP)
                    {
                        GioHang item = Create_GH(maSP);
                        if (bus_qlgh.ThemSPGioHang(item))
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã có trong giỏ hàng");
                        }
                    }
                }
            }
        }

        // Hàm kiểm tra thông tin khách hàng
        private bool Check_TTKH(string txtMaKH)
        {
            string query = "Select GioiTinh, NgaySinh, DiaChi, SDT from KhachHang where MaKH = @MaKH";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", txtMaKH);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gioiTinh = reader.GetString(0);
                    string ngaySinh = reader.GetString(1);
                    string diaChi = reader.GetString(2);
                    string sdt = reader.GetString(3);
                    if (gioiTinh != "" && ngaySinh != "" && diaChi != "" && sdt != "")
                    {
                        return true;
                    }
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Sự kiện click giỏ hàng
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            btnGioHang.Checked = true;
            btnTrangChu.Checked = false;
            btnQuanLy.Checked = false;
            btnLienHe.Checked = false;
            frmGioHang frmGH = new frmGioHang(maKH);
            frmGH.ShowDialog();
        }
        // Sự kiện click quản lý
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if(tenTK == "Admin")
            {
                frmQuanLy frmQL = new frmQuanLy();
                frmQL.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không phải Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Sự kiện click Liên hệ
        private void btnLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }
        // Sự kiện click Trang chủ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            btnTrangChu.Checked = true;
            btnGioHang.Checked = false;
            btnQuanLy.Checked = false;
            btnLienHe.Checked = false;
        }
    }
}
