using LIMS.Application.Commands.Technician;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using MediatR;

namespace LIMS.Application.Handlers.Technician.TechnicianCommandHandler
{
    public class UpdateTechnicianCommandHandler : IRequestHandler<UpdateTechnicianCommand, TechnicianResponse>
    {
        private readonly ITechnicianCommandRepository _technicianCommandRepository;

        public UpdateTechnicianCommandHandler(ITechnicianCommandRepository technicianCommandRepository)
        {
            _technicianCommandRepository = technicianCommandRepository;
        }

        public async Task<TechnicianResponse> Handle(UpdateTechnicianCommand request, CancellationToken cancellationToken)
        {
            var UpdateTechnicianEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Technician>(request);
            if (UpdateTechnicianEntity == null)
            {
                throw new Exception("Error with the mapper");
            }
            var result = _technicianCommandRepository.UpdateAsync(UpdateTechnicianEntity);
            var mappedResult = AutoMapperConfiguration.Mapper.Map<TechnicianResponse>(result);
            if (mappedResult == null)
            {
                throw new Exception("Error with the mapper");
            }
            return mappedResult;
        }
    }
}