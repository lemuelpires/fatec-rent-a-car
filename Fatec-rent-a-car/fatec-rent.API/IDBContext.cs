using System.Data;

namespace fatec_rent.API
{
    public interface IDBContext
    {
        IDbConnection GetConnection();   
    }
}
