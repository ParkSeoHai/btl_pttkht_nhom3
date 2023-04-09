using Guna.UI2.WinForms;
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
    public partial class frmGioHang : Form
    {
        public frmGioHang()
        {
            InitializeComponent();
        }

        // Hàm tạo item giỏ hàng
        private void Create_Item(string tenSP, string GiaSP, string url)
        {
            #region 
            Guna2GroupBox item = new Guna2GroupBox();
            item.Parent = layout_GH;
            item.Text = $"{tenSP}";
            item.Size = new Size(469, 118);
            item.BackColor = Color.White;
            item.ForeColor = Color.Black;
            item.CustomBorderColor = Color.White;
            item.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            #endregion

            #region
            PictureBox picture = new PictureBox();
            picture.Parent = item;
            picture.Size = new Size(91, 72);
            picture.Location = new Point(3, 43);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile($"{url}");
            #endregion

            #region 
            Label titleGia = new Label();
            titleGia.Parent = item;
            titleGia.ForeColor = Color.Black;
            titleGia.BackColor = Color.Transparent;
            titleGia.Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
            titleGia.Location = new Point(110, 43);
            #endregion

            #region 
            Label giaSp = new Label();
            giaSp.Parent = item;
            giaSp.Text = $"{GiaSP}";
            giaSp.ForeColor = Color.Black;
            giaSp.BackColor = Color.Transparent;
            giaSp.Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
            giaSp.Location = new Point(184, 43);
            #endregion

            #region 
            Label titleSL = new Label();
            titleSL.Parent = item;
            titleSL.Text = "Số lượng";
            titleSL.ForeColor = Color.Black;
            titleSL.BackColor = Color.Transparent;
            titleSL.Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
            titleSL.Location = new Point(110, 82);
            #endregion

            #region 
            Label SoLuong = new Label();
            SoLuong.Parent = item;
            SoLuong.Text = "1";
            SoLuong.ForeColor = Color.Black;
            SoLuong.BackColor = Color.Transparent;
            SoLuong.Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
            SoLuong.Location = new Point(200, 82);
            #endregion

            #region 
            Button btnXoa = new Button();
            btnXoa.Parent = item;
            btnXoa.Text = "Xóa";
            btnXoa.ForeColor = Color.Black;
            btnXoa.BackColor = Color.White;
            btnXoa.Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold);
            btnXoa.Location = new Point(348, 43);
            #endregion
        }
    }
}
