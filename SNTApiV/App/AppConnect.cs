using MySql.Data.MySqlClient;
using System.Data;

namespace SNTApiV.App
{
    public class AppConnect
    {
        private const string Server = "217.25.90.41";
        private const string UserName = "Viktor";
        private const string Password = "20022002Vk2002Vk*Vk";
        private const string DbName = "snt_buhgalter";
        private const int Port = 3306;
        private string connectionString = $"Server={Server};database={DbName};Port={Port};Uid={UserName};Pwd={Password}" ;

        private readonly MySqlConnection connection;

        public AppConnect()
        {
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection Connection => connection;
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return;
            }
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                return;
            }
            connection.Close();
        }
    }
}
