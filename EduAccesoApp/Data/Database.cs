using Microsoft.Data.Sqlite;

namespace EduAccesoApp.Data
{
    public class Database
    {
        private static string connectionString = "Data Source=educaAccesobd.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}
