using LIMS.Application.Commands.OrderDetails;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class DeleteOrderDetailsCommandHandler : IRequestHandler<DeleteOrderDetailsCommand, Unit>
    {
        private IOrderDetailsCommandRepository _orderDetailsCommandRepository;
        private IOrderDetailsQueryRepository _orderDetailsQueryRepository;

        Task<Unit> IRequestHandler<DeleteOrderDetailsCommand, Unit>.Handle(DeleteOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
