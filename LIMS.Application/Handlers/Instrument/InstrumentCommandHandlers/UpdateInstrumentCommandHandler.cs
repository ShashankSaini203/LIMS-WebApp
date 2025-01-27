using LIMS.Application.Commands.Instrument;
using LIMS.Application.Mappers;
using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentCommandHandlers
{
    public class UpdateInstrumentCommandHandler : IRequestHandler<UpdateInstrumentCommand, InstrumentResponse>
    {
        private readonly IInstrumentCommandRepository _instrumentCommandRepository;

        public UpdateInstrumentCommandHandler(IInstrumentCommandRepository instrumentCommandRepository)
        {
            _instrumentCommandRepository = instrumentCommandRepository;
        }
        public async Task<InstrumentResponse> Handle(UpdateInstrumentCommand request, CancellationToken cancellationToken)
        {
            var laboratoryEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Instrument>(request);

            if (laboratoryEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            var updatedInstrument = await _instrumentCommandRepository.UpdateAsync(laboratoryEntity);
            var mappedResult = AutoMapperConfiguration.Mapper.Map<InstrumentResponse>(updatedInstrument);

            if (mappedResult == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }
            return mappedResult;
        }
    }
}
