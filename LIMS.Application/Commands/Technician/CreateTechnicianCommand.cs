using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Technician
{
    public class CreateTechnicianCommand : IRequest<TechnicianResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public int? LaboratoryId { get; set; }
    }
}
