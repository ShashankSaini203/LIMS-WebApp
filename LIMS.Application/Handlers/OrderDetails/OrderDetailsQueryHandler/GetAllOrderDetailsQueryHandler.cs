using LIMS.Application.Queries.OrderDetails;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsQueryHandler
{
    public class GetAllOrderDetailsQueryHandler : IRequestHandler<GetAllOrderDetailsQuery, IEnumerable<OrderDetailsResponse>>
    {
        private readonly IOrderDetailsQueryRepository _orderDetailsQueryRepository;
        public GetAllOrderDetailsQueryHandler(IOrderDetailsQueryRepository orderDetailsQueryRepository)
        {
            _orderDetailsQueryRepository = orderDetailsQueryRepository;
        }

        public async Task<IEnumerable<OrderDetailsResponse>> Handle(GetAllOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var allOrderDetails = await _orderDetailsQueryRepository.GetAllAsync(tableName: DataTables.OrderDetailTable);
        }
    }
}
