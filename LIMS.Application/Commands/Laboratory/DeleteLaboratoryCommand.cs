using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class DeleteLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Id { get; set; }
    }
}
