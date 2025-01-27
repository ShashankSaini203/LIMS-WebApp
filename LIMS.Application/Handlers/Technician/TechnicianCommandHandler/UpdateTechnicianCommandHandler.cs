using LIMS.Application.Commands.Technician;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class UpdateTechnicianCommandHandler : IRequestHandler<UpdateTechnicianCommand, TechnicianResponse>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;

        public UpdateTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
        }

        public async Task<TechnicianResponse> Handle(UpdateTechnicianCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}