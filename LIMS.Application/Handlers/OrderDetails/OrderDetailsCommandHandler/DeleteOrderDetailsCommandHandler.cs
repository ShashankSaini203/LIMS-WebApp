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

        public DeleteOrderDetailsCommandHandler(IOrderDetailsCommandRepository orderDetailsCommandRepository, IOrderDetailsQueryRepository orderDetailsQueryRepository)
        {
            _orderDetailsCommandRepository = orderDetailsCommandRepository;
            _orderDetailsQueryRepository = orderDetailsQueryRepository;
        }

        async Task<Unit> IRequestHandler<DeleteOrderDetailsCommand, Unit>.Handle(DeleteOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            var entityToDelete = await _orderDetailsQueryRepository.GetAsyncById(request.OrderId, Domain.Common.DataTables.OrderDetailTable, Domain.Common.DataColumns.OrderId);

            if (entityToDelete == null)
            {
                throw new Exception($"No OrderDetails with Id {request.OrderId} found");
            }

            var orderEntity = LIMS.Application.Mappers.AutoMapperConfiguration.Mapper.Map<Domain.Models.OrderDetails>(entityToDelete);
            if (orderEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            await _orderDetailsCommandRepository.DeleteAsync(orderEntity);

            return Unit.Value;
        }
    }
}
