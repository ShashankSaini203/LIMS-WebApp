using LIMS.Domain.Interfaces.Repository.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Infrastructure.Repository.Commands.Laboratory
{
    public class LabCommandRepository : BaseCommandRepository<Domain.Models.Laboratory>, ILabCommandRepository
    {
        public override async Task<Domain.Models.Laboratory> UpdateLaboratoryAsync(Domain.Models.Laboratory entity)
        {
            throw new NotImplementedException();
        }
    }
}
