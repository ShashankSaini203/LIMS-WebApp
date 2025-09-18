using LIMS.Application.Commands.OrderDetails;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class UpdateOrderDetailsCommandHandler : IRequestHandler<UpdateOrderDetailsCommand, OrderDetailsResponse>
    {
        private readonly IOrderDetailsCommandRepository _orderDetailsCommandRepository;
        private readonly IOrderDetailsQueryRepository _orderDetailsQueryRepository;

        public UpdateOrderDetailsCommandHandler(IOrderDetailsCommandRepository orderDetailsCommandRepository, IOrderDetailsQueryRepository orderDetailsQueryRepository)
        {
            _orderDetailsCommandRepository = orderDetailsCommandRepository;
            _orderDetailsQueryRepository = orderDetailsQueryRepository;
        }

        public async Task<OrderDetailsResponse> Handle(UpdateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            var existing = await _orderDetailsQueryRepository.GetAsyncById(request.OrderId, DataTables.OrderDetailTable, DataColumns.OrderId);
            if (existing == null)
            {
                throw new Exception($"No OrderDetails found with Id {request.OrderId}");
            }

            var orderEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.OrderDetails>(request);


            var updated = await _orderDetailsCommandRepository.UpdateAsync(orderEntity);
            return AutoMapperConfiguration.Mapper.Map<OrderDetailsResponse>(updated);
        }
    }
}

