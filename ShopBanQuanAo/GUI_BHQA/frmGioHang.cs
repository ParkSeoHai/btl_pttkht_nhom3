using BUS_BHQA;
using DTO_BHQA;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmGioHang : Form
    {
        BUS_QLGH BUS_QLGH = new BUS_QLGH();
        string MaKH;
        public frmGioHang(string txtMaKH)
        {
            InitializeComponent();
            MaKH = txtMaKH;
        }
        private void frmGioHang_Load(object sender, EventArgs e)
        {
            GetSP_GioHang();
        }

        // List lưu các btn xóa 
        List<Button> listBtnXoaSP = new List<Button>();
        // Hàm tạo item giỏ hàng
        private void Create_Item(string maSP, string tenSP, double GiaSP, string url)
        {
            #region 
            Guna2GroupBox item = new Guna2GroupBox();
            item.Parent = layoutSP_GioHang;
            item.Text = $"{tenSP}";
            item.Size = new Size(640, 125);
            item.BackColor = Color.White;
            item.ForeColor = Color.Black;
            item.CustomBorderColor = Color.DarkGray;
            item.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            item.CustomBorderColor = Color.LightGray;
            #endregion

            #region
            PictureBox picture = new PictureBox();
            picture.Parent = item;
            picture.Size = new Size(91, 72);
            picture.Location = new Point(3, 43);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile($"{url}");
            #endregion

            #region 
            Label titleGia = new Label();
            titleGia.Parent = item;
            titleGia.Text = "Giá bán";
            titleGia.ForeColor = Color.Black;
            titleGia.BackColor = Color.Transparent;
            titleGia.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            titleGia.Location = new Point(110, 43);
            titleGia.Size = new Size(68, 21);
            #endregion

            #region 
            Label giaSp = new Label();
            giaSp.Parent = item;
            giaSp.Text = $"{GiaSP}";
            giaSp.ForeColor = Color.Black;
            giaSp.BackColor = Color.Transparent;
            giaSp.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            giaSp.Location = new Point(184, 43);
            giaSp.Size = new Size(52, 21);
            #endregion

            #region 
            Label titleSL = new Label();
            titleSL.Parent = item;
            titleSL.Text = "Số lượng";
            titleSL.ForeColor = Color.Black;
            titleSL.BackColor = Color.Transparent;
            titleSL.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            titleSL.Location = new Point(110, 82);
            titleSL.Size = new Size(84, 21);
            #endregion

            #region 
            Label SoLuong = new Label();
            SoLuong.Parent = item;
            SoLuong.Text = "1";
            SoLuong.ForeColor = Color.Black;
            SoLuong.BackColor = Color.Transparent;
            SoLuong.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            SoLuong.Location = new Point(200, 82);
            SoLuong.Size = new Size(16, 21);
            #endregion

            #region 
            Button btnXoa = new Button();
            btnXoa.Parent = item;
            btnXoa.Text = "Xóa";
            btnXoa.Name = $"{maSP}";
            btnXoa.ForeColor = Color.Black;
            btnXoa.BackColor = Color.White;
            btnXoa.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            btnXoa.Location = new Point(507, 54);
            btnXoa.Size = new Size(86, 34);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            listBtnXoaSP.Add(btnXoa);
            #endregion
        }
        // Hàm lấy sản phẩm trong giỏ hàng
        private void GetSP_GioHang()
        {
            string query = "SELECT G.MaSP, TenSP, urlImg, GiaSP FROM SANPHAM AS S, GIOHANG AS G, KHACHHANG AS K "
                + "WHERE S.MaSP = G.MaSP AND G.MaKH = K.MaKH AND K.MaKH = @MaKH";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maSP = reader.GetString(0);
                    string tenSP = reader.GetString(1);
                    string urlImg = reader.GetString(2);
                    double giaSP = reader.GetDouble(3);
                    Create_Item(maSP, tenSP, giaSP, urlImg);
                }
            } catch { }
            finally { conn.Close(); }
        }

        // Hàm xử lý sự kiện click btn xóa giỏ hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var btnXoa = (Button)sender;
            GioHang gh = new GioHang(MaKH, btnXoa.Name);
            if(XoaSpGioHang(gh))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hàm xóa sản phẩm trong giỏ hàng
        private bool XoaSpGioHang(GioHang gh)
        {
            string query = "Delete GioHang where MaKH = @MaKH and MaSP = @MaSP";
            SqlConnection conn = new SqlConnection(DBConnect.connStringHai());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaKH", gh.MaKH);
                cmd.Parameters.AddWithValue("MaSP", gh.MaSP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
    }
}
