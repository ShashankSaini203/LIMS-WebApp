using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.LaboratoryCommandHandlers
{
    public class CreateLaboratoryCommandHandler : IRequestHandler<CreateLaboratoryCommand, LaboratoryResponse>
    {
        private readonly ILabCommandRepository _labCommandRepository;

        public CreateLaboratoryCommandHandler(ILabCommandRepository labCommandRepository)
        {
            _labCommandRepository = labCommandRepository;
        }

        public async Task<LaboratoryResponse> Handle(CreateLaboratoryCommand request, CancellationToken cancellationToken)
        {
            var laboratoryEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(request);

            if (laboratoryEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            var response = await _labCommandRepository.CreateAsync(laboratoryEntity);
            return AutoMapperConfiguration.Mapper.Map<LaboratoryResponse>(response);

        }
    }
}
