using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.OrderDetails
{
    public class UpdateOrderDetailsCommand : IRequest<OrderDetailsResponse>
    {
        public int OrderId { get; set; }
        public int? InstrumentId { get; set; }
        public int? LaboratoryId { get; set; }
        public int? Quantity { get; set; }
        public string? Address { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string? OrderedBy { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? Status { get; set; }
    }
}
