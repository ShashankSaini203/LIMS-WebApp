using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
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
        public async Task<IEnumerable<LaboratoryResponse>> GetAllLabs()
        {
            // Fetch all laboratories to display in the table
            var laboratories = await _mediator.Send(new GetAllLaboratoryQuery());
            return laboratories;
        }

        [HttpPost]
        public async Task<ActionResult> CreateLab(CreateLaboratoryCommand newLabData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["errorMessage"] = "Invalid data provided";
                    return View();
                }

                await _mediator.Send(newLabData);
                TempData["successMessage"] = "Laboratory created successfully!";
                return Ok("Laboratory created successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        public async Task<IActionResult> UpdateLab(int id)
        {
            try
            {
                var labToEdit = await _mediator.Send(new GetLaboratoryByIdQuery(id));
                return View(labToEdit);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(GetAllLabs));
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateLab(UpdateLaboratoryCommand updatedLab)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["errorMessage"] = "Invalid data provided";
                    return View();
                }

                var updatedLabResult = await _mediator.Send(updatedLab);
                TempData["successMessage"] = "Laboratory updated successfully!";
                return RedirectToAction(nameof(GetAllLabs));
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.ToString();
                return View();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLab(int id)
        {
            try
            {
                await _mediator.Send(new DeleteLaboratoryCommand(id));
                TempData["successMessage"] = "Laboratory deleted successfully!";
                return RedirectToAction(nameof(GetAllLabs));
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.ToString();
                return View();
            }
        }
    }
}
