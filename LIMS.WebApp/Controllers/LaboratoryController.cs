using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Queries.Laboratory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    public class LaboratoryController : Controller
    {
        private readonly IMediator _mediator;

        public LaboratoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllLabs()
        {
            // Fetch all laboratories to display in the table
            var laboratories = await _mediator.Send(new GetAllLaboratoryQuery());
            return View(laboratories);
        }

        [HttpGet]
        public IActionResult CreateLab()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLab(CreateLaboratoryCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction(nameof(GetAllLabs));
        }

        [HttpGet]
        public IActionResult UpdateLab()
        {
            return View();
        }

        [HttpPost]
        public async IActionResult DeleteLab(int id)
        {
            await _mediator.Send(id);
            return RedirectToAction(nameof(GetAllLabs));
        }
    }
}
