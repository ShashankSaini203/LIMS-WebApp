using LIMS.Application.Commands.Laboratory.Query;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.QueryHandlers
{
    public class GetAllLaboratoryQueryHandler : IRequestHandler<GetAllLaboratoryQuery, LaboratoryResponse>
    {
        public Task<LaboratoryResponse> Handle(GetAllLaboratoryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
