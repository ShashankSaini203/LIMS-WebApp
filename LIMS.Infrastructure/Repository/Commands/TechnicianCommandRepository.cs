using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class TechnicianCommandRepository: BaseCommandRepository<Technician>, ITechnicianCommandRepository
    {
        public TechnicianCommandRepository(DataContext _dataContext) : base(_dataContext)
        {
            
        }
    }
}
