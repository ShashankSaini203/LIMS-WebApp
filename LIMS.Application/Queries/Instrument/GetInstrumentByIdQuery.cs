using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Instrument
{
    public class GetInstrumentByIdQuery : IRequest<InstrumentResponse>
    {
        public int Id { get; set; }

        public GetInstrumentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
