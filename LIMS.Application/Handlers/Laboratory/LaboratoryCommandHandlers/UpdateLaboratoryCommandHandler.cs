using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryCommandHandlers
{
    public class UpdateLaboratoryCommandHandler : IRequestHandler<UpdateLaboratoryCommand, LaboratoryResponse>
    {
        private ILabCommandRepository _labCommandRepository;

        public UpdateLaboratoryCommandHandler(ILabCommandRepository labCommandRepository)
        {
            _labCommandRepository = labCommandRepository;
        }

        public async Task<LaboratoryResponse> Handle(UpdateLaboratoryCommand request, CancellationToken cancellationToken)
        {
            var laboratoryEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(request);
            
            if (laboratoryEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            var result = await _labCommandRepository.UpdateAsync(laboratoryEntity);
            var mappedResult = AutoMapperConfiguration.Mapper.Map<LaboratoryResponse>(result);
            if (mappedResult == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }
            return mappedResult;
        }
    }
}
