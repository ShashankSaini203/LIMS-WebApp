using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
{
    public class DeleteLaboratoryCommandHandler : IRequestHandler<DeleteLaboratoryCommand, LaboratoryResponse>
    {
        private ILabCommandRepository _labCommandRepository;

        public DeleteLaboratoryCommandHandler(ILabCommandRepository labCommandRepository)
        {
            _labCommandRepository = labCommandRepository;
        }

        public async Task<LaboratoryResponse> Handle(DeleteLaboratoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
