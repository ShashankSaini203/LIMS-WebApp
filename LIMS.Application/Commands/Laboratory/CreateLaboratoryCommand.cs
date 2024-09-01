using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Laboratory
{
    public class CreateLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string ContactNumber { get; set; }
        public IEnumerable<InstrumentResponse>? Instruments { get; set; }
    }
}
