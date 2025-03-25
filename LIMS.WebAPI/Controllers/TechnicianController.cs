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
            try
            {
                var response = await _mediator.Send(new GetAllTechniciansQuery());
                return response;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpGet("/{id}")]
        public async Task<TechnicianResponse> GetTechnicianById(int id)
        {
            try
            {
                var technician = await _mediator.Send(new GetTechnicianByIdQuery(id));
                return technician;
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

        [HttpPost("UpdateTechnician")]
        public async Task<TechnicianResponse> UpdateTechnician(UpdateTechnicianCommand updateTechnicianCommand)
        {
            try
            {
                var updatedTechnician = await _mediator.Send(updateTechnicianCommand);
                return updatedTechnician;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad Request", ex);
            }
        }

        [HttpDelete("DeleteTechnician")]
        public async Task<Unit> DeleteTechnician(DeleteTechnicianCommand deleteTechnicianCommand)
        {
            try
            {
                var technicianDeleted = await _mediator.Send(deleteTechnicianCommand);
                return technicianDeleted;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Bad request", ex);
            }
        }
    }
}
