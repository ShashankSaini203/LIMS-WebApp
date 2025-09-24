using LIMS.Application.Mappers;
using LIMS.Application.Queries.OrderDetails;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsQueryHandler
{
    public class GetOrderDetailsByIdQueryHandler : IRequestHandler<GetOrderDetailsByIdQuery, OrderDetailsResponse>
    {
        private readonly IOrderDetailsQueryRepository _orderDetailsQueryRepository;

        public GetOrderDetailsByIdQueryHandler(IOrderDetailsQueryRepository orderDetailsQueryRepository)
        {
            _orderDetailsQueryRepository = orderDetailsQueryRepository;
        }

        public async Task<OrderDetailsResponse> Handle(GetOrderDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            var orderEntity = await _orderDetailsQueryRepository.GetAsyncById(request.OrderId, DataTables.OrderDetailTable, DataColumns.OrderId);

            return AutoMapperConfiguration.Mapper.Map<OrderDetailsResponse>(orderEntity);
        }
    }
}

