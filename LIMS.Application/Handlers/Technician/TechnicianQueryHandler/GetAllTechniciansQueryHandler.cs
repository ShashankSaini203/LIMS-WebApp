using LIMS.Application.Mappers;
using LIMS.Application.Queries.Technician;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianQueryHandler
{
    public class GetAllTechniciansQueryHandler : IRequestHandler<GetAllTechniciansQuery, IEnumerable<TechnicianResponse>>
    {
        private readonly ITechnicianQueryRepository _technicianQueryRepository;

        public GetAllTechniciansQueryHandler(ITechnicianQueryRepository technicianQueryRepository)
        {
            _technicianQueryRepository = technicianQueryRepository;
        }

        public async Task<IEnumerable<TechnicianResponse>> Handle(GetAllTechniciansQuery request, CancellationToken cancellationToken)
        {
            var result = await _technicianQueryRepository.GetAllAsync(DataTables.TechnicianTable);
            var mappedResponse = AutoMapperConfiguration.Mapper.Map<IEnumerable<TechnicianResponse>>(result);
            if (mappedResponse == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            return mappedResponse;
        }
    }
}
