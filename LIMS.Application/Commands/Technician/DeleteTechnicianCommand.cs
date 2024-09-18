using MediatR;
using System.ComponentModel.DataAnnotations;

namespace LIMS.Application.Commands.Technician
{
    public class DeleteTechnicianCommand : IRequest<Unit>
    {
        [Required]
        public int Id { get; set; }

        public DeleteTechnicianCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
