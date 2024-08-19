using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Laboratory
{
    public class GetLaboratoryByIdQuery : IRequest<LaboratoryResponse>
    {
        public int Id { get; set; }
    }
}
