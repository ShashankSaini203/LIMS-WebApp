﻿using LIMS.Domain.Interfaces.Repository.Commands.BaseCommand;
using LIMS.Domain.Models;

namespace LIMS.Domain.Interfaces.Repository.Commands
{
    public interface ICalibrationCommandRepository : IBaseCommandRepository<CalibrationRecord>
    {
    }
}