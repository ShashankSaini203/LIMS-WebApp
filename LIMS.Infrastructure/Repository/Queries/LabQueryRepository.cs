using Dapper;
using LIMS.Domain.Interfaces.Repository.Query;
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

        public async override Task<IEnumerable<Laboratory>> GetAllAsync(string tableName)
        {
            var query = @"
        SELECT l.*, i.*
        FROM Laboratories l
        LEFT JOIN Instruments i ON l.Id = i.LaboratoryId";

            using (var connection = _dbConnector.CreateConnection())
            {
                var laboratoryDictionary = new Dictionary<int, Laboratory>();

                var result = await connection.QueryAsync<Laboratory, Instrument, Laboratory>(
                    query,
                    (laboratory, instrument) =>
                    {
                        if (!laboratoryDictionary.TryGetValue(laboratory.Id, out var labEntry))
                        {
                            labEntry = laboratory;
                            labEntry.Instruments = new List<Instrument>();
                            laboratoryDictionary.Add(labEntry.Id, labEntry);
                        }

                        if (instrument != null)
                        {
                            labEntry.Instruments.Add(instrument);
                        }

                        return labEntry;
                    },
                    splitOn: "Id");

                return result.Distinct().ToList();
            }
        }
    }
}
