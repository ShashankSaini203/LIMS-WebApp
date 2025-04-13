using LIMS.Application.Commands.OrderDetails;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class CreateOrderDetailsCommandHandler : IRequestHandler<CreateOrderDetailsCommand, OrderDetailsResponse>
    {
        public Task<OrderDetailsResponse> Handle(CreateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
