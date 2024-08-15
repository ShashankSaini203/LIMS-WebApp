using LIMS.Application.Commands.Laboratory.Command;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
{
    public class CreateLaboratoryCommandHandler : IRequestHandler<CreateLaboratoryCommand, LaboratoryResponse>
    {
        public Task<LaboratoryResponse> Handle(CreateLaboratoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
