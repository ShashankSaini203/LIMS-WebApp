using LIMS.Application.Commands.OrderDetails;
using LIMS.Application.Queries.OrderDetails;
using LIMS.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class OrderDetailsController : BaseController
    {
        public OrderDetailsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAllOrderDetails")]
        public async Task<IEnumerable<OrderDetailsResponse>> GetAllOrderDetails()
        {
            var allOrderDetails = await _mediator.Send(new GetAllOrderDetailsQuery());
            return allOrderDetails;
        }

        [HttpPost("CreateOrderDetails")]
        public async Task<OrderDetailsResponse> CreateOrderDetails(CreateOrderDetailsCommand createOrderDetailsCommand)
        {
            try
            {
                var response = await _mediator.Send(createOrderDetailsCommand);
                return response;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }
    }
}
