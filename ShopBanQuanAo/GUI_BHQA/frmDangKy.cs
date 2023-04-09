using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmDangKy : Form
    {
        BUS_QLKH BUS_QLKH = new BUS_QLKH();
        BUS_DangKy BUS_DangKy = new BUS_DangKy();
        public frmDangKy()
        {
            InitializeComponent();
        }
        // Check mật khẩu và tên tài khoản
        private bool CheckAccount(string ac) 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        // Check email
        private bool CheckEmail(string em) 
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        // Tạo đối tượng TaiKhoanDangNhap 
        string MaKH;    // Lưu mã khách hàng
        private TaiKhoanDangNhap Create_TKDN()
        {
            do
            {
                Random rd = new Random();
                MaKH = rd.Next(1, 100).ToString().Length == 1 ? $"00{rd.Next(1, 100)}" : rd.Next(1, 100).ToString();
            } while(BUS_DangKy.Check_MaKH(MaKH));

            var TKDN = new TaiKhoanDangNhap(tbTenTk.Text, tbMK.Text, tbEmail.Text, MaKH);
            return TKDN;
        }
        // Tạo đối tượng khách hàng 
        private KhachHang Create_KH()
        {
            var kh = new KhachHang(MaKH, tbTenTk.Text, "", "", "", "");
            return kh;
        }
        // Tạo đối tượng quản lý khách hàng
        private QuanLyKhachHang Create_QLKH()
        {
            var QLKH = new QuanLyKhachHang("QL001", MaKH);
            return QLKH;
        }

        // Sự kiện đăng ký tài khoản
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (!CheckAccount(tbTenTk.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTenTk.Focus();
            } else if (!CheckAccount(tbMK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMK.Focus();
            } else if (tbConfirm.Text != tbMK.Text)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirm.Focus();
            } else if (!CheckEmail(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
            } else
            {
                TaiKhoanDangNhap TKDN = Create_TKDN();
                KhachHang KH = Create_KH();
                QuanLyKhachHang QLKH = Create_QLKH();
                if (BUS_QLKH.ThemKH(KH, QLKH) && BUS_DangKy.DangKyTK(TKDN))
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản này đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BUS_QLKH.XoaKH(KH, QLKH);
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
        }
    }
}