using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
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
            var updatedLaboratoryEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(request);
            var result = await _labCommandRepository.UpdateAsync(updatedLaboratoryEntity);
            var mappedResult = AutoMapperConfiguration.Mapper.Map<LaboratoryResponse>(result);
            return mappedResult;
        }
    }
}
