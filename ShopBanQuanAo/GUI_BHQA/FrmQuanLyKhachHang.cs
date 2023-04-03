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
using System.Reflection;
using System.Xml.Linq;
using System.Data.SqlClient;

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
            Load_dtGridQLKH(BUS_QLKH.getData());
            gBTimKiem.Hide();
        }

        // Lấy giá trị các row khi click vào dataGrid
        int index;
        private void dtGridQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMKH.Text = dtGridQLKH.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenKH.Text = dtGridQLKH.Rows[index].Cells[1].Value.ToString().Trim();
                string gioiTinh = dtGridQLKH.Rows[index].Cells[2].Value.ToString().Trim();
                if (gioiTinh == "Nam" || gioiTinh == "nam" || gioiTinh == "NAM")
                {
                    radioNam.Checked = true;
                }
                else if (gioiTinh == "Nữ" || gioiTinh == "nữ" || gioiTinh == "NỮ")
                {
                    radioNu.Checked = true;
                }
                try
                {
                    dateNgaySinh.Value = Convert.ToDateTime(dtGridQLKH.Rows[index].Cells[3].Value);
                }
                catch
                {
                    dateNgaySinh.Value = DateTime.Now;
                }
                txtDiaChi.Text = dtGridQLKH.Rows[index].Cells[4].Value.ToString().Trim();
                txtSDT.Text = dtGridQLKH.Rows[index].Cells[5].Value.ToString().Trim();
                txtLoaiKH.Text = dtGridQLKH.Rows[index].Cells[6].Value.ToString().Trim();
                txtSoTien.Text = dtGridQLKH.Rows[index].Cells[7].Value.ToString().Trim();
            }
        }

        // Hàm Load dataGridView
        public void Load_dtGridQLKH(DataTable dt)
        {
            dtGridQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLKH.DataSource = null;
            dtGridQLKH.Refresh();
            dtGridQLKH.DataSource = dt;
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

        // Hàm check text box 
        private bool Check_TextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) || 
                string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiKH.Text) || string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                return false;
            } else
            {
                return true;
            }
        }

        // Hàm Clear text box
        private void Clear_TextBox()
        {
            txtMKH.Text = "";
            txtTenKH.Text = "";
            radioNam.Checked = true;
            dateNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLoaiKH.Text = "";
            txtSoTien.Text = "";
        }

        // Hàm tạo đối tượng khách hàng
        private KhachHang Create_KH()
        {
            string gioiTinh = radioNam.Text;
            if (radioNu.Checked)
            {
                gioiTinh = radioNu.Text;
            }
            string day = dateNgaySinh.Value.Day.ToString().Length <= 1 ? "0" + dateNgaySinh.Value.Day.ToString() : dateNgaySinh.Value.Day.ToString();
            string month = dateNgaySinh.Value.Month.ToString().Length <= 1 ? "0" + dateNgaySinh.Value.Month.ToString() : dateNgaySinh.Value.Month.ToString();
            string year = dateNgaySinh.Value.Year.ToString();
            string ngaySinh = day + "/" + month + "/" + year;

            double soTien;
            try
            {
                soTien = Convert.ToDouble(txtSoTien.Text);
            } catch
            {
                soTien = 0;
            }


            KhachHang KH = new KhachHang(txtMKH.Text, txtTenKH.Text, gioiTinh, ngaySinh, txtDiaChi.Text, txtSDT.Text, txtLoaiKH.Text, soTien);
            return KH;
        }
        // Hàm tạo đối tượng quản lý khách hàng
        private QuanLyKhachHang Create_QLKH()
        {
            QuanLyKhachHang QLKH = new QuanLyKhachHang("QL001", txtMKH.Text);
            return QLKH;
        }

        // Sự kiện thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check_TextBox())
            {
                KhachHang KH = Create_KH();
                QuanLyKhachHang QLKH = Create_QLKH();
                if (BUS_QLKH.ThemKH(KH, QLKH))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_TextBox();
                    Load_dtGridQLKH(BUS_QLKH.getData());
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Nhập đủ thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Sự kiện sửa khách hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang KH = Create_KH();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK && Check_TextBox())
            {
                if (BUS_QLKH.SuaKH(KH))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_TextBox();
                    Load_dtGridQLKH(BUS_QLKH.getData());
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Sự kiện xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang KH = Create_KH();
            QuanLyKhachHang QLKH = Create_QLKH();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (BUS_QLKH.XoaKH(KH, QLKH ))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_TextBox();
                    Load_dtGridQLKH(BUS_QLKH.getData());
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Hàm tìm kiếm chung
        public void TimKiem(DataTable dt)
        {
            if (dt != null)
            {
                Load_dtGridQLKH(dt);
                MessageBox.Show($"Tìm thấy {dt.Rows.Count} kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Sự kiện tìm kiếm khách hàng
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Tìm kiếm theo Mã KH")
            {
                DataTable dt = BUS_QLKH.TimKiemKH_MaKH(txtTimKiem.Text);
                TimKiem(dt);
            }
            else if (cbTimKiem.Text == "Tìm kiếm theo Họ tên")
            {
                DataTable dt = BUS_QLKH.TimKiemKH_TenKH(txtTimKiem.Text);
                TimKiem(dt);
            }
            else if (cbTimKiem.Text == "Tìm kiếm theo Loại KH")
            {
                DataTable dt = BUS_QLKH.TimKiemKH_LoaiKH(txtTimKiem.Text);
                TimKiem(dt);
            }
        }
        // Sự kiện khi hover vào btn Tìm kiếm
        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            gBTimKiem.Show();
        }
        // Sự kiện hiển thị lại danh sách
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_dtGridQLKH(BUS_QLKH.getData());
        }
    }
}
