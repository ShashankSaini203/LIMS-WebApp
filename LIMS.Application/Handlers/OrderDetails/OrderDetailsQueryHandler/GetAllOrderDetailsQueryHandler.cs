using LIMS.Application.Queries.OrderDetails;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsQueryHandler
{
    public class GetAllOrderDetailsQueryHandler : IRequestHandler<GetAllOrderDetailsQuery, OrderDetailsResponse>
    {
    }
}
