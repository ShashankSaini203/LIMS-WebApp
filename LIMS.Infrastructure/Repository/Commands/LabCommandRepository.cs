using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;
using Microsoft.EntityFrameworkCore;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class LabCommandRepository : BaseCommandRepository<Laboratory>, ILabCommandRepository
    {
        private readonly DataContext _dataContext;
        public LabCommandRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        public override async Task<Laboratory> UpdateAsync(Laboratory entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("No Laboratory data provided");
            }
            try
            {
                var existingLab = await _dataContext.Set<Laboratory>().FindAsync(entity.Id);
                if (existingLab is null)
                {
                    throw new KeyNotFoundException("No matching Laboratory found");
                }

                var newLab = new Laboratory()
                {
                    Id = existingLab.Id,
                    Name = entity.Name ?? existingLab.Name,
                    Location = entity.Location ?? existingLab.Location,
                    ContactNumber = entity.ContactNumber ?? existingLab.ContactNumber,
                    Instruments = entity.Instruments ?? existingLab.Instruments
                };

                var updatedLab = _dataContext.Set<Laboratory>().Update(newLab);
                _dataContext.Entry(existingLab).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return updatedLab.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
