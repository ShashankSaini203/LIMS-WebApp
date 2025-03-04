using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Queries.Laboratory
{
    public class GetAllLaboratoriesQuery : IRequest<IEnumerable<LaboratoryResponse>>
    {
    }
}
