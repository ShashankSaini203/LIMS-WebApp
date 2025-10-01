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
            {
                var technicianEntity = AutoMapperConfiguration.Mapper.Map<TechnicianResponse>(request);

            }
            catch (Exception ex)
            {

            return AutoMapperConfiguration.Mapper.Map<TechnicianResponse>(technicianEntity);
            throw new NotImplementedException();
        }
    }
}
