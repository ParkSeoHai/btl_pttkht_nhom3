using System.Data.SqlClient;
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
    }
}
