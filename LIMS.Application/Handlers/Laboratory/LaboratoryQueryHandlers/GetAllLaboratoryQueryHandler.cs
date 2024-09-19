using LIMS.Application.Mappers;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers
{
    public class GetAllLaboratoryQueryHandler : IRequestHandler<GetAllLaboratoryQuery, IEnumerable<LaboratoryResponse>>
    {
        private ILabQueryRepository _labQueryRepository;
        public GetAllLaboratoryQueryHandler(ILabQueryRepository labQueryRepository)
        {
            _labQueryRepository = labQueryRepository;
        }
        public async Task<IEnumerable<LaboratoryResponse>> Handle(GetAllLaboratoryQuery request, CancellationToken cancellationToken)
        {
            var allLaboratories = await _labQueryRepository.GetAllAsync(DataTables.LaboratoryTable);
            return AutoMapperConfiguration.Mapper.Map<IEnumerable<LaboratoryResponse>>(allLaboratories);
        }
    }
}
