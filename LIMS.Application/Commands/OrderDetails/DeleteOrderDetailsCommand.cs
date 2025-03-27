using MediatR;

namespace LIMS.Application.Commands.OrderDetails
{
    public class DeleteOrderDetailsCommand : IRequest<Unit>
    {
        public int OrderId { get; set; }

        public DeleteOrderDetailsCommand(int orderId)
        {
            OrderId = orderId;
        }
    }
}
