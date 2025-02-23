using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Instrument
{
    public class GetInstrumentByIdQuery : IRequest<InstrumentResponse>
    {
        public int InstrumentId { get; set; }

        public GetInstrumentByIdQuery(int instrumentId)
        {
            InstrumentId = instrumentId;
        }
    }
}
