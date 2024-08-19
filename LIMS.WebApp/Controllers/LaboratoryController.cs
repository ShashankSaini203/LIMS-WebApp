using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Queries.Laboratory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    public class LaboratoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LaboratoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // POST: api/laboratory
        [HttpPost]
        public async Task<IActionResult> CreateLaboratory([FromBody] CreateLaboratoryCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetLaboratoryById), new { id = result.Id }, result);
        }

        // GET: api/laboratory
        [HttpGet]
        public async Task<IActionResult> GetAllLaboratories()
        {
            var laboratories = await _mediator.Send(new GetAllLaboratoryQuery());
            return Ok(laboratories);
        }
    }
}
