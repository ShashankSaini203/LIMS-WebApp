using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.OrderDetails
{
    public class CreateOrderDetailsCommand : IRequest<OrderDetailsResponse>
    {
        public int InstrumentId { get; set; }
        public int LaboratoryId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderedBy { get; set; }
        public string AdditionalNotes { get; set; }
        public string Status { get; set; }
    }
}
