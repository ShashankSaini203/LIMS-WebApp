using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Instrument
{
    public class DeleteInstrumentCommand : IRequest<Unit>
    {
        [Required]
        public int Id { get; set; }

        public DeleteInstrumentCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
