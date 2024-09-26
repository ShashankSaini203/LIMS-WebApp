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
        public override async Task<Laboratory> UpdateAsync(Laboratory newLaboratoryData)
        {
            if (newLaboratoryData is null)
            {
                throw new ArgumentNullException("No Laboratory data provided");
            }

            try
            {
                var existingLaboratoryData = await _dataContext.Set<Laboratory>().FindAsync(newLaboratoryData.LaboratoryId);
                if (existingLaboratoryData is null)
                {
                    throw new KeyNotFoundException("No matching Laboratory found");
                }

                existingLaboratoryData.Name = newLaboratoryData.Name ?? existingLaboratoryData.Name;
                existingLaboratoryData.Location = newLaboratoryData.Location ?? existingLaboratoryData.Location;
                existingLaboratoryData.ContactNumber = newLaboratoryData.ContactNumber ?? existingLaboratoryData.ContactNumber;

                _dataContext.Set<Laboratory>().Update(existingLaboratoryData);
                _dataContext.Entry(existingLaboratoryData).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return existingLaboratoryData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
