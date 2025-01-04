using LIMS.Application.Commands.Technician;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class CreateTechnicianCommandHandler : IRequestHandler<CreateTechnicianCommand, TechnicianResponse>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;

        public CreateTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
        }

        public async Task<TechnicianResponse> Handle(CreateTechnicianCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
