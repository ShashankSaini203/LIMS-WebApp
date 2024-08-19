using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Queries.Laboratory
{
    public class GetAllLaboratoryQuery : IRequest<IEnumerable<LaboratoryResponse>>
    {
    }
}
