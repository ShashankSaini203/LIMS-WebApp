using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.OrderDetails
{
    public class CreateOrderDetailsCommand : IRequest<OrderDetailsResponse>
    {
        [Required]
        public int LaboratoryId { get; set; }

        [Required]
        public int InstrumentId { get; set; }

        [Required]
        public int Count { get; set; }

    }
}
