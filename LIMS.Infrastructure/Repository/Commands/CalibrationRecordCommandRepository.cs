using LIMS.Domain.Interfaces.Repository.Commands;
using LIMS.Domain.Models;
using LIMS.Infrastructure.Repository.Commands.BaseCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Infrastructure.Repository.Commands
{
    internal class CalibrationRecordCommandRepository : BaseCommandRepository<CalibrationRecord> ICalibrationRecordCommandRepository
    {
    }
}
