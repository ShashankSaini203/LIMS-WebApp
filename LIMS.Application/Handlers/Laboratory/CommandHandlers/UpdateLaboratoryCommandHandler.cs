using LIMS.Application.Commands.Laboratory.Command;
using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
{
    public class UpdateLaboratoryCommandHandler : IRequestHandler<UpdateLaboratoryCommand, LaboratoryResponse>
    {
        public Task<LaboratoryResponse> Handle(UpdateLaboratoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
