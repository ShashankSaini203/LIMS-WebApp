using LIMS.Application.Queries.OrderDetails;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsQueryHandler
{
    public class GetAllOrderDetailsQueryHandler : IRequestHandler<GetAllOrderDetailsQuery, IEnumerable<OrderDetailsResponse>>
    {
        public Task<OrderDetailsResponse> Handle(GetAllOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
