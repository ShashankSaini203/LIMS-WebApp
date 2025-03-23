using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Handlers.Laboratory.LaboratoryQueryHandlers;
using LIMS.Application.Queries.Instrument;
using LIMS.Application.Queries.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Models;
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
        public async Task<LaboratoryResponse> CreateLab(CreateLaboratoryCommand createNewLabModel)
        {
            try
            {
                var createdLaboratory = await _mediator.Send(createNewLabModel);
                return createdLaboratory;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpGet("GetLaboratory/{id}")]
        public async Task<LaboratoryResponse> GetLabById(int id)
        {
            try
            {
            var labData = await _mediator.Send(new GetLaboratoryByIdQuery(id));
            return labData;
        }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }


        [HttpPost("UpdateLab")]
        public async Task<LaboratoryResponse> UpdateLab(UpdateLaboratoryCommand updatedLab)
        {
            try
            {
            var updatedLabResult = await _mediator.Send(updatedLab);
            return updatedLabResult;
        }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpDelete("DeleteLab")]
        public async Task<string> DeleteLab(int id)
        {
            try
            {
            await _mediator.Send(new DeleteLaboratoryCommand(id));
            return "Laboratory deleted duccessfully";
        }
            catch (Exception ex)
            {

                throw new BadHttpRequestException("Bad Request", ex);
            }
        }
    }
}