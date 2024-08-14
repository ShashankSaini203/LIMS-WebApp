using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class CreateLaboratoryCommand : IRequest<LaboratoryResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public IEnumerable<InstrumentResponse> Instruments { get; set; }
    }
}
