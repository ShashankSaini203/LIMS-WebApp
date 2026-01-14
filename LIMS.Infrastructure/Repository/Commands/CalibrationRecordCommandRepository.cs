using LIMS.Application.Responses;
using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class CalibrationRecordCommandRepository : BaseCommandRepository<CalibrationRecord>, ICalibrationRecordCommandRepository
    {
        private DataContext _dataContext;

        public CalibrationRecordCommandRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public override async Task<CalibrationRecord> CreateAsync(CalibrationRecord entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var isInstrumentAvailabe = await _dataContext.Set<Instrument>().FindAsync(entity.InstrumentId);
            if (isInstrumentAvailabe is null)
            {
                throw new KeyNotFoundException($"No Instrument found with the provided id {entity.InstrumentId}");
            }

            var isTechnicianAvailable = await _dataContext.Set<Technician>().FindAsync(entity.TechnicianId);
            if (isTechnicianAvailable is null)
            {
                throw new KeyNotFoundException($"No Technician available with the provided id {entity.TechnicianId}");
            }

            var addedCalibrationRecord= _dataContext.CalibrationRecords.Add(entity);
            await _dataContext.SaveChangesAsync();
            return addedCalibrationRecord.Entity;

        }

    }
}
