using MediatR;

namespace LIMS.Application.Commands.Laboratory
{
    public class DeleteLaboratoryCommand : IRequest<Unit>
    {
        public int LaboratoryId { get; set; }

        public DeleteLaboratoryCommand(int laboratoryId)
        {
            LaboratoryId = laboratoryId;
        }
    }
}
