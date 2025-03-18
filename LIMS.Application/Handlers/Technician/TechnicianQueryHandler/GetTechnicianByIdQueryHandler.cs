using LIMS.Application.Queries.Technician;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianQueryHandler
{
    public class GetTechnicianByIdQueryHandler : IRequestHandler<GetTechnicianByIdQuery, TechnicianResponse>
    {
        public Task<TechnicianResponse> Handle(GetTechnicianByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
