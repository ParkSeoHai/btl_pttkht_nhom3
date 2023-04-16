using BUS_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmThongTinKhachHang : Form
    {
        BUS_QLKH BUS_QLKH = new BUS_QLKH();
        string MaKH;
        public frmThongTinKhachHang(string txtMaKH)
        {
            InitializeComponent();
            MaKH = txtMaKH;
        }

        private bool Check_TextBox()
        {
            if(string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Nhập đủ thông tin trước khi gửi");
                return false;
            } 
            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Check_TextBox())
            {
                string gioiTinh;
                if (radioNam.Checked)
                {
                    gioiTinh = radioNam.Text;
                }
                else
                {
                    gioiTinh = radioNu.Text;
                }
                string day = dateNS.Value.Day.ToString();
                string month = dateNS.Value.Month.ToString();
                string year = dateNS.Value.Year.ToString();
                string ngaySinh = $"{day}/{month}/{year}";
                KhachHang KH = new KhachHang(MaKH, txtHoTen.Text, gioiTinh, ngaySinh, txtDiaChi.Text, txtSDT.Text);
                if (BUS_QLKH.SuaKH(KH))
                {
                    MessageBox.Show("Gửi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
