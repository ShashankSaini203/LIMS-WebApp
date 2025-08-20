using LIMS.Application.Commands.OrderDetails;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class DeleteOrderDetailsCommandHandler : IRequestHandler<DeleteOrderDetailsCommand, Unit>
    {
        Task<Unit> IRequestHandler<DeleteOrderDetailsCommand, Unit>.Handle(DeleteOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
