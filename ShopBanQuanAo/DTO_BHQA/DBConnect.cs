using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DTO_BHQA
{
    public class DBConnect
    {
        // Connect của Hải
        protected string connStringHai = @"Data Source=DELL-VIP-PRO;Initial Catalog=ShopQuanAo;Integrated Security=True";
        public static SqlConnection chuoiKetNoiCua_Hai()
        {
            string connStringHai2 = @"Data Source=DELL-VIP-PRO;Initial Catalog=ShopQuanAo;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connStringHai2);
            return sqlCon;
        }

        // Connect của Duy

        // Connect của Mạnh
        public static SqlConnection chuoiKetNoiCua_XuanManh()
        {
            string strCon = @"Data Source=DESKTOP-LNJ99RH\SQLEXPRESS;Initial Catalog=ShopQuanAo;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            return sqlCon;
        }
    }
}
