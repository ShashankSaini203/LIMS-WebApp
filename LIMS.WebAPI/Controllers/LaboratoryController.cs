using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    public class LaboratoryController : BaseController
    {
        public LaboratoryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("GetAllLaboratories")]
        public async Task<IEnumerable<LaboratoryResponse>> GetAllLabs()
        {
            // Fetch all laboratories to display in the table
            var laboratories = await _mediator.Send(new GetAllLaboratoriesQuery());
            return laboratories;
        }

        [HttpPost("CreateLab")]
        public async Task<CreateLaboratoryCommand> CreateLab(CreateLaboratoryCommand createNewLabModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new BadHttpRequestException("Invalid data provided");
                }
                await _mediator.Send(createNewLabModel);
                return createNewLabModel;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpGet("GetLaboratory/{id}")]
        public async Task<LaboratoryResponse> GetLabById(int id)
        {
            var labData = await _mediator.Send(new GetLaboratoryByIdQuery(id));
            return labData;
        }


        [HttpPost("UpdateLab")]
        public async Task<LaboratoryResponse> UpdateLab(UpdateLaboratoryCommand updatedLab)
        {
            var updatedLabResult = await _mediator.Send(updatedLab);
            return updatedLabResult;
        }

        [HttpDelete("DeleteLab")]
        public async Task<string> DeleteLab(int id)
        {
            await _mediator.Send(new DeleteLaboratoryCommand(id));
            return "Laboratory deleted duccessfully";
        }
    }
}