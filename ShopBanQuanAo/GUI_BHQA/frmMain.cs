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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmMain : Form
    {
        BUS_QLGH bus_qlgh = new BUS_QLGH();
        BUS_TKDN bus_tkdn = new BUS_TKDN();

        // Biến lưu tên kh nhận từ form đăng nhập
        string tenTK;
        public frmMain(string tbTenTK)
        {
            InitializeComponent();
            tenTK = tbTenTK;
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
            titleGia.Location = new Point(13, 219);
            titleGia.BackColor = Color.White;
            titleGia.ForeColor = Color.Black;
            titleGia.Size = new Size(52, 28);
            titleGia.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            #endregion

            #region
            // Tạo label lưu giá trị của giá sản phẩm
            Label lbGia = new Label();
            lbGia.Parent = item;
            lbGia.Text = $"{giaSP}";
            lbGia.Location = new Point(60, 219);
            lbGia.BackColor = Color.White;
            lbGia.ForeColor = Color.Black;
            lbGia.Size = new Size(52, 28);
            lbGia.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            #endregion

            #region
            // Tạo button mua hàng
            Button btnBuy = new Button();
            btnBuy.Parent = item;
            btnBuy.Location = new Point(114, 211);
            btnBuy.Text = "Buy";
            btnBuy.Name = $"{MaSP}";
            btnBuy.BackColor = Color.FromArgb(94, 148, 255);
            btnBuy.ForeColor = Color.White;
            btnBuy.Font = new Font("Segoe UI Semilight", 10, FontStyle.Bold);
            btnBuy.Cursor = Cursors.Hand;
            btnBuy.Size = new Size(78, 34);
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
                int index = 0;
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
                    index++;
                }
            }
            catch { }
            finally { conn.Close(); }
        }
        // Hàm tạo đối tượng giỏ hàng
        /*private GioHang Create_GH(string MaSP)
        {
            string MaKH = Get_MaKH();
            GioHang gh = new GioHang(MaKH, MaSP);
            return gh;
        }*/
        // Hàm xử lý sự kiện click btn buy
        private void btnBuy_click(object sender, EventArgs e)
        {
            // Lưu button người dùng click
            /*var btnClick = (Button)sender;
            foreach (string maSP in listMaSP)
            {
                if (btnClick.Name == maSP)
                {
                    
                }
            }*/
        }

        // Sự kiện click giỏ hàng
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            btnGioHang.Checked = true;
            btnTrangChu.Checked = false;
            btnQuanLy.Checked = false;
            btnLienHe.Checked = false;

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
