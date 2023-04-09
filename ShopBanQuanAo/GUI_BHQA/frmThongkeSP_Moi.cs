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
    public partial class frmThongkeSP_Moi : Form
    {
        public frmThongkeSP_Moi()
        {
            InitializeComponent();
        }

        private void frmThongkeSP_Moi_Load(object sender, EventArgs e)
        {
            // List report
            List<DTO_BHQA.SanPham> listReport = new List<DTO_BHQA.SanPham>();

            string query = "Select * from SanPham";
            SqlConnection conn = DBConnect.chuoiKetNoiCua_Hai();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DTO_BHQA.SanPham sp = new DTO_BHQA.SanPham();
                sp.MaSp = reader.GetString(0);
                sp.TenSp = reader.GetString(1);
                sp.GiaSp = reader.GetDouble(2);
                sp.NgayThem = reader.GetString(3);
                sp.GiamGia = reader.GetInt32(4);
                sp.UrlImg = reader.GetString(5);

                listReport.Add(sp);
            }

            conn.Close();

            rpViewSP_Moi.LocalReport.ReportPath = "rptSP_Moi.rdlc";
            var soucre = new ReportDataSource("dsSP_Moi", listReport);
            rpViewSP_Moi.LocalReport.DataSources.Clear();
            rpViewSP_Moi.LocalReport.DataSources.Add(soucre);

            this.rpViewSP_Moi.RefreshReport();
        }
    }
}
