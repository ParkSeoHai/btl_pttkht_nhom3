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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnSP_HOT_Click(object sender, EventArgs e)
        {
            frmThongKeSP_HOT frmTK_Hot = new frmThongKeSP_HOT();
            frmTK_Hot.ShowDialog();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            frmThongKeDonHang frmTKDH = new frmThongKeDonHang();
            frmTKDH.ShowDialog();
        }

        private void btnSP_NEW_Click(object sender, EventArgs e)
        {
            frmThongkeSP_Moi frmTK_New = new frmThongkeSP_Moi();
            frmTK_New.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
