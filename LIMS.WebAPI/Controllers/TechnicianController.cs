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

        [HttpGet]
        public async Task<IEnumerable<TechnicianResponse>> GetAllTechnicians()
        {
            var response = await _mediator.Send(new GetAllTechnicianQuery());
            return response;
        }

    }
}
