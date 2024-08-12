using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBConnector;
using LIMS.Infrastructure.Repository.Queries.BaseQuery;

namespace LIMS.Infrastructure.Repository.Queries
{
    public class LabQueryRepository : BaseQueryRepository<Laboratory>, ILabQueryRepository
    {
        private DBConnector _dbConnector;
        public LabQueryRepository(DBConnector dbConnector) : base(dbConnector)
        {
            _dbConnector = dbConnector;
        }
    }
}
