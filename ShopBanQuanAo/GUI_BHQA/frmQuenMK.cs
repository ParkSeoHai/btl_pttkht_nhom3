using BUS_BHQA;
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
    public partial class frmQuenMK : Form
    {
        //BUS_QuenMK bus_QuenMK = new BUS_QuenMK();
        public frmQuenMK()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            /*string pass = bus_QuenMK.LayLaiPass(tbEmail.Text);
            if (pass != "")
            {
                txtPassword.Text = pass;
            }
            else
            {
                txtPassword.Text = "Email bạn nhập không đúng";
            }*/
        }
    }
}
