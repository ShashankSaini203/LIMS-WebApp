using LIMS.Domain.Interfaces.Repository.Commands.BaseCommand;
using LIMS.Infrastructure.Database.DBcontext;

namespace LIMS.Infrastructure.Repository.Commands.BaseCommand
{
    public class BaseCommandRepository<T> : IBaseCommandRepository<T>
    {
        private readonly DataContext _dataContext;

        public BaseCommandRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                await _dataContext.Set<T>().AddAsync(entity);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Task<T> DeleteLaboratoryAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> UpdateLaboratoryAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
