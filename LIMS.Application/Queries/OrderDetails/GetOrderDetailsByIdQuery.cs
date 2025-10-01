using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.OrderDetails
{
    public class GetOrderDetailsByIdQuery : IRequest<OrderDetailsResponse>
    {
        public int OrderId { get; set; }

        public GetOrderDetailsByIdQuery(int orderId)
        {
            OrderId = orderId;
        }
    }
}
