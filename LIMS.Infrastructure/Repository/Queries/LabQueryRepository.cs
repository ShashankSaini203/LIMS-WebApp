﻿using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBConnector;
using LIMS.Infrastructure.Repository.Queries.BaseQuery;

namespace LIMS.Infrastructure.Repository.Queries
{
    public class LabQueryRepository : BaseQueryRepository<Laboratory>, ILabQueryRepository
    {
        public LabQueryRepository(IDBConnector dbConnector) : base(dbConnector)
        {
        }
    }
}
