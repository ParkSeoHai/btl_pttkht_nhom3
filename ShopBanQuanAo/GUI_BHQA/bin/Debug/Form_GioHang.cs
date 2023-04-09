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
        public Form_GioHang()
        {
            InitializeComponent();
        }

        public double tongTien = 0;
        public double sanPhamBiXoa = 0;

        public void hienThiGioHang()
        {
            
        }

        private void Form_GioHang_Load(object sender, EventArgs e)
        {
            hienThiGioHang();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVeChungToi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }
    }
}
