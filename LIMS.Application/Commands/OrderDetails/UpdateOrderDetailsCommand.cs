using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.OrderDetails
{
    public class UpdateOrderDetailsCommand : IRequest<OrderDetailsResponse>
    {
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? AdditionalNotes { get; set; }
    }
}
