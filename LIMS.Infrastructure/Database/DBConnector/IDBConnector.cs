using System.Data;

namespace LIMS.Infrastructure.Database.DBConnector
{
    internal interface IDBConnector
    {
        IDbConnection CreateConnection();
    }
}
