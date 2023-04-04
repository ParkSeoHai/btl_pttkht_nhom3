using BUS_BHQA;
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
    public partial class Form_Khach_Hang : Form
    {
        public Form_Khach_Hang()
        {
            InitializeComponent();
        }
        public void ThemSanPham()
        {
            SanPham sanPham = new SanPham("SP003", "Ao Ni", "12.5", "Chiec");    
            BUS_QLGH bUS_QLGH = new BUS_QLGH();
            if(bUS_QLGH.ThemSPGioHang(sanPham))
            {
                MessageBox.Show("KHong OK");
            }else
            {
                MessageBox.Show("OK");
            }

        }
        private void Form_Trang_Chu_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemSanPham();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemSanPham();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
