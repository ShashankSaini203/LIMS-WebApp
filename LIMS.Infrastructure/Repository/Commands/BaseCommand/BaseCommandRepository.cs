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
        public Task<T> CreateLaboratoryAsync(T entity)
        {
            throw new NotImplementedException();
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
