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
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
