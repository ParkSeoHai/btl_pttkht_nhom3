using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_BHQA;
using BUS_BHQA;

namespace GUI_BHQA
{
    public partial class frmQLKH : Form
    {
        BUS_QLKH BUS_QLKH = new BUS_QLKH();

        public frmQLKH()
        {
            InitializeComponent();
        }

        // Form load
        private void frmQLKH_Load(object sender, EventArgs e)
        {
            cbTimKiem.Text = cbTimKiem.Items[0].ToString();
            Load_dtGridQLKH();
        }

        // Hàm Load dataGridView
        public void Load_dtGridQLKH()
        {
            dtGridQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLKH.DataSource = BUS_QLKH.getData();
        }

        // Placeholder text
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtTimKiem.Text == "Nhập nội dung ...")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập nội dung ...";
            }
        }

        // Sự kiện thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(BUS_QLKH.ThemKH())
            {
                BUS_QLKH.ThemKH();
                MessageBox.Show("Thêm thành công");
            } else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
    }
}
