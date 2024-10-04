using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.OrderDetails
{
    public class GetOrderDetailsByIdQuery : IRequest<OrderDetailsResponse>
    {
        public int Id { get; set; }

        public GetOrderDetailsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
