using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Technician
{
    public class GetAllTechnicianQuery : IRequest<IEnumerable<TechnicianResponse>>
    {
    }
}
