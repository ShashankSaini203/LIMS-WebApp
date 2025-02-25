using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Technician
{
    public class UpdateTechnicianCommand : IRequest<TechnicianResponse>
    {
        public int TechnicianId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public int? LaboratoryId { get; set; }
    }
}
