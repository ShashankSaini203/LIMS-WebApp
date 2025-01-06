using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Technician
{
    public class DeleteTechnicianCommand : IRequest<Unit>
    {
        [Required]
        public int TechnicianId { get; set; }

        public DeleteTechnicianCommand(int technicianId)
        {
            TechnicianId = technicianId;
        }
    }
}
