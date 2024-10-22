using Dapper;
using LIMS.Domain.Interfaces.Repository.Query.BaseQuery;
using LIMS.Infrastructure.Database.DBConnector;
using System.Data;

namespace LIMS.Infrastructure.Repository.Queries.BaseQuery
{
    public class BaseQueryRepository<T> : IBaseQueryRepository<T> where T : class
    {
        public readonly IDBConnector _dbConnector;

        public BaseQueryRepository(IDBConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(string tableName)
        {
            try
            {
                var query = $"SELECT * FROM {tableName}";
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

        public virtual async Task<T> GetAsyncById(int id, string tableName)
        {
            try
            {
                var query = $"SELECT * FROM {tableName} WHERE {tableName.Substring(0,tableName.Length-1)}ID=@Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int64);

                using (var connection = _dbConnector.CreateConnection())
                {
                    var result = await connection.QueryFirstOrDefaultAsync<T>(query, parameters);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}
