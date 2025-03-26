using MediatR;

namespace LIMS.Application.Commands.Instrument
{
    public class DeleteInstrumentCommand : IRequest<Unit>
    {
        public int InstrumentId { get; set; }

        public DeleteInstrumentCommand(int instrumentId)
        {
            InstrumentId = instrumentId;
        }
    }
}
