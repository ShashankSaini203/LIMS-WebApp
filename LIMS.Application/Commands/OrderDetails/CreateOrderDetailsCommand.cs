using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.OrderDetails
{
    public class CreateOrderDetailsCommand : IRequest<OrderDetailsResponse>
    {        
        public int LaboratoryId { get; set; }
        public int InstrumentId { get; set; }
        public int Count { get; set; }

    }
}
