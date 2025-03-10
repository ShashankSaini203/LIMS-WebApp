using LIMS.Application.Commands.Technician;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class DeleteTechnicianCommandHandler : IRequestHandler<DeleteTechnicianCommand, Unit>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;

        public DeleteTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
        }

        public async Task<Unit> Handle(DeleteTechnicianCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
