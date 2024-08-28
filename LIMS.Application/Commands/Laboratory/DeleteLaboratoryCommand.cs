using MediatR;
using LIMS.Application.Responses;

namespace LIMS.Application.Commands.Laboratory
{
    public class DeleteLaboratoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteLaboratoryCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
