﻿using LIMS.Application.Commands.Instrument;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Common;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentCommandHandlers
{
    public class CreateInstrumentCommandHandler : IRequestHandler<CreateInstrumentCommand, InstrumentResponse>
    {
        private readonly IInstrumentCommandRepository _instrumentCommandRepository;
        private ILabQueryRepository _labQueryRepository;

        public CreateInstrumentCommandHandler(IInstrumentCommandRepository instrumentCommandRepository, ILabQueryRepository labQueryRepository)
        {
            _instrumentCommandRepository = instrumentCommandRepository;
            _labQueryRepository = labQueryRepository;
        }
        public async Task<InstrumentResponse> Handle(CreateInstrumentCommand request, CancellationToken cancellationToken)
        {
            var instrumentEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Instrument>(request);

            if (instrumentEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            var response = await _instrumentCommandRepository.CreateAsync(instrumentEntity);
            return AutoMapperConfiguration.Mapper.Map<InstrumentResponse>(response);

        }
    }
}
