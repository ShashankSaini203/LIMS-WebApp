using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace LIMS.Infrastructure.Database.DBConnector
{
    public class DBConnector : IDBConnector
    {
        private readonly IConfiguration _configuration;
        public DBConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            return new SqliteConnection(connectionString);
        }
    }
}
