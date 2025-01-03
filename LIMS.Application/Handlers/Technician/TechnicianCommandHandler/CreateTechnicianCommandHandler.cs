using LIMS.Application.Commands.Technician;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class CreateTechnicianCommandHandler : IRequestHandler<CreateTechnicianCommand, TechnicianResponse>
    {


        public async Task<TechnicianResponse> Handle(CreateTechnicianCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
