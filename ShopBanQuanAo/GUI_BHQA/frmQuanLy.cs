using System;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQLKH qlkh = new frmQLKH();
            qlkh.ShowDialog();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            frmQLHD qlhd = new frmQLHD();
            qlhd.ShowDialog();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQLSP qlsp = new frmQLSP();
            qlsp.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmTK = new frmThongKe();
            frmTK.ShowDialog();
        }
    }
}
