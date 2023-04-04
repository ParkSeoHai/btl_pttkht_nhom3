using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BHQA;
using DTO_BHQA;

namespace GUI_BHQA
{
    public partial class frmQLHD : Form
    {
        BUS_QLHD BUS_QLHD = new BUS_QLHD();
        public frmQLHD()
        {
            InitializeComponent();
        }
        // Hàm load form
        private void frmQLHD_Load(object sender, EventArgs e)
        {
            Load_dtGridQLHD(BUS_QLHD.getData());
            gbTimKiem.Hide();
        }
        // Hàm load datagridView
        private void Load_dtGridQLHD(DataTable dt)
        {
            dtGridQLHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLHD.DataSource = null;
            dtGridQLHD.Refresh();
            dtGridQLHD.DataSource = dt;
        }
        // Lấy giá trị các row khi click vào row trong dataGrid
        int index;
        private void dtGridQLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMKH.Text = dtGridQLHD.Rows[index].Cells[0].Value.ToString().Trim();
                txtMSP.Text = dtGridQLHD.Rows[index].Cells[1].Value.ToString().Trim();
                try
                {
                    dateNgayMua.Value = Convert.ToDateTime(dtGridQLHD.Rows[index].Cells[2].Value);
                }
                catch
                {
                    dateNgayMua.Value = DateTime.Now;
                }
                txtSL.Text = dtGridQLHD.Rows[index].Cells[3].Value.ToString().Trim();
            }
        }
        // Hàm clear textBox
        private void Clear_Text()
        {
            txtMKH.Clear();
            txtMSP.Clear();
            dateNgayMua.Text = DateTime.Now.ToString();
            txtSL.Clear();
        }
        // Hàm kiểm tra text box
        private bool Check_TextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMKH.Text) || string.IsNullOrWhiteSpace(txtMSP.Text) ||
                string.IsNullOrWhiteSpace(txtSL.Text))
            {
                return false;
            } else 
                return true;
        }

        // Hàm tạo đối tượng Hóa đơn
        private HoaDon Create_HD()
        {
            string day = dateNgayMua.Value.Day.ToString().Length == 1 ? $"0{dateNgayMua.Value.Day}" : dateNgayMua.Value.Day.ToString();
            string month = dateNgayMua.Value.Month.ToString().Length == 1 ? $"0{dateNgayMua.Value.Month}" : dateNgayMua.Value.Month.ToString();
            string year = dateNgayMua.Value.Year.ToString();
            string ngayMua = $"{year}{month}{day}";

            HoaDon HD = new HoaDon(txtMKH.Text, txtMSP.Text, ngayMua, Convert.ToInt32(txtSL.Text));
            return HD;
        }

        // Sự kiện thêm hóa đơn
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check_TextBox())
            {
                HoaDon HD = Create_HD();
                if(BUS_QLHD.ThemHD(HD))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Text();
                    Load_dtGridQLHD(BUS_QLHD.getData());
                } else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Nhập thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sự kiên sửa hóa đơn
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (Check_TextBox())
                {
                    HoaDon HD = Create_HD();
                    if (BUS_QLHD.SuaHD(HD))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Text();
                        Load_dtGridQLHD(BUS_QLHD.getData());
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thông tin trước khi sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sự kiện xóa hóa đơn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HoaDon HD = Create_HD();
                if (BUS_QLHD.XoaHD(HD))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Text();
                    Load_dtGridQLHD(BUS_QLHD.getData());
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sự kiện tìm kiếm 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromday = dateNgayMua1.Value.Day.ToString().Length == 1 ? $"0{dateNgayMua1.Value.Day}" : dateNgayMua1.Value.Day.ToString();
            string fromMonth = dateNgayMua1.Value.Month.ToString().Length == 1 ? $"0{dateNgayMua1.Value.Month}" : dateNgayMua1.Value.Month.ToString();
            string fromYear = dateNgayMua1.Value.Year.ToString();
            string fromDate = $"{fromYear}/{fromMonth}/{fromday}";

            string toDay = dateNgayMua2.Value.Day.ToString().Length == 1 ? $"0{dateNgayMua2.Value.Day}" : dateNgayMua2.Value.Day.ToString();
            string toMonth = dateNgayMua2.Value.Month.ToString().Length == 1 ? $"0{dateNgayMua2.Value.Month}" : dateNgayMua2.Value.Month.ToString();
            string toYear = dateNgayMua2.Value.Year.ToString();
            string toDate = $"{toYear}/{toMonth}/{toDay}";

            DataTable dt = BUS_QLHD.TimKiemHD(fromDate, toDate);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show($"Tìm thấy {dt.Rows.Count} kết quả");
                Load_dtGridQLHD(dt);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào");
            }
        }
        // Sự kiện hiển thị lại danh sách 
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_dtGridQLHD(BUS_QLHD.getData());
        }
        // Khi hover thig hiện chức năng tìm kiếm
        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            gbTimKiem.Show();
        }
    }
}
