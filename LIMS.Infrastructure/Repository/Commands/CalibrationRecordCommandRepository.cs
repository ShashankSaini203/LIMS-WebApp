using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Database.DBcontext;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;

namespace LIMS.Infrastructure.Repository.Commands
{
    public class CalibrationRecordCommandRepository : BaseCommandRepository<CalibrationRecord>, ICalibrationRecordCommandRepository
    {
        private DataContext dataContext;

        public CalibrationRecordCommandRepository(DataContext dataContext) : base(dataContext)
        {
        }

    }
}
