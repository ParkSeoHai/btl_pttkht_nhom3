using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }

        Modify modify = new Modify();
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangKy.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng kí!");
            }
            else
            {
                string query = "select * from TaiKhoanDangNhap where Email = '" + email + "'";
                if (modify.taiKhoans(query).Count() != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.taiKhoans(query)[0].MatKhau;

                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí!";
                }
            }
        }
    }
}
