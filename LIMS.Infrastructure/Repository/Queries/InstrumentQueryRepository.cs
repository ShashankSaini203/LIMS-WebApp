﻿using LIMS.Domain.Interfaces.Repository.Query;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBConnector;
using LIMS.Infrastructure.Repository.Queries.BaseQuery;

namespace LIMS.Infrastructure.Repository.Queries
{
    public class InstrumentQueryRepository : BaseQueryRepository<Instrument>, IInstrumentQueryRepository
    {
        public InstrumentQueryRepository(IDBConnector dbConnector) : base(dbConnector)
        {
        }

    }
}
