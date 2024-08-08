using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class LabCommandRepository : BaseCommandRepository<Laboratory>, ILabCommandRepository
    {
        private readonly DataContext _dataContext;
        public LabCommandRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        public override async Task<Laboratory> UpdateLaboratoryAsync(Laboratory entity)
        {
            throw new NotImplementedException();
        }
    }
}
