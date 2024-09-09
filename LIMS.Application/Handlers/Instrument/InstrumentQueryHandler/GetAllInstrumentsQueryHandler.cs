using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentQueryHandler
{
    public class GetAllInstrumentsQueryHandler : IRequestHandler<GetAllInstrumentsQuery, IEnumerable<InstrumentResponse>>
    {
        public Task<IEnumerable<InstrumentResponse>> Handle(GetAllInstrumentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
