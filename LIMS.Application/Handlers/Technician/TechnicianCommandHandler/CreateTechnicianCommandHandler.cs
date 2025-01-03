using LIMS.Application.Commands.Technician;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class CreateTechnicianCommandHandler : IRequestHandler<CreateTechnicianCommand, TechnicianResponse>
    {
    }
}
