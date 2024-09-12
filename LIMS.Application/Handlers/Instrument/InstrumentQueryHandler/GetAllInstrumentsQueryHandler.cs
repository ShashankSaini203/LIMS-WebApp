using LIMS.Application.Mappers;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using LIMS.Domain.Constants;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentQueryHandler
{
    public class GetAllInstrumentsQueryHandler : IRequestHandler<GetAllInstrumentsQuery, IEnumerable<InstrumentResponse>>
    {
        private IInstrumentQueryRepository _instrumentQueryRepository;

        public GetAllInstrumentsQueryHandler(IInstrumentQueryRepository instrumentQueryRepository)
        {
            _instrumentQueryRepository = instrumentQueryRepository;
        }
        public async Task<IEnumerable<InstrumentResponse>> Handle(GetAllInstrumentsQuery request, CancellationToken cancellationToken)
        {
            var allInstruments = await _instrumentQueryRepository.GetAllAsync(DataTables.InstrumentTable);

            return AutoMapperConfiguration.Mapper.Map<IEnumerable<InstrumentResponse>>(allInstruments);
        }
    }
}
