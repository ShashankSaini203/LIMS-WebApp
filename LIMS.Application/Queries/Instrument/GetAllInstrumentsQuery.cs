using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Instrument
{
    public class GetAllInstrumentsQuery : IRequest<IEnumerable<InstrumentResponse>>
    {
    }
}
