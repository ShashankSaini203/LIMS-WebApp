using System.Data;

namespace LIMS.Infrastructure.Database.DBConnector
{
    public interface IDBConnector
    {
        IDbConnection CreateConnection();
    }
}
