using LIMS.Application.Commands.Instrument;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class InstrumentController : BaseController
    {
        public InstrumentController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        public async Task<InstrumentResponse> GetInstrument(int id)
        {
            var instrumentData = await _mediator.Send(new GetInstrumentByIdQuery(id));
            return instrumentData;
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
        public async Task<ActionResult<InstrumentResponse>> UpdateInstrument(UpdateInstrumentCommand newInstrumentData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["errorMessage"] = "Invalid data provided";
                    return RedirectToAction(nameof(GetInstrument), new { id = newInstrumentData.Id });
                }
                await _mediator.Send(newInstrumentData);
                return Ok("Instrument updated successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("DeleteInstrument/{id}")]
        public async Task<IActionResult> DeleteInstrument(int id)
        {
            try
            {
                await _mediator.Send(new DeleteInstrumentCommand(id));
                return BadRequest("Instrument deleted successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
