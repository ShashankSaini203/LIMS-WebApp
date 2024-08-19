using Dapper;
using LIMS.Domain.Interfaces.Repository.Query.BaseQuery;
using LIMS.Infrastructure.Database.DBConnector;

namespace LIMS.Infrastructure.Repository.Queries.BaseQuery
{
    public class BaseQueryRepository<T> : IBaseQueryRepository<T>
    {
        public readonly IDBConnector _dbConnector;

        public BaseQueryRepository(IDBConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM LABORATORIES";
                using (var connection = _dbConnector.CreateConnection())
                {
                    return (await connection.QueryAsync<T>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public virtual async Task<T> GetAsyncById(int id)
        {
            try
            {
                var query = "SELECT * FROM LABORATORIES WHERE ID=@Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id);

                using (var connection = _dbConnector.CreateConnection())
                {
                    return await connection.QueryFirstOrDefaultAsync<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}
