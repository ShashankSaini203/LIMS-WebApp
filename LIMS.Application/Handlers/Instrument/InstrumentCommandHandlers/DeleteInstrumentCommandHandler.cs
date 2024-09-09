using LIMS.Application.Commands.Instrument;
using LIMS.Application.Mappers;
using LIMS.Domain.Constants;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Interfaces.Repository.Query;
using MediatR;

namespace LIMS.Application.Handlers.Instrument.InstrumentCommandHandlers
{
    public class DeleteInstrumentCommandHandler : IRequestHandler<DeleteInstrumentCommand, Unit>
    {
        private readonly IInstrumentCommandRepository _instrumentCommandRepository;
        private readonly IInstrumentQueryRepository _instrumentQueryRepository;

        public DeleteInstrumentCommandHandler(IInstrumentCommandRepository instrumentCommandRepository, IInstrumentQueryRepository instrumentQueryRepository)
        {
            _instrumentCommandRepository = instrumentCommandRepository;
            _instrumentQueryRepository = instrumentQueryRepository;
        }

        public async Task<Unit> Handle(DeleteInstrumentCommand request, CancellationToken cancellationToken)
        {
            var instrumentToDelete = await _instrumentQueryRepository.GetAsyncById(request.Id, DataTables.InstrumentTable);
            var instrumentEntity = AutoMapperConfiguration.Mapper.Map<Domain.Models.Instrument>(instrumentToDelete);

            if (instrumentEntity == null)
            {
                throw new ApplicationException("Unable to map due to an issue with mapper.");
            }

            await _instrumentCommandRepository.DeleteAsync(instrumentEntity);
            return Unit.Value;
        }
    }
}
