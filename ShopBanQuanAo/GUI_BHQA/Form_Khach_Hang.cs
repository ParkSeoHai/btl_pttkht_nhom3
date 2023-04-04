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
        private void ThemSanPham(string maSP)
        {
            try
            {
                _KH_Them_San_Pham bus_nhan = new _KH_Them_San_Pham();
                GioHang gioHang01 = new GioHang("KH001", $"{maSP}");
                if (bus_nhan.Bus_Nhan_Data(gioHang01))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sản Phầm Đã Có Trong giỏ hàng.");
            }
            finally
            {

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGio.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Form_Khach_Hang_Load(object sender, EventArgs e)
        {
            
        }

        private void lblGio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP001.Text);
        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GioHang smallForm = new Form_GioHang();
            smallForm.TopMost = true;
            smallForm.StartPosition = FormStartPosition.Manual;
            smallForm.Location = new Point(this.Width - smallForm.Width + 100, 100);
            smallForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP002.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP003.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP004.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP005.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemSanPham(lblMaSP006.Text);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn hãy gọi đường giây nóng: 0352593469 để được hỗ trợ sớm nhất.",
            "Thông Báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang Cập Nhật...");
        }
    }
}
