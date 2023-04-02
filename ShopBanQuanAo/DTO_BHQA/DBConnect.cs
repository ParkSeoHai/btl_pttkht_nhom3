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
        
        // Connect của Duy

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
}
