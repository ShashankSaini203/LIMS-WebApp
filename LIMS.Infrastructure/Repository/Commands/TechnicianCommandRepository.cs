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

        public override async Task<Technician> UpdateAsync(Technician technician)
        {
            var existingLaboratoryData = await _dataContext.Set<Laboratory>().FindAsync(technician.TechnicianId);
            if(existingLaboratoryData != null)
            {
                throw new Exception("No lab found");
            }

            var result = 
        }
    }
}
