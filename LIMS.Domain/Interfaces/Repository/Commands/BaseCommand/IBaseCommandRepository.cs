namespace LIMS.Domain.Interfaces.Repository.Commands.BaseCommand
{
    public interface IBaseCommandRepository<T>
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(T entityId);
    }
}
