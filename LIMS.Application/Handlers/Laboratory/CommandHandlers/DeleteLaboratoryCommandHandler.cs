using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
{
    public class DeleteLaboratoryCommandHandler : IRequestHandler<DeleteLaboratoryCommand, Unit>
    {
        private ILabCommandRepository _labCommandRepository;

        public DeleteLaboratoryCommandHandler(ILabCommandRepository labCommandRepository)
        {
            _labCommandRepository = labCommandRepository;
        }

        public async Task<Unit> Handle(DeleteLaboratoryCommand request, CancellationToken cancellationToken)
        {
            var entityToDelete = AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(request);

            if (entityToDelete != null)
            {
                await _labCommandRepository.DeleteAsync(entityToDelete);
            }

            return Unit.Value;
        }
    }
}
