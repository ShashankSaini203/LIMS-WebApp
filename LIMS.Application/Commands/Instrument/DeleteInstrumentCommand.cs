using MediatR;

namespace LIMS.Application.Commands.Instrument
{
    public class DeleteInstrumentCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteInstrumentCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
