using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Technician
{
    public class GetAllTechniciansQuery : IRequest<IEnumerable<TechnicianResponse>>
    {
    }
}
