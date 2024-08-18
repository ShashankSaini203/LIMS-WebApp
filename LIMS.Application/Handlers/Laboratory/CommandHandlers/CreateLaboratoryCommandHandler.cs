﻿using LIMS.Application.Commands.Laboratory;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Laboratory.CommandHandlers
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
            AutoMapperConfiguration.Mapper.Map<Domain.Models.Laboratory>(request);
        }
    }
}
