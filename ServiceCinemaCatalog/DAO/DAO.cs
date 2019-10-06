using MySql.Data.MySqlClient;


namespace ServiceCinemaCatalog.DAO
{
    public class DAO
    {
        public static MySqlConnection GetMySqlConnection(bool open = true,
            bool convertZeroDatetime = false, bool allowZeroDatetime = false)
        {
            string cs = "Server=127.0.0.1;Database=teste;Uid=root;Pwd=1234567;";
            var csb = new MySqlConnectionStringBuilder(cs)
            {
                AllowZeroDateTime = allowZeroDatetime,
                ConvertZeroDateTime = convertZeroDatetime
            };
            var conn = new MySqlConnection(csb.ConnectionString);
            if (open) conn.Open();
            return conn;
        }
    }
}
