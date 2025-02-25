using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class UpdateLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? ContactNumber { get; set; }
    }
}
