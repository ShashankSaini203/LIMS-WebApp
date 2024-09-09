using LIMS.Application.Mappers;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Constants;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers
{
    public class GetLaboratoryByIdQueryHandler : IRequestHandler<GetLaboratoryByIdQuery, LaboratoryResponse>
    {
        private ILabQueryRepository _labQueryRepository;

        public GetLaboratoryByIdQueryHandler(ILabQueryRepository labQueryRepository)
        {
            _labQueryRepository = labQueryRepository;
        }

        public async Task<LaboratoryResponse> Handle(GetLaboratoryByIdQuery request, CancellationToken cancellationToken)
        {
            var laboratoryEntity = await _labQueryRepository.GetAsyncById(request.Id, DataTables.LaboratoryTable);
            if (laboratoryEntity == null)
            {
                throw new Exception("No laboratory found with given Id");
            }
            return AutoMapperConfiguration.Mapper.Map<LaboratoryResponse>(laboratoryEntity);
        }
    }
}
