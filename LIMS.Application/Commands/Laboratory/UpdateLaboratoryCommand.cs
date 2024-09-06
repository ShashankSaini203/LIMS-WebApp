using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Laboratory
{
    public class UpdateLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Name should be atleast 3 characters long")]
        public string Name { get; set; }

        [Required, MinLength(2, ErrorMessage = "Location should be atleast 2 characters long")]
        public string Location { get; set; }

        [Required, Phone(ErrorMessage = "Invalid Contact Number"), DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        public ICollection<InstrumentResponse>? Instruments { get; set; }
    }
}
