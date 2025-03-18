using LIMS.Application.Queries.Technician;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianQueryHandler
{
    public class GetTechnicianByIdQueryHandler : IRequestHandler<GetTechnicianByIdQuery, TechnicianResponse>
    {
        private readonly ITechnicianQueryRepository _technicianQueryRepository;

        public GetTechnicianByIdQueryHandler(ITechnicianQueryRepository technicianQueryRepository)
        {
            _technicianQueryRepository = technicianQueryRepository;
        }

        public Task<TechnicianResponse> Handle(GetTechnicianByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            throw new NotImplementedException();
        }
    }
}
