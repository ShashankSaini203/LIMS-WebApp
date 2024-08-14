using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory.Command
{
    public class DeleteLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Id { get; set; }
    }
}
