using MediatR;
using LIMS.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Technician
{
    public class CreateTechnicianCommand : IRequest<TechnicianResponse>
    {
        [Required, MinLength(3, ErrorMessage = "FirstName should be atleast 3 characters long")]
        public string FirstName { get; set; }

        [Required, MinLength(3, ErrorMessage = "LastName should be atleast 3 characters long")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public int LaboratoryId { get; set; }
    }
}
