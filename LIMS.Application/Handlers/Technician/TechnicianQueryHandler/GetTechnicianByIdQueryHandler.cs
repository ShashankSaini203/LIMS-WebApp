using LIMS.Application.Mappers;
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

        public async Task<TechnicianResponse> Handle(GetTechnicianByIdQuery request, CancellationToken cancellationToken)
        {
            var technicianEntity = await _technicianQueryRepository.GetAsyncById(request.TechnicianId, Domain.Common.DataTables.TechnicianTable, Domain.Common.DataColumns.TechnicianId);

            if (technicianEntity == null)
            {
                throw new Exception($"No technician found with Id {request.TechnicianId}");
            }

            return AutoMapperConfiguration.Mapper.Map<TechnicianResponse>(technicianEntity);
        }
    }
}
