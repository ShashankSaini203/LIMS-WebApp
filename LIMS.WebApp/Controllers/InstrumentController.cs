using LIMS.Application.Commands.Instrument;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    public class InstrumentController : Controller
    {
        private readonly IMediator _mediator;

        public InstrumentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public IActionResult CreateInstrument()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstrument(CreateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["errorMessage"] = "Invalid data provided";
                    return RedirectToAction("GetAllLabs", "Laboratory"); ;
                }

                await _mediator.Send(newInstrumentData);
                TempData["successMessage"] = "Laboratory created successfully!";
                return View();
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.ToString();
                return View();
            }

        }
    }
}
