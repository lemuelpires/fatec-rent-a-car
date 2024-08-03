using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace fatec_rent.API
{
    public class DapperDBContext : IDBContext
    {
        private readonly string _connectionString;

        public DapperDBContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("rentDB");
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
