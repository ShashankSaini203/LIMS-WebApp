using LIMS.Application.Commands.Technician;
using LIMS.Application.Mappers;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class DeleteTechnicianCommandHandler : IRequestHandler<DeleteTechnicianCommand, Unit>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;
        private readonly ITechnicianQueryRepository _technicianQueryRepository;

        public DeleteTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository, ITechnicianQueryRepository technicianQueryRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
            _technicianQueryRepository = technicianQueryRepository;
        }

        public async Task<Unit> Handle(DeleteTechnicianCommand request, CancellationToken cancellationToken)
        {
                var technicianEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Technician>(request.TechnicianId);
                if (technicianEntity == null)
                {
                    throw new ApplicationException("Unable to map due to an issue with mapper.");
                }

                var entityToDelete = await _technicianQueryRepository.GetAsyncById(technicianEntity.TechnicianId, Domain.Common.DataTables.TechnicianTable, Domain.Common.DataColumns.TechnicianId);
                if(entityToDelete != null)
                {
                   await _technicianCommandRepository.DeleteAsync(technicianEntity.TechnicianId);
                }
                return response;
            

        }
    }
}
