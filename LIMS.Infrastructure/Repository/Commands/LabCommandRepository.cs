using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class LabCommandRepository : BaseCommandRepository<Laboratory>, ILabCommandRepository
    {
        public override async Task<Laboratory> UpdateLaboratoryAsync(Laboratory entity)
        {
            throw new NotImplementedException();
        }
    }
}
