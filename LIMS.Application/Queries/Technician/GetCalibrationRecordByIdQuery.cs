using LIMS.Application.Responses;
using MediatR;

namespace LIMS.Application.Queries.Technician
{
    public class GetTechnicianByIdQuery : IRequest<TechnicianResponse>
    {
        public int Id { get; set; }

        public GetTechnicianByIdQuery(int id)
        {
            Id = id;
        }
    }
}
