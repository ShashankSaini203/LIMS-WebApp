using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Technician
{
    public class GetTechnicianByIdQuery : IRequest<TechnicianResponse>
    {
        public int TechnicianId { get; set; }

        public GetTechnicianByIdQuery(int technicianId)
        {
            TechnicianId = technicianId;
        }
    }
}
