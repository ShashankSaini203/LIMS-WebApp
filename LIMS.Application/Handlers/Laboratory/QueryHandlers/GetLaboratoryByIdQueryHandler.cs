using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Application.Handlers.Laboratory.QueryHandlers
{
    public class GetLaboratoryByIdQueryHandler : IRequestHandler<GetLaboratoryByIdQuery, LaboratoryResponse>
    {
        public Task<LaboratoryResponse> Handle(GetLaboratoryByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
