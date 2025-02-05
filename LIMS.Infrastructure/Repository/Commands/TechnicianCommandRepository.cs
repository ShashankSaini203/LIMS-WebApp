using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class TechnicianCommandRepository: BaseCommandRepository<Technician>, ITechnicianCommandRepository
    {
        private readonly DataContext _dataContext;
        public TechnicianCommandRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public override async Task<Technician> UpdateAsync(Technician updatedTechnicianData)
        {
            var existingTechnicianData = await _dataContext.Set<Technician>().FindAsync(updatedTechnicianData.TechnicianId);
            if (existingTechnicianData != null)
            {
                throw new Exception($"No technician with id {updatedTechnicianData.TechnicianId} found.");
            }

            existingTechnicianData.FirstName = updatedTechnicianData.FirstName ?? existingTechnicianData.FirstName;
            existingTechnicianData.LastName = updatedTechnicianData.LastName ?? existingTechnicianData.LastName;
            existingTechnicianData.Email = updatedTechnicianData.Email ?? existingTechnicianData.Email;
            existingTechnicianData.Status = updatedTechnicianData.Status ?? existingTechnicianData.Status;
            existingTechnicianData.Phone = updatedTechnicianData.Phone ?? existingTechnicianData.Phone;

            if (updatedTechnicianData.LaboratoryId > 0)
        {
                var doesLabExist = await _dataContext.Set<Laboratory>().FindAsync(updatedTechnicianData.LaboratoryId);
                if (doesLabExist != null)
                    existingTechnicianData.LaboratoryId = updatedTechnicianData.LaboratoryId;
            }
            else
            {
                existingTechnicianData.LaboratoryId = 0;
            }

            var result = 
        }
    }
}
