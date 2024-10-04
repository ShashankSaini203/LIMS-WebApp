using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.OrderDetails
{
    public class GetAllOrderDetailsQuery : IRequest<IEnumerable<OrderDetailsResponse>>
    {
    }
}
