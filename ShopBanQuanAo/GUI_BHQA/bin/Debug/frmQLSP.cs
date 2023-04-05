using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmQLSP : Form
    {
        BUS_QLSP BUS_QLSP = new BUS_QLSP();
        public frmQLSP()
        {
            InitializeComponent();
        }
        // Hàm load form
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            cbTimKiem.Text = cbTimKiem.Items[0].ToString();
            Load_dtGridQLSP(BUS_QLSP.GetData());
            gBTimKiem.Hide();
        }
        // Hàm load datagridView
        private void Load_dtGridQLSP(DataTable dt)
        {
            dtGridQLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLSP.DataSource = null;
            dtGridQLSP.Refresh();
            dtGridQLSP.DataSource = dt;
        }
        // Xử lý placehoder text tìm kiếm
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Nhập thông tin...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Nhập thông tin...";
            }
        }
        // Lấy giá trị các row khi click vào dataGrid
        int index;
        private void dtGridQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMSP.Text = dtGridQLSP.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenSP.Text = dtGridQLSP.Rows[index].Cells[1].Value.ToString().Trim();
                txtGiaSP.Text = dtGridQLSP.Rows[index].Cells[2].Value.ToString().Trim();
                txtDVT.Text = dtGridQLSP.Rows[index].Cells[3].Value.ToString().Trim();
            }
        }
        // Hàm check text box 
        public bool Check_TextBox()
        {
            if (string.IsNullOrWhiteSpace(txtMSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtGiaSP.Text) || string.IsNullOrWhiteSpace(txtDVT.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Hàm Clear text box
        private void Clear_TextBox()
        {
            txtMSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtDVT.Text = "";
        }
        // Hàm tạo đối tượng sp
        private SanPham Create_SP()
        {
            SanPham SP = new SanPham(txtMSP.Text, txtTenSP.Text, Convert.ToDouble(txtGiaSP.Text), txtDVT.Text);
            return SP;
        }
        // Hàm tạo đối tượng qlsp
        private QuanLySanPham Create_QLSP()
        {
            QuanLySanPham QLSP = new QuanLySanPham("QL001", txtMSP.Text);
            return QLSP;
        }
        // Thêm sản phẩm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check_TextBox())
            {
                SanPham SP = Create_SP();
                QuanLySanPham QLSP = Create_QLSP();
                if (BUS_QLSP.ThemSP(SP, QLSP))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_TextBox();
                    Load_dtGridQLSP(BUS_QLSP.GetData());
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, trùng mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Sửa sản phẩm
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (Check_TextBox())
                {
                    SanPham SP = Create_SP();
                    if (BUS_QLSP.SuaSP(SP))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_TextBox();
                        Load_dtGridQLSP(BUS_QLSP.GetData());
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin trước khi sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // Xóa sản phẩm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                SanPham SP = Create_SP();
                QuanLySanPham QLSP = Create_QLSP();
                if (BUS_QLSP.XoaSP(SP, QLSP))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_TextBox();
                    Load_dtGridQLSP(BUS_QLSP.GetData());
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Tìm kiếm sản phẩm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Tìm kiếm theo Mã SP")
            {
                DataTable dt = BUS_QLSP.TimKiemSP_MaSP(txtSearch.Text);
                MessageBox.Show($"Tìm thấy {dt.Rows.Count} sản phẩm");
                Load_dtGridQLSP(dt);
            }
            else if (cbTimKiem.Text == "Tìm kiếm theo Giá SP")
            {
                DataTable dt = BUS_QLSP.TimKiemSP_GiaSP(txtSearch.Text);
                MessageBox.Show($"Tìm thấy {dt.Rows.Count} sản phẩm");
                Load_dtGridQLSP(dt);
            }
        }
        // Sự kiện khi hover thì hiện chức năng tìm kiếm
        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            gBTimKiem.Show();
        }
        // Sự kiện hiển thị danh sách
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_dtGridQLSP(BUS_QLSP.GetData());
        }
    }
}
