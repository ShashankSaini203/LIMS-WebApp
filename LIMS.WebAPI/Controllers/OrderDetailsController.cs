using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class OrderDetailsController : BaseController
    {
        public OrderDetailsController(IMediator mediator) : base(mediator)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
