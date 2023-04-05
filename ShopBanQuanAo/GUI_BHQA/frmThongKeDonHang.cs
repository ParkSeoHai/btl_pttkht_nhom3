using DTO_BHQA;
using GUI_BHQA.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class frmThongKeDonHang : Form
    {
        public frmThongKeDonHang()
        {
            InitializeComponent();
        }

        private void frmThongKeDonHang_Load(object sender, EventArgs e)
        {
            ThongKeModel model = new ThongKeModel();

            // List DonHang
            List<HOADON> listHD = model.HOADON.ToList();

            // List report
            List<HoaDonReport> listReport = new List<HoaDonReport>();

            foreach(HOADON hd in listHD)
            {
                HoaDonReport temp = new HoaDonReport();
                temp.MaKH = hd.MaKH;
                temp.TenKH = hd.KHACHHANG.HoTen;
                temp.MaSP = hd.MaSP;
                temp.TenSP = hd.SANPHAM.TenSP;
                temp.NgayMua = hd.NgayMua.ToString();
                temp.SoLuong = Convert.ToInt32(hd.SoLuong);

                listReport.Add(temp);
            }

            rpViewHD.LocalReport.ReportPath = "rptHoaDon.rdlc";
            var source = new ReportDataSource("dsHoaDon", listReport);
            rpViewHD.LocalReport.DataSources.Clear();
            rpViewHD.LocalReport.DataSources.Add(source);

            this.rpViewHD.RefreshReport();
        }
    }
}
