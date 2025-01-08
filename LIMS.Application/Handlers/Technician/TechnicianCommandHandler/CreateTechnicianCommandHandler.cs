using LIMS.Application.Commands.Technician;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class CreateTechnicianCommandHandler : IRequestHandler<CreateTechnicianCommand, TechnicianResponse>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;

        public CreateTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
        }

        public async Task<TechnicianResponse> Handle(CreateTechnicianCommand request, CancellationToken cancellationToken)
        {
            var techinicianEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Technician>(request);

            if(techinicianEntity is null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            var result = await _technicianCommandRepository.CreateAsync(techinicianEntity);

            return AutoMapperConfiguration.Mapper.Map< TechnicianResponse>(result);
        }
    }
}
