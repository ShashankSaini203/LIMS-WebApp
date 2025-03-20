using LIMS.Application.Commands.Technician;
using LIMS.Application.Queries.Technician;
using LIMS.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class TechnicianController : BaseController
    {
        public TechnicianController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAllTechnicians")]
        public async Task<IEnumerable<TechnicianResponse>> GetAllTechnicians()
        {
            var response = await _mediator.Send(new GetAllTechniciansQuery());
            return response;
        }

        [HttpGet("/{id}")]
        public async Task<TechnicianResponse> GetTechnicianById(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad request", ex);
            }
        }

        [HttpPost("CreateTechnician")]
        public async Task<TechnicianResponse> CreateTechnician(CreateTechnicianCommand request)
        {
            try
            {
                var response = await _mediator.Send(request);
                return response;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad request", ex);
            }
        }

        [HttpDelete("DeleteTechnician")]
        public async Task<Unit> DeleteTechnician(DeleteTechnicianCommand deleteTechnicianCommand)
        {

        }

    }
}
