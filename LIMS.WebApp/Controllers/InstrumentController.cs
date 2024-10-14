using LIMS.Application.Commands.Instrument;
using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    [Route("Instrument")]
    public class InstrumentController : Controller
    {
        private readonly IMediator _mediator;

        public InstrumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<InstrumentResponse> GetInstrument(int id)
        {
            var instrumentData = await _mediator.Send(new GetInstrumentByIdQuery(id));
            return instrumentData;
        }

        [HttpGet]
        public IActionResult CreateInstrument()
        {
            return View();
        }

        [HttpPost("CreateInstrument")]
        public async Task<ActionResult<InstrumentResponse>> CreateInstrument(CreateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid data provided");
                }

                await _mediator.Send(newInstrumentData);
                return Ok("Instrument created successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("UpdateInstrument")]
        public async Task<IActionResult> UpdateInstrument(UpdateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid data provided");
                }
                await _mediator.Send(newInstrumentData);
                TempData["successMessage"] = "Instrument updated successfully!";
                return RedirectToAction(nameof(GetInstrument), new { id = newInstrumentData.Id });
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.ToString();
                return RedirectToAction(nameof(GetInstrument), new { id = newInstrumentData.Id });
            }
        }

        [HttpDelete]
        [Route("DeleteInstrument/{id}")]
        public async Task<IActionResult> DeleteInstrument(int id)
        {
            try
            {
                await _mediator.Send(new DeleteInstrumentCommand(id));
                TempData["successMessage"] = "Instrument deleted successfully!";
                return RedirectToAction("GetAllLabs", "Laboratory");
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.ToString();
                return RedirectToAction("GetAllLabs", "Laboratory");
            }

        }
    }
}
