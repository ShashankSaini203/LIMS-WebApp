namespace LIMS.Domain.Interfaces.Repository.Commands.BaseCommand
{
    public interface IBaseCommandRepository<T>
    {
        Task<T> CreateLaboratoryAsync(T entity);

        Task<T> UpdateLaboratoryAsync(T entity);

        Task<T> DeleteLaboratoryAsync(int entityId);
    }
}
