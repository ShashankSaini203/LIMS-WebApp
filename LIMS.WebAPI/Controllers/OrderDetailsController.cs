using MediatR;

namespace LIMS.WebAPI.Controllers
{
    public class OrderDetailsController : BaseController
    {
        public OrderDetailsController(IMediator mediator) : base(mediator)
        {

        }
    }
}
