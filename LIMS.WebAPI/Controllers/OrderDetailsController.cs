using LIMS.Application.Queries.OrderDetails;
using LIMS.Domain.Models;
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
        public async Task<IEnumerable<OrderDetails>> GetAllOrderDetails()
        {
        }
    }
}
