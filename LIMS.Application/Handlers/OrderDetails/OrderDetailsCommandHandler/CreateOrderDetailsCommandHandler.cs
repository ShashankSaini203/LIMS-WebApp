using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class CreateOrderDetailsCommandHandler : IRequestHandler<CreateOrderDetailsCommandHandler, OrderDetailsResponse>
    {
        public Task<OrderDetailsResponse> Handle(CreateOrderDetailsCommandHandler request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
