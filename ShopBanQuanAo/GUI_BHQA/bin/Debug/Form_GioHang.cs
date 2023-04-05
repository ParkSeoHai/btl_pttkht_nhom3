using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace GUI_BHQA
{
    public partial class Form_GioHang : Form
    {
        string MaKH;
        public Form_GioHang(string txtMaKH)
        {
            InitializeComponent();
            MaKH = txtMaKH;
        }

        public double tongTien = 0;
        public double sanPhamBiXoa = 0;

        public void hienThiGioHang()
        {
            SanPham sanPham = new SanPham();
            GioHang gioHang = new GioHang();

            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            string query = "select * from SANPHAM, GIOHANG, KHACHHANG where SANPHAM.MaSP = GIOHANG.MaSP AND KHACHHANG.MaKH = GIOHANG.MaKH and KHACHHANG.MaKH = @MaKH";

            conn.Open();
            SqlCommand sqlCon = new SqlCommand(query, conn);
            sqlCon.Parameters.AddWithValue("MaKH", MaKH);
            SqlDataReader reader = sqlCon.ExecuteReader();
            lsvHienThi_SP_Gio_Hang.Items.Clear();
            tongTien = 0;
            while (reader.Read())
            {
                sanPham.MaSp = reader.GetString(0);
                sanPham.TenSp = reader.GetString(1);
                sanPham.GiaSp = reader.GetDouble(2);
                tongTien += reader.GetDouble(2);
                sanPham.DonViTinh = reader.GetString(3);
                gioHang.MaKH = reader.GetString(4);
                gioHang.MaSP = reader.GetString(5);
                ListViewItem item = new ListViewItem(sanPham.MaSp);
                item.SubItems.Add(sanPham.TenSp);
                item.SubItems.Add(sanPham.GiaSp.ToString());
                item.SubItems.Add(sanPham.DonViTinh);
                item.SubItems.Add(gioHang.MaKH);
                item.SubItems.Add(gioHang.MaSP);
                lsvHienThi_SP_Gio_Hang.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
        private void Form_GioHang_Load(object sender, EventArgs e)
        {
            hienThiGioHang();
        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        string maSP = "";
        private void lsvHienThi_SP_Gio_Hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
            if (lsvHienThi_SP_Gio_Hang.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = lsvHienThi_SP_Gio_Hang.SelectedItems[0];
            maSP = (item.SubItems[0].Text).Trim();
            List<string> list = new List<string>();
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_1.jpg");
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_2.jpg");
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_3.jpg");
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_4.jpg");
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_5.jpg");
            list.Add(@"D:\Workspace\C#\BTL_PTTKHT\ShopBanQuanAo\IMG\SP_6.jpg");
            if (maSP == "SP001")
            {
                pictureBox1.ImageLocation = list[0];
            }
            if (maSP == "SP002")
            {
                pictureBox1.ImageLocation = list[1];
            }
            else if (maSP == "SP003")
            {
                pictureBox1.ImageLocation = list[2];
            }
            else if (maSP == "SP004")
            {
                pictureBox1.ImageLocation = list[3];
            }
            else if (maSP == "SP005")
            {
                pictureBox1.ImageLocation = list[4];
            }
            else if (maSP == "SP006")
            {
                pictureBox1.ImageLocation = list[5];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            string query = "delete from GIOHANG where MaSP = @MaSP";
            try
            {
                conn.Open();
                SqlCommand sqlCMD = new SqlCommand(query, conn);
                sqlCMD.Parameters.AddWithValue("MaSP", maSP);

                if (sqlCMD.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành Công");
                    hienThiGioHang();
                }
                else
                {
                    MessageBox.Show("KHông Thành Công");
                }
            }
            catch { }
            finally { conn.Close(); }
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang Cập Nhật.");
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn hãy gọi đường giây nóng: 0352593469 để được hỗ trợ sớm nhất.",
           "Thông Báo",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsvHienThi_SP_Gio_Hang.Items.Count == 0)
            {
                MessageBox.Show("Bạn Phải Có Ít Nhất Một Sản Phẩm Để Mua Hàng",
                      "Thông Báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
            else
            {
                Form_Mua_Hang nhanGiaTri = new Form_Mua_Hang(tongTien);
                nhanGiaTri.TopMost = true;
                nhanGiaTri.StartPosition = FormStartPosition.Manual;
                nhanGiaTri.Location = new Point(this.Width - nhanGiaTri.Width + 100, 100);
                nhanGiaTri.Show();
            }
        }
    }
}
