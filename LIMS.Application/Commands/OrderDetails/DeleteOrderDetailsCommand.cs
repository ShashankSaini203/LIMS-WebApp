using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.OrderDetails
{
    public class DeleteOrderDetailsCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteOrderDetailsCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
