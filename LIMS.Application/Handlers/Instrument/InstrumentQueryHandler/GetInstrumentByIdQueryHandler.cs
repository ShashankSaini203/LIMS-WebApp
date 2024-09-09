using LIMS.Application.Mappers;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using LIMS.Domain.Constants;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentQueryHandler
{
    public class GetInstrumentByIdQueryHandler : IRequestHandler<GetInstrumentByIdQuery, InstrumentResponse>
    {
        private IInstrumentQueryRepository _instrumentQueryRepository;

        public GetInstrumentByIdQueryHandler(IInstrumentQueryRepository instrumentQueryRepository)
        {
            _instrumentQueryRepository = instrumentQueryRepository;
        }

        public async Task<InstrumentResponse> Handle(GetInstrumentByIdQuery request, CancellationToken cancellationToken)
        {
            var instrumentEntity = await _instrumentQueryRepository.GetAsyncById(request.Id, DataTables.InstrumentTable);
            if (instrumentEntity == null)
            {
                throw new Exception("No instrument found with given Id");
            }

            return AutoMapperConfiguration.Mapper.Map<InstrumentResponse>(instrumentEntity);
        }
    }
}
