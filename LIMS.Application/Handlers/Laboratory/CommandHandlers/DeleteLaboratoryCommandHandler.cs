using LIMS.Application.Commands.Laboratory.Command;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
{
    public class DeleteLaboratoryCommandHandler : IRequestHandler<DeleteLaboratoryCommand, LaboratoryResponse>
    {
        public Task<LaboratoryResponse> Handle(DeleteLaboratoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
