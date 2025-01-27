using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryCommandHandlers
{
    public class DeleteLaboratoryCommandHandler : IRequestHandler<DeleteLaboratoryCommand, Unit>
    {
        private ILabCommandRepository _labCommandRepository;
        private ILabQueryRepository _labQueryRepository;

        public DeleteLaboratoryCommandHandler(ILabCommandRepository labCommandRepository, ILabQueryRepository labQueryRepository)
        {
            _labCommandRepository = labCommandRepository;
            _labQueryRepository = labQueryRepository;
        }

        public async Task<Unit> Handle(DeleteLaboratoryCommand request, CancellationToken cancellationToken)
        {
            var entityToDelete = await _labQueryRepository.GetAsyncById(request.Id, DataTables.LaboratoryTable, DataColumns.LaboratoryId);

            var laboratoryEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(entityToDelete);

            if (laboratoryEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            if (entityToDelete != null)
            {
                await _labCommandRepository.DeleteAsync(laboratoryEntity);
            }

            return Unit.Value;
        }
    }
}
