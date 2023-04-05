using System;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class Form_Mua_Hang : Form
    {
        public double tongTien = 0;
        public Form_Mua_Hang()
        {
            InitializeComponent();
        }
        public Form_Mua_Hang(double tongTien)
        {
            InitializeComponent();
            this.tongTien = tongTien;
        }
        private void Form_Mua_Hang_Load(object sender, EventArgs e)
        {
            lblTongSoTienHang.Text = tongTien.ToString() + "$";
            lblTienShip.Text = "3$";
            lblTienDichVu.Text = "0.5$";
            lblTongSoTien.Text = (tongTien + 3 + 0.5).ToString() + "$";
        }
        string check = "abcdefghiklmnoupqxyztsj";
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Số Điện Thoại Không Được Rỗng");
                errorProvider1.SetError(txtSoDienThoai, "Chưa Nhập Đủ TT");
            }
            else if (txtSoDienThoai.Text.Contains(check))
            {
                MessageBox.Show("Số Điện Thoại Không Được Chứa Chữ Số");
            }
            if (txtDiaChiNhanHang.Text == "")
            {
                MessageBox.Show("Địa Chỉ Không Được Rỗng");
                errorProvider1.SetError(txtDiaChiNhanHang, "Chưa Nhập Đủ TT");
            }

            if (txtDiaChiNhanHang.Text != "" && txtSoDienThoai.Text != "" && txtSoDienThoai.Text.Contains(check) == false)
            {
                errorProvider1.Clear();
                MessageBox.Show("Đặt Hàng Thành Công. Trong Vài Ngày Tới Chú Ý Điện Thoại Của Quý Khách. Xin Cảm Ơn.",
               "Thông Báo",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }
    }
}
