using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class CreateLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
    }
}
