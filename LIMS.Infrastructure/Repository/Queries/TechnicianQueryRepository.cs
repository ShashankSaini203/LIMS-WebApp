using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBConnector;
using LIMS.Infrastructure.Repository.Queries.BaseQuery;

namespace LIMS.Infrastructure.Repository.Queries
{
    public class TechnicianQueryRepository : BaseQueryRepository<Technician>, ITechnicianQueryRepository
    {
        public TechnicianQueryRepository(IDBConnector dBConnector) : base(dBConnector)
        {

        }
    }
}
