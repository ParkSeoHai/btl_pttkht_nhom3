using DTO_BHQA;
using System;
using System.Drawing;
using System.Linq;
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
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangKy.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng kí!");
            }
            else
            {
               
            }
        }
    }
}