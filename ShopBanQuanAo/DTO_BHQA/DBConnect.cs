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
        public static string connStringHai()
        {
            string connStringHai = @"Data Source=DELL-VIP-PRO;Initial Catalog=ShopQuanAo;Integrated Security=True";
            return connStringHai;
        }
        public static SqlConnection chuoiKetNoiCua_Hai()
        {
            string connStringHai2 = @"Data Source=DELL-VIP-PRO;Initial Catalog=ShopQuanAo;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connStringHai2);
            return sqlCon;
        }

        // Connect của Mạnh
        public static SqlConnection chuoiKetNoiCua_XuanManh()
        {
            string s = @"Data Source = DESKTOP - LNJ99RH\SQLEXPRESS;Initial Catalog = ShopQuanAo; Integrated Security = True";
            string strCon = s;
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            return sqlCon;
        }
    }
    // Connect của Duy
    public class Connection
    {
        private static string strConnection = @"Data Source=VANDUY\SQLEXPRESS;Initial Catalog=ShopQuanAo1;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }


    }
}
