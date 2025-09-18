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
    }
}

