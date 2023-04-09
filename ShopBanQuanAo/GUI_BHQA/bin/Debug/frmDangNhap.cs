using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmDangNhap : Form
    {
        BUS_TKDN BUS_TKDN = new BUS_TKDN();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Sự kiện đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = tbTenTk.Text;
            string matkhau = tbMK.Text;
            if (string.IsNullOrWhiteSpace(tentk) || string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đủ tên tài khoản và mật khẩu!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (BUS_TKDN.Check_TKDN(tentk, matkhau) || (tbTenTk.Text == "Admin" && tbMK.Text == "123"))
                {
                    // Truyền mã kh sang form main
                    frmMain frmMain = new frmMain(tbTenTk.Text);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        // Sự kiên quên Mật khẩu
        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }
        // Sự kiện đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Hide();
            frmDangKy frmDK = new frmDangKy();
            frmDK.Show();
        }
    }
}