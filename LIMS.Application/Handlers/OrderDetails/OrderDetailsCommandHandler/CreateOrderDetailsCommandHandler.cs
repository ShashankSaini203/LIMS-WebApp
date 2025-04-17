using LIMS.Application.Commands.OrderDetails;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.OrderDetails.OrderDetailsCommandHandler
{
    public class CreateOrderDetailsCommandHandler : IRequestHandler<CreateOrderDetailsCommand, OrderDetailsResponse>
    {
        private readonly IOrderDetailsCommandRepository _orderDetailsCommandRepository;
        public CreateOrderDetailsCommandHandler(IOrderDetailsCommandRepository orderDetailsCommandRepository)
        {
            _orderDetailsCommandRepository = orderDetailsCommandRepository;
        }

        public async Task<OrderDetailsResponse> Handle(CreateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            var createOrderDetailsRequest = AutoMapperConfiguration.Mapper.Map<CreateOrderDetailsCommand, LIMS.Domain.Models.OrderDetails>(request);
        }
    }
}
