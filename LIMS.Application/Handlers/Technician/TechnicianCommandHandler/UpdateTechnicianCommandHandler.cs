using LIMS.Application.Commands.Technician;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class UpdateTechnicianCommandHandler : IRequestHandler<UpdateTechnicianCommand, TechnicianResponse>
    {
        public UpdateTechnicianCommandHandler() { }

        public async Task<TechnicianResponse> IRequestHandler<UpdateTechnicianCommand, TechnicianResponse>.Handle(UpdateTechnicianCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
