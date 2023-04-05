using DTO_BHQA;
using GUI_BHQA.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BHQA
{
    public partial class frmThongKeSP_HOT : Form
    {
        public frmThongKeSP_HOT()
        {
            InitializeComponent();
        }

        private void frmThongKeSP_HOT_Load(object sender, EventArgs e)
        {
            // Tạo list report
            List<SP_BanChayReport> listReport = new List<SP_BanChayReport>();

            string query = "SELECT H.MaSP, S.TenSP, S.GiaSP, S.DonViTinh , SUM(SoLuong) AS SOLUONG FROM SANPHAM AS S, HOADON AS H" 
                + " WHERE S.MaSP = H.MaSP GROUP BY H.MaSP, S.TenSP, S.GiaSP, S.DonViTinh HAVING SUM(SoLuong) >= 5";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                SP_BanChayReport temp = new SP_BanChayReport();
                temp.MaSP = dataReader.GetString(0);
                temp.TenSP = dataReader.GetString(1);
                temp.DonGia = dataReader.GetDouble(2);
                temp.DonViTinh = dataReader.GetString(3);
                temp.SoLuong = dataReader.GetInt32(4);

                listReport.Add(temp);
            }

            rpViewSP_HOT.LocalReport.ReportPath = "rptSP_BanChay.rdlc";
            var source = new ReportDataSource("dsSP_BanChay", listReport);
            rpViewSP_HOT.LocalReport.DataSources.Clear();
            rpViewSP_HOT.LocalReport.DataSources.Add(source);

            this.rpViewSP_HOT.RefreshReport();
        }
    }
}
