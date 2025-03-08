using LIMS.Application.Mappers;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers
{
    public class GetAllLaboratoriesQueryHandler : IRequestHandler<GetAllLaboratoriesQuery, IEnumerable<LaboratoryResponse>>
    {
        private ILabQueryRepository _labQueryRepository;

        public GetAllLaboratoriesQueryHandler(ILabQueryRepository labQueryRepository)
        {
            _labQueryRepository = labQueryRepository;
        }

        public async Task<IEnumerable<LaboratoryResponse>> Handle(GetAllLaboratoriesQuery request, CancellationToken cancellationToken)
        {
            var allLaboratories = await _labQueryRepository.GetAllAsync(DataTables.LaboratoryTable);
            return AutoMapperConfiguration.Mapper.Map<IEnumerable<LaboratoryResponse>>(allLaboratories);
        }
    }
}
