using LIMS.Domain.Interfaces.Repository.Commands.BaseCommand;
using LIMS.Infrastructure.Database.DBcontext;

namespace LIMS.Infrastructure.Repository.Commands.BaseCommand
{
    public class BaseCommandRepository<T> : IBaseCommandRepository<T> where T : class
    {
        private readonly DataContext _dataContext;

        public BaseCommandRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            try
            {
                var addedEntity = await _dataContext.Set<T>().AddAsync(entity);
                await _dataContext.SaveChangesAsync();
                return addedEntity.Entity;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public virtual async Task DeleteAsync(T entity)
        {
            try
            {
                _dataContext.Set<T>().Remove(entity);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var entityEntry = _dataContext.Set<T>().Update(entity);
                await _dataContext.SaveChangesAsync();
                return entityEntry.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
