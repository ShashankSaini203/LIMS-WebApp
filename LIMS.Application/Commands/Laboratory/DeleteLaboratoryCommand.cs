using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class DeleteLaboratoryCommand : IRequest<Unit>
    {
        public string Id { get; set; }
    }
}
